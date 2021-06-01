using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;
using X.PagedList;

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
                var model = new CustomerViewModel
                {
                    ListHang = database.Hangs.ToArray(),
                    ListMauXe = database.MauXes.ToArray()
                };
                return View(model);
            }
            else
            {
                var email = User.FindFirst(ClaimTypes.Email).Value;
                var model = new CustomerViewModel();
                if (email != null)
                {
                    model.ListHang = database.Hangs.ToArray();
                    model.ListMauXe = database.MauXes.ToArray();
                    model.khachHang = database.KhachHangs.Where(x => x.Email == email).FirstOrDefault();

                    StaticAcc.Avatar = model.khachHang.Avatar;
                    StaticAcc.Name = model.khachHang.TenKh;
                    StaticAcc.TypeAcc = database.TypeAccs.Where(x => x.Idtype == model.khachHang.Idtype).Select(x => x.Name).FirstOrDefault();
                }
                return View(model);
            }
        }

        public IActionResult Products(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";


            var ModelList = new List<MauXe>();

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
                var model = from s in context.MauXes
                            select s;
                //Search and match data, if search string is not null or empty
                if (!String.IsNullOrEmpty(searchString))
                {
                    model = model.Where(s => s.TenXe.Contains(searchString));
                }
                switch (sortOrder)
                {
                    case "name_desc":
                        ModelList = model.OrderByDescending(s => s.GiaBan).ToList();
                        break;

                    default:
                        ModelList = model.OrderBy(s => s.GiaBan).ToList();
                        break;
                }

            }
            //indicates the size of list
            int pageSize = 9;
            //set page to one is there is no value, ??  is called the null-coalescing operator.
            int pageNumber = (page ?? 1);
            //return the Model data with paged
            var modelv = new CustomerViewModel
            {
                ListHang = database.Hangs.ToArray(),
                ListXe = database.Xes.ToArray(),
                ListMauXes = ModelList.ToPagedList(pageNumber, pageSize),
            };
            return View(modelv);
        }

        public IActionResult ProductDetails(string id)
        {
            var model = new CustomerViewModel
            {
                MauXe = database.MauXes.Where(x => x.Idmau == id).FirstOrDefault(),
                ListMauXe = database.MauXes.ToArray(),
                ListXe = database.Xes.Where(x => x.Idmau == id).ToArray()
            };

            return View(model);
        }

        public IActionResult ProductsCart()
        {
            return View();
        }

    }
    public class CustomerViewModel
    {
        public IPagedList<MauXe> ListMauXes { get; set; }
        public Xe[] ListXe { get; set; }
        public MauXe MauXe { get; set; }
        public MauXe[] ListMauXe { get; set; }
        public Hang[] ListHang { get; set; }
        public KhachHang khachHang { get; set; }
    }
}
