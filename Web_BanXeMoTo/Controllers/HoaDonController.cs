using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

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
        public IActionResult Index()
        {
            var model = new HoaDonViewModel
            {
                ListHoaDon = database.HoaDons.ToArray(),
                ListChiTietHd = database.ChiTietHds.ToArray(),
                ListKhachHang = database.KhachHangs.ToArray()
            };
            return View(model);
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
                ListKhachHang = database.KhachHangs.ToArray(),
                ListKhuyenMai = database.KhuyenMais.ToArray(),
                ListMauXe = database.MauXes.ToArray(),
                ListXe = database.Xes.ToArray(),
            };
            foreach (var mauxe in model.ListMauXe)
            {
                mauxe.IdhangNavigation = await database.Hangs.Where(x => x.Idhang == mauxe.Idhang).FirstOrDefaultAsync();
            }
            foreach (var xe in model.ListXe)
            {
                xe.IdmauNavigation = await database.MauXes.Where(x => x.Idmau == xe.Idmau).FirstOrDefaultAsync();
                xe.IdmauNavigation.IdkmNavigation = await database.KhuyenMais.Where(x => x.Idkm == xe.IdmauNavigation.Idkm).FirstOrDefaultAsync();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult CTHD(ChiTietDg chiTietDg)
        {
            return View(chiTietDg);
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
        public HoaDon[] ListHoaDon { get; set; }
    }
}
