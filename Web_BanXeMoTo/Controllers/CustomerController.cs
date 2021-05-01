using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class CustomerController : Controller
    {
        //QLMoToContext _context = new QLMoToContext();
        public SelectList ListKH { get; set; }
        private readonly QLMoToContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public CustomerController(QLMoToContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnviroment = webHostEnvironment;
        }

        //public async Task<IActionResult> Index(string sort, string search)
        //{
        //    ViewData["Name"] = String.IsNullOrEmpty(sort) ? "name_desc" : "";
        //    ViewData["ID"] = String.IsNullOrEmpty(sort) ? "ID" : "";
        //    ViewData["search"] = search;
        //     var khachHangList = from s in _context.KhachHangs
        //                   select s;
        //    if (!String.IsNullOrEmpty(search))
        //    {
        //        khachHangList = khachHangList.Where(s => s.TenKh.Contains(search)
        //                               || s.DiaChi.Contains(search) || s.Idkh.Contains(search));
        //    }
        //    switch (sort)
        //    {
        //        case "name_desc":
        //            khachHangList = khachHangList.OrderByDescending(s => s.TenKh);
        //                break;
        //        case "ID":
        //            khachHangList = khachHangList.OrderByDescending(s => s.Idkh);
        //            break;
        //        default:
        //            khachHangList = khachHangList.OrderBy(s => s.TenKh);
        //            break;
        //    }
        //    //var khachhang = _context.KhachHangs
        //    //    .Include(kh => kh.IdloaiKhNavigation).AsNoTracking();
        //    //var kh = await _context.KhachHangs.ToListAsync();
        //    return View(await khachHangList.Include(kh=> kh.IdloaiKhNavigation).AsNoTracking().ToListAsync());
        //}

        public async Task<IActionResult> Index(string sort, string search, string currentFilter, int? pageNumber)
        {
            ViewData["Name"] = String.IsNullOrEmpty(sort) ? "name_desc" : "";
            ViewData["IDTK"] = String.IsNullOrEmpty(sort) ? "IDTK" : "";
            ViewData["IDKH"] = String.IsNullOrEmpty(sort) ? "IDKH" : "";

            ViewData["search"] = search;
            var khachHangList = from s in _context.KhachHangs
                                select s;
            if (!String.IsNullOrEmpty(search))
            {
                khachHangList = khachHangList.Where(s => s.TenKh.Contains(search) || s.Idtk.Contains(search) || s.Idkh.Contains(search));
            }
            if (search != null)
            {
                pageNumber = 1;
            }
            else
            {
                search = currentFilter;
            }
            switch (sort)
            {
                case "name_desc":
                    khachHangList = khachHangList.OrderByDescending(s => s.TenKh);
                    break;
                case "IDKH":
                    khachHangList = khachHangList.OrderByDescending(s => s.Idkh);
                    break;
                case "IDTK":
                    khachHangList = khachHangList.OrderByDescending(s => s.Idtk);
                    break;
                default:
                    khachHangList = khachHangList.OrderBy(s => s.TenKh);
                    break;
            }
            //var khachhang = _context.KhachHangs
            //    .Include(kh => kh.IdloaiKhNavigation).AsNoTracking();
            //var kh = await _context.KhachHangs.ToListAsync();
            int pageSize = 2;
            khachHangList = khachHangList.Include(kh => kh.IdloaiKhNavigation).AsNoTracking();
            return View(await PaggingList<KhachHang>.CreateAsync(khachHangList, pageNumber ?? 1, pageSize));
        }
        public async Task<IActionResult> Detail(string id)
        {
            return View(await _context.KhachHangs.FindAsync(id));

        }

        public async Task<IActionResult> Edit(string id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            var khachhang = await _context.KhachHangs
                .Include(c => c.IdloaiKhNavigation)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Idkh == id);
            if (khachhang == null)
            {
                return NotFound();
            }
            Dropdownlist(khachhang.IdloaiKh);
            return View(khachhang);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Idkh,IdloaiKh,Idtk,TenKh,DiaChi,DienThoai,Avatar,Image")] KhachHang khachhang)
        {
            if (id != khachhang.Idkh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFileName = UploadedFile(khachhang);
                    khachhang.Avatar = uniqueFileName;
                    _context.Update(khachhang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangExists(khachhang.Idkh))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            Dropdownlist(khachhang.IdloaiKh);
            return View(khachhang);
        }

        private bool KhachHangExists(string idkh)
        {
            throw new NotImplementedException();
        }

        private string UploadedFile(KhachHang kh)
        {
            string uniqueFileName = null;

            if (kh.Image != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnviroment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + kh.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    kh.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        private void Dropdownlist(object seleted = null)
        {
            var Query = from kh in _context.LoaiKhs
                        orderby kh.TenLoaiKh
                        select kh;
            ViewBag.IdloaiKh = new SelectList(Query.AsNoTracking(), "IdloaiKh", "TenLoaiKh", seleted);
        }

    }
}
