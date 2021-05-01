using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class HangController : Controller
    {
        private readonly QLMoToContext database;

        public HangController(QLMoToContext db)
        {
            database = db;
        }
        public IActionResult Index()
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            return View(model);
        }

        public IActionResult Create()
        {
            var model = new Hang();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Hang hang)
        {
            if (ModelState.IsValid)
            {
            database.Add(hang);
            database.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(hang);
        }
        [HttpPost]
        public IActionResult Delete(string id)
        {
            var model = new ViewModel();
            model.hang = database.Hangs.Where(x => x.Idhang == id).FirstOrDefault();
            database.Remove(model.hang);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            var model = new Hang();
            model = database.Hangs.Where(x => x.Idhang == id).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Hang hang)
        {
            //foreach (var item in model.ListMauXe)
            //{
            //    if(item.Idhang == hang.Idhang)
            //    {
            //        //
            //    }
            //}
            var model = hang;
            if (ModelState.IsValid)
            {
                database.Update(model);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
