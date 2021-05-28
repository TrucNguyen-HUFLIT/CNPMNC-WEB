using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    [Authorize(Roles = "staff")]
    public class KhachHangController : Controller
    {
        private readonly QLMTContext database;
        private readonly IWebHostEnvironment hostEnvironment;
        public KhachHangController(QLMTContext db, IWebHostEnvironment hostEnvironment)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }
        public async Task<IActionResult> Index(string filter, int page, string sortEx = "TenKh")
        {

            var qry = database.KhachHangs.AsNoTracking().OrderBy(p => p.TenKh)
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                qry = qry.Where(p => p.TenKh.Contains(filter));

            }
            var model = await PagingList.CreateAsync(qry, 15, page, sortEx, "TenKh");
            model.RouteValue = new RouteValueDictionary {
            { "filter", filter}
            };
            return View(model);
            

        }
        public IActionResult Edit(int id)
        {
            var model = new ViewModelKH();

            model.ListType = database.TypeAccs.ToArray();
            model.khachHang = database.KhachHangs.Where(X => X.Idkh == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, KhachHang khachHang)
        {
            var model = new ViewModelKH
            {
                ListType = database.TypeAccs.ToArray(),
                khachHang = database.KhachHangs.Where(x => x.Idkh == id).FirstOrDefault()
            };

            if (khachHang.TenKh != null && khachHang.Email != null && khachHang.Pass != null && khachHang.Idtype != null)
            {
                model.khachHang.TenKh = khachHang.TenKh;
                model.khachHang.Idtype = khachHang.Idtype;
                model.khachHang.Email = khachHang.Email;
                model.khachHang.Pass = khachHang.Pass;
                model.khachHang.DienThoai = khachHang.DienThoai;
                model.khachHang.DiaChi = khachHang.DiaChi;
              
                string wwwRootPath = hostEnvironment.WebRootPath;

                string fileName1;
                string extension1;
                if (khachHang.UploadHinh != null)
                {
                    fileName1 = Path.GetFileNameWithoutExtension(khachHang.UploadHinh.FileName);
                    extension1 = Path.GetExtension(khachHang.UploadHinh.FileName);
                    model.khachHang.Avatar = "/img/" + fileName1 + extension1;
                    string path1 = Path.Combine(wwwRootPath + "/img/", fileName1);
                    using (var fileStream = new FileStream(path1, FileMode.Create))
                    {
                        await khachHang.UploadHinh.CopyToAsync(fileStream);
                    }
                }
                database.Update(model.khachHang);
                await database.SaveChangesAsync();
                return RedirectToAction("Index", "NhanVien");
            }
            return View(model);
        }
        
    }
    public class ViewModelKH
    {
        public MauXe[] ListMauXe { get; set; }
        public Hang[] ListHang { get; set; }
        public LoaiXe[] ListLoaiXe { get; set; }
        public LoaiXe loaiXe { get; set; }

        public KhachHang khachHang { get; set; }
        public KhachHang[] ListKhachHang { get; set; }
        public TypeAcc[] ListType { get; set; }
    }
}
