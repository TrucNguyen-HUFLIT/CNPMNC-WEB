using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;
using X.PagedList;

namespace Web_BanXeMoTo.Controllers
{
    [Authorize(Roles = "admin")]
    public class MauXeController : Controller
    {
        private readonly QLMTContext database;
        private readonly IWebHostEnvironment hostEnvironment;

        public MauXeController(QLMTContext db, IWebHostEnvironment hostEnvironment)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            var ModelList = new List<MauXe>();

            //ViewBag.CurrentFilter, provides the view with the current filter string.
            //he search string is changed when a value is entered in the text box and the submit button is pressed. In that case, the searchString parameter is not null.
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            using (var context = new QLMTContext())
            {
                var model = from s in context.MauXes
                            select s;
                //Search and match data, if search string is not null or empty
                if (!String.IsNullOrEmpty(searchString))
                {
                    model = model.Where(s => s.Idmau.Contains(searchString)
                                           || s.Idhang.Contains(searchString)
                                           || s.TenXe.Contains(searchString));
                }
                switch (sortOrder)
                {
                    case "name_desc":
                        ModelList = model.OrderByDescending(s => s.TenXe).ToList();
                        break;

                    default:
                        ModelList = model.OrderBy(s => s.TenXe).ToList();
                        break;
                }
            }
            //indicates the size of list
            int pageSize = 10;
            //set page to one is there is no value, ??  is called the null-coalescing operator.
            int pageNumber = (page ?? 1);
            //return the Model data with paged
            var modelv = new ViewModel
            {
                ListHang = database.Hangs.ToArray(),
                ListXe = database.Xes.ToArray(),
                ListMauXes = ModelList.ToPagedList(pageNumber, pageSize),
                ListKhuyenMai = database.KhuyenMais.ToArray()
            };

            return View(modelv);
        }

        public IActionResult Create()
        {
            var model = new ViewModel
            {
                ListLoaiXe = database.LoaiXes.ToArray(),
                ListHang = database.Hangs.ToArray(),
                ListKhuyenMai = database.KhuyenMais.ToArray()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MauXe mauXe)
        {
            var model = new ViewModel
            {
                ListLoaiXe = database.LoaiXes.ToArray(),
                ListHang = database.Hangs.ToArray(),
                ListKhuyenMai = database.KhuyenMais.ToArray()
            };

            if (ModelState.IsValid)
            {
                if (database.MauXes.Any(x => x.Idmau == mauXe.Idmau || x.TenXe == mauXe.TenXe))
                {
                    ViewBag.error = "Tên xe hoặc ID mẫu đã tồn tại";

                    return View(model);
                }
                #region Save Image from wwwroot/img
                string wwwRootPath = hostEnvironment.WebRootPath;
                string fileName1 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh1.FileName);
                string fileName2 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh2.FileName);
                string fileName3 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh3.FileName);

                string extension1 = Path.GetExtension(mauXe.UploadHinh1.FileName);
                string extension2 = Path.GetExtension(mauXe.UploadHinh2.FileName);
                string extension3 = Path.GetExtension(mauXe.UploadHinh3.FileName);

                mauXe.HinhAnh1 = "/img/Products/" + fileName1 + extension1;
                mauXe.HinhAnh2 = "/img/Products/" + fileName2 + extension2;
                mauXe.HinhAnh3 = "/img/Products/" + fileName3 + extension3;


                string path1 = Path.Combine(wwwRootPath + "/img/Products/", fileName1 + extension1);
                string path2 = Path.Combine(wwwRootPath + "/img/Products/", fileName2 + extension2);
                string path3 = Path.Combine(wwwRootPath + "/img/Products/", fileName3 + extension3);


                using (var fileStream = new FileStream(path1, FileMode.Create))
                {
                    await mauXe.UploadHinh1.CopyToAsync(fileStream);
                }
                using (var fileStream = new FileStream(path2, FileMode.Create))
                {
                    await mauXe.UploadHinh2.CopyToAsync(fileStream);
                }
                using (var fileStream = new FileStream(path3, FileMode.Create))
                {
                    await mauXe.UploadHinh3.CopyToAsync(fileStream);
                }
                #endregion

                database.Add(mauXe);
                await database.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var model = new ViewModel
            {
                ListLoaiXe = database.LoaiXes.ToArray(),
                ListHang = database.Hangs.ToArray(),
                ListKhuyenMai = database.KhuyenMais.ToArray(),
                mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault()
            };

