﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;
using X.PagedList;

namespace Web_BanXeMoTo.Controllers
{
    [Authorize(Roles = "admin, staff")]
    public class HoaDonController : Controller
    {
        private readonly QLMTContext database;

        public HoaDonController(QLMTContext db)
        {
            database = db;
        }
        public IActionResult Index( int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging

            ViewBag.Role = TempData["Role"];

            var ModelList = database.HoaDons.ToList();

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
                ListKhachHang = database.KhachHangs.ToArray()
            };
            return View(modelv);
        }

        public IActionResult Create()
        {
            var model = new HoaDonViewModel
            {
                HoaDon = new HoaDon { Idhd = GetIDHD() },
                ListKhachHang = database.KhachHangs.ToArray()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                database.HoaDons.Add(hoaDon);
                await database.SaveChangesAsync();
                return RedirectToAction("CTHD", new { ID = hoaDon.Idhd });
            }
            return View(hoaDon);
        }
        public IActionResult Details(string ID)
        {
            var model = new HoaDonViewModel
            {
                ChiTietHd = new ChiTietHd { Idhd = ID },
                ListChiTietHd = database.ChiTietHds.Where(x=>x.Idhd == ID).ToArray(),
            };
            return View(model);
        }
        public async Task<IActionResult> CTHD(string ID)
        {
            var model = new HoaDonViewModel
            {
                ChiTietHd = new ChiTietHd { Idhd = ID },
                ListMauXe = database.MauXes.ToArray(),
                ListXe = database.Xes.Where(x=>x.TrangThai==TrangThaiXe.ChuaBan).ToArray(),
            };
            foreach (var mauxe in model.ListMauXe)
            {
                mauxe.IdhangNavigation = await database.Hangs.Where(x => x.Idhang == mauxe.Idhang).FirstOrDefaultAsync();
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CTHD(ChiTietHd chiTietHd)
        {
            try
            {
                var Xe = await database.Xes.Where(x => x.Idxe == chiTietHd.Idxe).FirstOrDefaultAsync();
                var MauXe = await database.MauXes.Where(x => x.Idmau == Xe.Idmau).Select(x => new { x.GiaBan, x.Idkm }).FirstOrDefaultAsync();
                var KhuyenMai = await database.KhuyenMais.Where(x => x.Idkm == MauXe.Idkm).Select(x => x.GiaTri).FirstOrDefaultAsync();

                Xe.TrangThai = TrangThaiXe.DaBan;
                database.Xes.Update(Xe);

                chiTietHd.KhuyenMai = KhuyenMai;
                chiTietHd.GiaBan = MauXe.GiaBan;
                database.ChiTietHds.Add(chiTietHd);
                await database.SaveChangesAsync();
                return RedirectToAction("Details", new { ID = chiTietHd.Idhd });
            }
            catch
            {
                ViewBag.Error = "Xe đã có trong hóa đơn!";
                var model = new HoaDonViewModel
                {
                    ChiTietHd = chiTietHd,
                    ListMauXe = database.MauXes.ToArray(),
                    ListXe = database.Xes.ToArray(),
                };
                foreach (var mauxe in model.ListMauXe)
                {
                    mauxe.IdhangNavigation = await database.Hangs.Where(x => x.Idhang == mauxe.Idhang).FirstOrDefaultAsync();
                }
                return View(model);
            }
        }
        public async Task<IActionResult> DeleteCTHD(string idXe, string idHD)
        {
            var Xe = await database.Xes.Where(x => x.Idxe == idXe).FirstOrDefaultAsync();
            var ChiTietHD = await database.ChiTietHds.Where(x => x.Idhd == idHD && x.Idxe == idXe).FirstOrDefaultAsync();

            Xe.TrangThai = TrangThaiXe.ChuaBan;
            database.Xes.Update(Xe);

            database.Remove(ChiTietHD);
            database.SaveChanges();
            return RedirectToAction("Details", new { ID = idHD });
        }

        public string GetIDHD()
        {
            var list = database.HoaDons.ToArray();

            int.TryParse(list[list.Length - 1].Idhd.Substring(2), out int lastID);

            string ID = "HD" + ++lastID;

            return ID;
        }
    }
    public class HoaDonViewModel
    {
        public KhuyenMai[] ListKhuyenMai { get; set; }
        public Xe[] ListXe { get; set; }
        public MauXe[] ListMauXe { get; set; }
        public KhachHang[] ListKhachHang { get; set; }
        public ChiTietHd ChiTietHd { get; set; }
        public ChiTietHd[] ListChiTietHd { get; set; }
        public HoaDon HoaDon { get; set; }
        public IPagedList<HoaDon> ListHoaDon { get; set; }
    }
}
