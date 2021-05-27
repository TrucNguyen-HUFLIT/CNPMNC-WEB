using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly QLMTContext database;
        private readonly IWebHostEnvironment hostEnvironment;

        public NhanVienController(QLMTContext db, IWebHostEnvironment hostEnvironment)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            
            string email = User.FindFirst(ClaimTypes.Email).Value;
            var model = new ViewModelNV
            {
                nhanVien = database.NhanViens.Where(x => x.Email == email).FirstOrDefault(),
                ListNhanVien = database.NhanViens.ToArray(),
                ListType = database.TypeAccs.ToArray()
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = new ViewModelNV
            {
                nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault(),
                ListNhanVien = database.NhanViens.ToArray(),
                ListType = database.TypeAccs.ToArray()
            };
            return View(model);
        }
        public IActionResult Create()
        {
            var model = new ViewModelNV
            {
                nhanVien = new NhanVien(),
                ListType = database.TypeAccs.ToArray()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NhanVien nhanVien)
        {

            var model = new ViewModelNV();
            model.ListType = database.TypeAccs.ToArray();
            
            if (ModelState.IsValid)
            {
                string wwwRootPath = hostEnvironment.WebRootPath;
                string fileName1 = Path.GetFileNameWithoutExtension(nhanVien.UpLoadAvt.FileName);
                string extension1 = Path.GetExtension(nhanVien.UpLoadAvt.FileName);
                nhanVien.Avatar = fileName1 += extension1;
                string path1 = Path.Combine(wwwRootPath + "/img/", fileName1);
                using (var fileStream = new FileStream(path1, FileMode.Create))
                {
                    await nhanVien.UpLoadAvt.CopyToAsync(fileStream);
                }
                
            }
            database.Add(nhanVien);
            await this.database.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var model = new ViewModelNV();
            model.nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault();
            model.ListType = database.TypeAccs.ToArray();
            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, NhanVien nhanVien)
        {
            var model = new ViewModelNV();
            model.ListType = database.TypeAccs.ToArray();
            model.nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault();
            if (nhanVien.TenNv != null && nhanVien.Email != null && nhanVien.Pass != null && nhanVien.Idtype != null)
            {
                model.nhanVien.TenNv = nhanVien.TenNv;
                model.nhanVien.Idtype = nhanVien.Idtype;
                model.nhanVien.Email = nhanVien.Email;
                model.nhanVien.Pass = nhanVien.Pass;
                model.nhanVien.DienThoai = nhanVien.DienThoai;
                model.nhanVien.DiaChi = nhanVien.DiaChi;
                model.nhanVien.Cmnd = nhanVien.Cmnd;

                string wwwRootPath = hostEnvironment.WebRootPath;
                string fileName1;
                string extension1;
                if (nhanVien.UpLoadAvt != null)
                {
                    fileName1 = Path.GetFileNameWithoutExtension(nhanVien.UpLoadAvt.FileName);
                    extension1 = Path.GetExtension(nhanVien.UpLoadAvt.FileName);
                    model.nhanVien.Avatar = fileName1 += extension1;
                    string path1 = Path.Combine(wwwRootPath + "/img/", fileName1);
                    using (var fileStream = new FileStream(path1, FileMode.Create))
                    {
                        await nhanVien.UpLoadAvt.CopyToAsync(fileStream);
                    }
                }
                database.Update(model.nhanVien);
                await database.SaveChangesAsync();
                return RedirectToAction("Index", "NhanVien");
            }
            return View(model);
        }

    }

    public class ViewModelNV
    {
        public NhanVien nhanVien { get; set; }
    
        public NhanVien[] ListNhanVien { get; set; }
        public TypeAcc[] ListType { get; set; }
    }

}