            return View(model);
        }

        public IActionResult Delete(string id)
        {
            var model = new ViewModel
            {
                ListLoaiXe = database.LoaiXes.ToArray(),
                ListHang = database.Hangs.ToArray(),
                ListKhuyenMai = database.KhuyenMais.ToArray(),
                mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(string id, MauXe mauXe)
        {
            mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault();
            database.Remove(mauXe);
            database.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            var model = new ViewModel
            {
                ListLoaiXe = database.LoaiXes.ToArray(),
                ListHang = database.Hangs.ToArray(),
                ListMauXe = database.MauXes.ToArray(),
                ListKhuyenMai = database.KhuyenMais.ToArray(),
                mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, MauXe mauXe)
        {
            var model = new ViewModel
            {
                ListHang = database.Hangs.ToArray(),
                ListKhuyenMai = database.KhuyenMais.ToArray(),
                mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault()
            };

            if (mauXe.TenXe != null && mauXe.MoTa != null && mauXe.BaoHanh > 0 && mauXe.GiaBan >= 1000)
            {
                model.mauXe.TenXe = mauXe.TenXe;
                model.mauXe.Idhang = mauXe.Idhang;
                model.mauXe.Idkm = mauXe.Idkm;
                model.mauXe.BaoHanh = mauXe.BaoHanh;
                model.mauXe.GiaBan = mauXe.GiaBan;
                model.mauXe.MoTa = mauXe.MoTa;

                #region Save Image from wwwroot/img
                string wwwRootPath = hostEnvironment.WebRootPath;

                string fileName1, fileName2, fileName3;
                string extension1, extension2, extension3;
                if (mauXe.UploadHinh1 != null)
                {
                    fileName1 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh1.FileName);
                    extension1 = Path.GetExtension(mauXe.UploadHinh1.FileName);
                    model.mauXe.HinhAnh1 = "/img/Products/" + fileName1 + extension1;
                    string path1 = Path.Combine(wwwRootPath + "/img/Products/", fileName1 + extension1);
                    using (var fileStream = new FileStream(path1, FileMode.Create))
                    {
                        await mauXe.UploadHinh1.CopyToAsync(fileStream);
                    }
                }
                if (mauXe.UploadHinh2 != null)
                {
                    fileName2 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh2.FileName);
                    extension2 = Path.GetExtension(mauXe.UploadHinh2.FileName);
                    model.mauXe.HinhAnh2 = "/img/Products/" + fileName2 + extension2;
                    string path2 = Path.Combine(wwwRootPath + "/img/Products/", fileName2 + extension2);
                    using (var fileStream = new FileStream(path2, FileMode.Create))
                    {
                        await mauXe.UploadHinh2.CopyToAsync(fileStream);
                    }
                }

                if (mauXe.UploadHinh3 != null)
                {
                    fileName3 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh3.FileName);
                    extension3 = Path.GetExtension(mauXe.UploadHinh3.FileName);
                    model.mauXe.HinhAnh3 = "/img/Products/" + fileName3 + extension3;
                    string path3 = Path.Combine(wwwRootPath + "/img/Products/", fileName3 + extension3);
                    using (var fileStream = new FileStream(path3, FileMode.Create))
                    {
                        await mauXe.UploadHinh3.CopyToAsync(fileStream);
                    }
                }


                #endregion
                database.Update(model.mauXe);
                await database.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
    public class ViewModel
    {
        //Create Model to use Multiple Model in View
        public Hang hang { get; set; }
        public KhuyenMai khuyenMai { get; set; }
        public KhachHang khachHang { get; set; }
        public MauXe mauXe { get; set; }
        public Xe Xe { get; set; }
        public LoaiXe loaiXe { get; set; }

        public LoaiXe[] ListLoaiXe { get; set; }
        public Xe[] ListXe { get; set; }
        public MauXe[] ListMauXe { get; set; }
        public Hang[] ListHang { get; set; }
        public KhuyenMai[] ListKhuyenMai { get; set; }

        public IPagedList<MauXe> ListMauXes { get; set; }
        public IPagedList<Hang> ListHangs { get; set; }
        public IPagedList<Xe> ListXes { get; set; }
        public IPagedList<KhachHang> ListKhachHangs { get; set; }
    }

}
