using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_BanXeMoTo.Helpers;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class GioHangController : Controller
    {
        private readonly QLMTContext database;
        public GioHangController(QLMTContext db)
        {
            database = db;
        }
        public List<CartModel> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartModel>>("GioHang");
                if (data == null)
                {
                    data = new List<CartModel>();
                }
                return data;
            }


        }
        public IActionResult Index()
        {
            return View(Carts);
        }

        [HttpGet]
        public async Task<IActionResult> AddToCartAsync(string id, string type = "Normal")
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.Idmau == id);
            var amount = database.Xes.Where(x => x.Idmau == id && x.TrangThai == TrangThaiXe.ChuaBan).ToArray().Length;
            int soLuong = item == null ? 0 : item.SoLuong;
            double tongTien = 0, thanhTien = item == null ? 0 : item.ThanhTien;

            if (item == null)
            {
                var mauxe = await database.MauXes.SingleOrDefaultAsync(p => p.Idmau == id);
                item = new CartModel
                {
                    Idmau = id,
                    TenXe = mauxe.TenXe,
                    GiaBan = mauxe.GiaBan,
                    SoLuong = soLuong = 1,
                    Hinh = mauxe.HinhAnh1,
                };

                myCart.Add(item);
            }
            else
            {
                if (item.SoLuong < amount)
                {
                    soLuong = ++item.SoLuong;
                    thanhTien = item.ThanhTien;
                }
                else
                    return BadRequest();
            }

            foreach (var mauxe in myCart)
            {
                tongTien += mauxe.ThanhTien;
            }
            HttpContext.Session.Set("GioHang", myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    id,
                    tongTien,
                    thanhTien,
                    soLuong,
                    total = Carts.Sum(c => c.SoLuong),
                });
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult MinusFromCart(string id, string type = "Normal")
        {
            var myCart = Carts;
            var mauxe = database.MauXes.SingleOrDefault(p => p.Idmau == id);
            int soLuong = 0;
            double tongTien = 0, thanhTien = 0;

            foreach (var item in myCart)
            {

                if (item.Idmau == mauxe.Idmau && item.SoLuong > 0)
                {
                    item.SoLuong--;
                    thanhTien = item.ThanhTien;
                    soLuong = item.SoLuong;
                    break;
                }
            }

            foreach (var item in myCart)
            {
                tongTien += item.ThanhTien;
            }

            HttpContext.Session.Set("GioHang", myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    id,
                    tongTien,
                    thanhTien,
                    soLuong,
                    total = Carts.Sum(c => c.SoLuong),
                });
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult RemoveFromCart(string id, string type = "Normal")
        {
            var myCart = Carts;
            var mauxe = database.MauXes.SingleOrDefault(p => p.Idmau == id);
            foreach (var item in myCart)
            {

                if (item.Idmau == mauxe.Idmau)
                {
                    myCart.Remove(item);
                    break;
                }
            }
            HttpContext.Session.Set("GioHang", myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    SoLuong = Carts.Sum(c => c.SoLuong),
                });
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> ThanhToan()
        {
            var myCart = Carts;
            if (User.FindFirst(ClaimTypes.Email) == null)
            {
                return RedirectToAction("Login", "Login");
            }
            string email = User.FindFirst(ClaimTypes.Email).Value;
            var khachHang = await database.KhachHangs.Where(x => x.Email == email).FirstOrDefaultAsync();

            var hoaDon = new HoaDon
            {
                Idhd = GetIDHD(),
                Idkh = khachHang.Idkh,
                NgayDat = DateTime.Now,
                TrangThai = TrangThaiHoaDon.ChuaXacNhan,

            };
            database.Add(hoaDon);
            await database.SaveChangesAsync();

            foreach (var item in myCart)
            {
                var Idkm = await database.MauXes.Where(x => x.Idmau == item.Idmau).Select(x => x.Idkm).FirstOrDefaultAsync();
                var listXe = await database.Xes.Where(x => x.Idmau == item.Idmau && x.TrangThai == TrangThaiXe.ChuaBan).ToArrayAsync();

                var khuyenMai = await database.KhuyenMais.Where(x => x.Idkm == Idkm).Select(x => x.GiaTri).FirstOrDefaultAsync();

                for (int count = 0; count < item.SoLuong; count++)
                {
                    database.Add(new ChiTietHd
                    {
                        Idhd = hoaDon.Idhd,
                        Idxe = listXe[count].Idxe,
                        KhuyenMai = khuyenMai,
                        GiaBan = (decimal)item.GiaBan,

                    });
                    listXe[count].TrangThai = TrangThaiXe.DaBan;

                    database.Xes.Update(listXe[count]);
                    await database.SaveChangesAsync();

                }
            }
            return RedirectToAction("Home", "Customer");
        }


        public string GetIDHD()
        {
            var list = database.HoaDons.ToArray();

            int.TryParse(list[list.Length - 1].Idhd.Substring(2), out int lastID);

            string ID = "HD" + ++lastID;

            return ID;
        }
    }
}
