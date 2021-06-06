using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Index(int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging

            ViewBag.Role = TempData["Role"];

            var ModelList = database.HoaDons.Where(x => x.TrangThai == TrangThaiHoaDon.DaThanhToan).ToList();

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

        public IActionResult Details(string ID)
        {
            var model = new HoaDonViewModel
            {
                ChiTietHd = new ChiTietHd { Idhd = ID },
                ListChiTietHd = database.ChiTietHds.Where(x => x.Idhd == ID).ToArray(),
            };
            return View(model);
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
