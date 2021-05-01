using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly QLMoToContext database;


        public ProductsController(QLMoToContext db)
        {
            database = db;
        }
        public IActionResult Products()
        {
            return View(database.MauXes.ToList());
        }

        public IActionResult ProductsDetail(string id)
        {
            return View(database.MauXes.Where(model => model.Idmau == id).FirstOrDefault());
        }
    }
}
