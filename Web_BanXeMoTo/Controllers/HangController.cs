using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;
using X.PagedList;

namespace Web_BanXeMoTo.Controllers
{
    [Authorize(Roles = "admin")]

    public class HangController : Controller
    {
        private readonly QLMTContext database;

        public HangController(QLMTContext db)
        {
            database = db;
        }

        public IActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            ViewBag.Role = TempData["Role"];

            var ModelList = new List<Hang>();

            //ViewBag.CurrentFilter, provides the view with the current filter string.
            //he search string is changed when a value is entered in the text box and the submit button is pressed. In that case, the searchString parameter is not null.
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            using (var context = new QLMTContext())
            {
                var model = from s in context.Hangs
                            select s;
                //Search and match data, if search string is not null or empty
                if (!String.IsNullOrEmpty(searchString))
                {
                    model = model.Where(s => s.Idhang.Contains(searchString)
                                           || s.Idhang.Contains(searchString)
                                           || s.TenHang.Contains(searchString));
                }
                switch (sortOrder)
                {
                    case "name_desc":
                        ModelList = model.OrderByDescending(s => s.Idhang).ToList();
                        break;

                    default:
                        ModelList = model.OrderBy(s => s.Idhang).ToList();
                        break;
                }
            }
            //indicates the size of list
            int pageSize = 10;
            //set page to one is there is no value, ??  is called the null-coalescing operator.
            int pageNumber = (page ?? 1);
            //return the Model data with paged
            var modelv = new ViewModel
            {
                ListHangs = ModelList.ToPagedList(pageNumber, pageSize),
                ListMauXe = database.MauXes.ToArray(),
            };

            return View(modelv);
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
                if (database.Hangs.Any(x => x.Idhang == hang.Idhang || x.TenHang == hang.TenHang))
                {
                    ViewBag.error = "Tên hãng hoặc ID hãng đã tồn tại";

                    return View(hang);
                }
                database.Add(hang);
                database.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(hang);
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            var model = new ViewModel
            {
                hang = database.Hangs.Where(x => x.Idhang == id).FirstOrDefault()
            };
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
