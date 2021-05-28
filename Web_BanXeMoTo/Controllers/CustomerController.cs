using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class CustomerController : Controller
    {
        private readonly QLMTContext database;

        public CustomerController(QLMTContext db)
        {
            database = db;
        }
        public IActionResult Home()
        {
            if (User.FindFirst(ClaimTypes.Email) == null)
            {
                var model = new ViewModelKH();
                model.ListHang = database.Hangs.ToArray();
                model.ListMauXe = database.MauXes.ToArray();
                return View(model);
            }
            else
            {
                var email = User.FindFirst(ClaimTypes.Email).Value;
                var model = new ViewModelKH();
                if (email != null)
                {
                    model.ListHang = database.Hangs.ToArray();
                    model.ListMauXe = database.MauXes.ToArray();
                    model.khachHang = database.KhachHangs.Where(x => x.Email == email).FirstOrDefault();
                    model.ListType = database.TypeAccs.ToArray();

                    StaticAcc.Avatar = model.khachHang.Avatar;
                    StaticAcc.Name = model.khachHang.TenKh;
                    StaticAcc.TypeAcc = database.TypeAccs.Where(x => x.Idtype == model.khachHang.Idtype).Select(x => x.Name).FirstOrDefault();
                }
                return View(model);
            }
        }
    }
}
