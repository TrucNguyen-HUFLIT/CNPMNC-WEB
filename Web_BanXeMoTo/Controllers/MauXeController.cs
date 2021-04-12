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
        private MauXeViewModel model;


        public MauXeController(QLMoToContext db, IWebHostEnvironment hostEnvironment)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            model = Models();
            return View(model);
        }

        public IActionResult Create()
        {
            var model = new MauXeViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MauXe mauXe)
        {
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

                mauXe.HinhAnh1 = fileName1 += DateTime.Now.ToString("yymmssfff") + extension1;
                mauXe.HinhAnh2 = fileName2 += DateTime.Now.ToString("yymmssfff") + extension2;
                mauXe.HinhAnh3 = fileName3 += DateTime.Now.ToString("yymmssfff") + extension3;

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
                return RedirectToAction(nameof(Index));
            }
            return View(mauXe);
        }


        public MauXeViewModel Models()
        {
            var model = new MauXeViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhuyenMai = database.KhuyenMais.ToArray();
            return model;
        }
    }
    public class MauXeViewModel
    {
        public MauXe mauXe { get; set; }
        public MauXe[] ListMauXe { get; set; }
        public Hang[] ListHang { get; set; }

        public KhuyenMai[] ListKhuyenMai { get; set; }
    }

}
