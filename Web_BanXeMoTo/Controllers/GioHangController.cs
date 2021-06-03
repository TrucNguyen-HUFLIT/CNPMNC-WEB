using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
                if(data==null)
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
        public IActionResult AddToCart(string id, string type = "Normal")
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.Idmau == id);
            int soLuong = 0;
            if (item==null)
            {
                var mauxe = database.MauXes.SingleOrDefault(p => p.Idmau == id);
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
                item.SoLuong++;
                soLuong = item.SoLuong;
            }
            HttpContext.Session.Set("GioHang", myCart);
            if(type=="ajax")
            {
                return Json(new
                {
                    id = id,
                    soLuong = soLuong,
                    total = Carts.Sum(c => c.SoLuong),
                }) ;
            }
            return RedirectToAction("Index");
        }
        
       
        [HttpGet]
        public IActionResult MinusFromCart(string id,  string type = "Normal")
        {
            var myCart = Carts;
            var mauxe = database.MauXes.SingleOrDefault(p => p.Idmau == id);
            int soLuong = 0;
            foreach (var item in myCart)
            {
                
                 if(item.Idmau == mauxe.Idmau && item.SoLuong>0)
                {
                    item.SoLuong--;
                    soLuong = item.SoLuong;
                    break;
                }    
            }
            HttpContext.Session.Set("GioHang", myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    id = id,
                    soLuong = soLuong,
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

                if (item.Idmau == mauxe.Idmau )
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
    }
}
