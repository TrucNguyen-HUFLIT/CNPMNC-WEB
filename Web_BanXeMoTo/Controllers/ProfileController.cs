using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;
using X.PagedList;

namespace Web_BanXeMoTo.Controllers
{
    public class ProfileController : Controller
    {
        private readonly QLMTContext database;
        private readonly IWebHostEnvironment hostEnvironment;

        public ProfileController(QLMTContext db, IWebHostEnvironment hostEnvironment)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }

        [Authorize(Roles = "customer")]
        [HttpGet]
        public async Task<IActionResult> ProfileKhachHang()
        {
            if (User.FindFirst(ClaimTypes.Email) == null)
            {
                return RedirectToAction("Login","Login");
            }

            string email = User.FindFirst(ClaimTypes.Email).Value;
            var model = new KhachHang();
            model = database.KhachHangs.Where(x => x.Email == email).FirstOrDefault();

            StaticAcc.Avatar = model.Avatar;
            StaticAcc.Name = model.TenKh;
            StaticAcc.TypeAcc = await database.TypeAccs
                                    .Where(x => x.Idtype == model.Idtype)
                                    .Select(x => x.Name)
                                    .FirstOrDefaultAsync();
            return View(model);
        }

        [Authorize(Roles = "customer")]
        [HttpPost]
        public async Task<IActionResult> ProfileKhachHang(KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                var model = await database.KhachHangs.Where(x => x.Idkh == khachHang.Idkh).FirstOrDefaultAsync();
                if(model.Pass == khachHang.Pass)
                {
                    model.TenKh = khachHang.TenKh;
                    model.DienThoai = khachHang.DienThoai;
                    model.DiaChi = khachHang.DiaChi;

                    #region Save Image from wwwroot/img
                    string wwwRootPath = hostEnvironment.WebRootPath;
                    string fileName, extension;

                    if (khachHang.UploadHinh != null)
                    {
                        fileName = Path.GetFileNameWithoutExtension(khachHang.UploadHinh.FileName);
                        extension = Path.GetExtension(khachHang.UploadHinh.FileName);
                        model.Avatar = "/img/" + fileName + extension;
                        string path1 = Path.Combine(wwwRootPath + "/img/", fileName);
                        using (var fileStream = new FileStream(path1, FileMode.Create))
                        {
                            await khachHang.UploadHinh.CopyToAsync(fileStream);
                        }
                    }
                    #endregion

                    database.Update(model);
                    await database.SaveChangesAsync();

                    StaticAcc.Avatar = model.Avatar;
                    StaticAcc.Name = model.TenKh;
                    StaticAcc.TypeAcc = await database.TypeAccs
                                            .Where(x => x.Idtype == model.Idtype)
                                            .Select(x => x.Name)
                                            .FirstOrDefaultAsync();
                    return View(model);
                }
                khachHang.Avatar = StaticAcc.Avatar;
                ViewBag.ErrorPass = "Mật khẩu sai!";
                return View(khachHang);
            }
            khachHang.Avatar = StaticAcc.Avatar;
            return View(khachHang);
        }

        [Authorize(Roles = "customer")]
        [HttpGet]
        public async Task<IActionResult> History(int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging


            if (User.FindFirst(ClaimTypes.Email) == null)
            {
                return RedirectToAction("Login", "Login");
            }
            string email = User.FindFirst(ClaimTypes.Email).Value;
           var Idkh= await database.KhachHangs.Where(x => x.Email == email).Select(x=>x.Idkh).FirstOrDefaultAsync();

            ViewBag.Role = TempData["Role"];

            var ModelList = database.HoaDons.Where(x=>x.Idkh==Idkh).ToList();

            //ViewBag.CurrentFilter, provides the view with the current filter string.
            //he search string is changed when a value is entered in the text box and the submit button is pressed. In that case, the searchString parameter is not null.
            //indicates the size of list
            int pageSize = 5;
            //set page to one is there is no value, ??  is called the null-coalescing operator.
            int pageNumber = (page ?? 1);
            //return the Model data with paged


            var modelv = new HoaDonViewModel
            {
                ListHoaDon = ModelList.ToPagedList(pageNumber, pageSize),
                ListChiTietHd = database.ChiTietHds.ToArray(),
            };
            return View(modelv);
        }
        [Authorize(Roles = "customer")]
        public IActionResult Details(string ID)
        {
            var model = new HoaDonViewModel
            {
                ChiTietHd = new ChiTietHd { Idhd = ID },
                ListChiTietHd = database.ChiTietHds.Where(x => x.Idhd == ID).ToArray(),
            };
            return View(model);
        }

        [Authorize(Roles = "admin, staff")]
        [HttpGet]
        public async Task<IActionResult> ProfileNhanVien()
        {
            if (User.FindFirst(ClaimTypes.Email) == null)
            {
                return RedirectToAction("Login", "Login");
            }
            string email = User.FindFirst(ClaimTypes.Email).Value;
            var model = new NhanVien();
            model = database.NhanViens.Where(x => x.Email == email).FirstOrDefault();

            StaticAcc.Avatar = model.Avatar;
            StaticAcc.Name = model.TenNv;
            StaticAcc.TypeAcc = await database.TypeAccs
                                    .Where(x => x.Idtype == model.Idtype)
                                    .Select(x => x.Name)
                                    .FirstOrDefaultAsync();

            return View(model);
        }

        [Authorize(Roles = "admin, staff")]
        [HttpPost]
        public async Task<IActionResult> ProfileNhanVien(NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                var model = await database.NhanViens.Where(x => x.Idnv == nhanVien.Idnv).FirstOrDefaultAsync();
                if (model.Pass == nhanVien.Pass)
                {
                    model.TenNv = nhanVien.TenNv;
                    model.DienThoai = nhanVien.DienThoai;
                    model.DiaChi = nhanVien.DiaChi;
                    #region Save Image from wwwroot/img
                    string wwwRootPath = hostEnvironment.WebRootPath;

                    string fileName, extension;
                    if (nhanVien.UpLoadAvt != null)
                    {
                        fileName = Path.GetFileNameWithoutExtension(nhanVien.UpLoadAvt.FileName);
                        extension = Path.GetExtension(nhanVien.UpLoadAvt.FileName);
                        model.Avatar = "/img/" + fileName + extension;
                        string path1 = Path.Combine(wwwRootPath + "/img/", fileName);
                        using (var fileStream = new FileStream(path1, FileMode.Create))
                        {
                            await nhanVien.UpLoadAvt.CopyToAsync(fileStream);
                        }
                    }

                    #endregion

                    database.Update(model);
                    await database.SaveChangesAsync();

                    StaticAcc.Avatar = model.Avatar;
                    StaticAcc.Name = model.TenNv;
                    StaticAcc.TypeAcc = await database.TypeAccs
                                            .Where(x => x.Idtype == model.Idtype)
                                            .Select(x => x.Name)
                                            .FirstOrDefaultAsync();

                    return View(model);
                }
                nhanVien.Avatar = StaticAcc.Avatar;
                ViewBag.ErrorPass = "Mật khẩu sai!";
                return View(nhanVien);
            }
            nhanVien.Avatar = StaticAcc.Avatar;
            return View(nhanVien);
        }


    }
}
