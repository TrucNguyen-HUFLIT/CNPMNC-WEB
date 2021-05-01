using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class MauXeController : Controller
    {
        private readonly QLMoToContext database;
        private readonly IWebHostEnvironment hostEnvironment;
        
        public MauXeController(QLMoToContext db, IWebHostEnvironment hostEnvironment)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            return View(model);
        }

        public IActionResult Create()
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Create(MauXe mauXe)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            if (ModelState.IsValid)
            {
                #region Save Image from wwwroot/img
                string wwwRootPath = hostEnvironment.WebRootPath;
                string fileName1 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh1.FileName);
                string fileName2 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh2.FileName);
                string fileName3 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh3.FileName);

                string extension1 = Path.GetExtension(mauXe.UploadHinh1.FileName);
                string extension2 = Path.GetExtension(mauXe.UploadHinh2.FileName);
                string extension3 = Path.GetExtension(mauXe.UploadHinh3.FileName);

                mauXe.HinhAnh1 = fileName1 += extension1;
                mauXe.HinhAnh2 = fileName2 += extension2;
                mauXe.HinhAnh3 = fileName3 += extension3;

                string path1 = Path.Combine(wwwRootPath + "/img/", fileName1);
                string path2 = Path.Combine(wwwRootPath + "/img/", fileName2);
                string path3 = Path.Combine(wwwRootPath + "/img/", fileName3);


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
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            model.mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault();
            return View(model);
        }

        public IActionResult Delete(string id)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            model.mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(string id,MauXe mauXe)
        {
            mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault();
            database.Remove(mauXe);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            model.mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id,MauXe mauXe)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            model.mauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault();
            if(mauXe.TenXe != null && mauXe.MoTa != null && mauXe.BaoHanh > 0 && mauXe.GiaBan >= 1000)
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
                    model.mauXe.HinhAnh1 = fileName1 += extension1;
                    string path1 = Path.Combine(wwwRootPath + "/img/", fileName1);
                    using (var fileStream = new FileStream(path1, FileMode.Create))
                    {
                        await mauXe.UploadHinh1.CopyToAsync(fileStream);
                    }
                }
                if (mauXe.UploadHinh2 != null)
                {
                    fileName2 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh2.FileName);
                    extension2 = Path.GetExtension(mauXe.UploadHinh2.FileName);
                    model.mauXe.HinhAnh2 = fileName2 += extension2;
                    string path2 = Path.Combine(wwwRootPath + "/img/", fileName2);
                    using (var fileStream = new FileStream(path2, FileMode.Create))
                    {
                        await mauXe.UploadHinh2.CopyToAsync(fileStream);
                    }
                }

                if (mauXe.UploadHinh3 != null)
                {
                    fileName3 = Path.GetFileNameWithoutExtension(mauXe.UploadHinh3.FileName);
                    extension3 = Path.GetExtension(mauXe.UploadHinh3.FileName);
                    model.mauXe.HinhAnh3 = fileName3 += extension3;
                    string path3 = Path.Combine(wwwRootPath + "/img/", fileName3);
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
        public MauXe mauXe { get; set; }
        public MauXe[] ListMauXe { get; set; }
        public Hang[] ListHang { get; set; }
        public KhuyenMai[] ListKhuyenMai { get; set; }
    }

}
