using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    [Authorize(Roles = "admin")]
    public class NhanVienController : Controller
    {
        private readonly QLMTContext database;
        private readonly IWebHostEnvironment hostEnvironment;

        public NhanVienController(QLMTContext db, IWebHostEnvironment hostEnvironment)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            ViewBag.Role = TempData["Role"];

            var ModelList = new List<NhanVien>();

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
                var model = from s in context.NhanViens
                            select s;
                //Search and match data, if search string is not null or empty
                if (!String.IsNullOrEmpty(searchString))
                {
                    model = model.Where(s => s.TenNv.Contains(searchString));
                }
                switch (sortOrder)
                {
                    case "name_desc":
                        ModelList = model.OrderByDescending(s => s.Idnv).ToList();
                        break;

                    default:
                        ModelList = model.OrderBy(s => s.Idnv).ToList();
                        break;
                }

            }

            string email = User.FindFirst(ClaimTypes.Email).Value;

            //indicates the size of list
            int pageSize = 10;
            //set page to one is there is no value, ??  is called the null-coalescing operator.
            int pageNumber = (page ?? 1);
            //return the Model data with paged
            var modelv = new ViewModelNV
            {
                nhanVien = database.NhanViens.Where(x => x.Email == email).FirstOrDefault(),
                ListNhanViens = ModelList.ToPagedList(pageNumber, pageSize),
                ListType = database.TypeAccs.ToArray()
            };
            return View(modelv);
        }

        public IActionResult Detail(int id)
        {
            var model = new ViewModelNV
            {
                nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault(),
                ListNhanVien = database.NhanViens.ToArray(),
                ListType = database.TypeAccs.ToArray()
            };
            return View(model);
        }
        public IActionResult Create()
        {
            var model = new ViewModelNV
            {
                nhanVien = new NhanVien(),
                ListType = database.TypeAccs.ToArray()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NhanVien nhanVien)
        {


            var model = new ViewModelNV
            {
                ListNhanVien = database.NhanViens.ToArray(),
                ListType = database.TypeAccs.ToArray(),
                nhanVien = nhanVien
            };
            model.nhanVien.Idnv = model.ListNhanVien[^1].Idnv + 1;
            if (database.NhanViens.Any(x => x.Email == nhanVien.Email))
            {
                ViewBag.error = "Email nhân viên đã tồn tại";
                return View(model);
            }

            if (ModelState.IsValid)
            {
                string wwwRootPath = hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(nhanVien.UpLoadAvt.FileName);
                string extension = Path.GetExtension(nhanVien.UpLoadAvt.FileName);
                nhanVien.Avatar = "/img/Avatar/" + fileName + extension;
                string path = Path.Combine(wwwRootPath + "/img/Avatar/", fileName + extension);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await nhanVien.UpLoadAvt.CopyToAsync(fileStream);
                }
                database.Add(nhanVien);
                await database.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var model = new ViewModelNV();
            model.nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault();
            model.ListType = database.TypeAccs.ToArray();
            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, NhanVien nhanVien)
        {
            var model = new ViewModelNV();
            model.ListType = database.TypeAccs.ToArray();
            model.nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault();
            if (nhanVien.TenNv != null && nhanVien.Email != null && nhanVien.Pass != null && nhanVien.Idtype != null)
            {
                model.nhanVien.TenNv = nhanVien.TenNv;
                model.nhanVien.Idtype = nhanVien.Idtype;
                model.nhanVien.Email = nhanVien.Email;
                model.nhanVien.Pass = nhanVien.Pass;
                model.nhanVien.DienThoai = nhanVien.DienThoai;
                model.nhanVien.DiaChi = nhanVien.DiaChi;
                model.nhanVien.Cmnd = nhanVien.Cmnd;

                string wwwRootPath = hostEnvironment.WebRootPath;
                string fileName, extension;

                if (nhanVien.UpLoadAvt != null)
                {
                    fileName = Path.GetFileNameWithoutExtension(nhanVien.UpLoadAvt.FileName);
                    extension = Path.GetExtension(nhanVien.UpLoadAvt.FileName);
                    model.nhanVien.Avatar = "/img/Avatar/" + fileName + extension;
                    string path = Path.Combine(wwwRootPath + "/img/Avatar/", fileName + extension);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await nhanVien.UpLoadAvt.CopyToAsync(fileStream);
                    }
                }
                database.Update(model.nhanVien);
                await database.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }

    public class ViewModelNV
    {
        public NhanVien nhanVien { get; set; }
        public IPagedList<NhanVien> ListNhanViens { get; set; }
        public NhanVien[] ListNhanVien { get; set; }
        public TypeAcc[] ListType { get; set; }

        public ChangePassword changePass { get; set; }
    }

}
