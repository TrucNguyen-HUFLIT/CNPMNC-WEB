using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class XeController : Controller
    {

        QLMoToContext db = new QLMoToContext();

        //public  IActionResult Index()
        //{
        //    return View(db.MauXes.ToList());
        //}
        public async Task<IActionResult> Index(string sort, string search)
        {
            ViewData["Name"] = String.IsNullOrEmpty(sort) ? "name_desc" : "";
            ViewData["ID"] = String.IsNullOrEmpty(sort) ? "ID" : "";
            ViewData["search"] = search;
            var mauXeList = from s in db.MauXes
                            select s;
            if (!String.IsNullOrEmpty(search))
            {
                mauXeList = mauXeList.Where(s => s.Idmau.Contains(search)
                                       || s.TenXe.Contains(search));
            }
            switch (sort)
            {
                case "name_desc":
                    mauXeList = mauXeList.OrderByDescending(s => s.TenXe);
                    break;
                case "ID":
                    mauXeList = mauXeList.OrderByDescending(s => s.Idmau);
                    break;
                default:
                    mauXeList = mauXeList.OrderBy(s => s.TenXe);
                    break;
            }
            //var khachhang = _context.KhachHangs
            //    .Include(kh => kh.IdloaiKhNavigation).AsNoTracking();
            //var kh = await _context.KhachHangs.ToListAsync();
            // return View(await khachHangList.Include(kh => kh.IdloaiKhNavigation).AsNoTracking().ToListAsync());
           // return View(await mauXeList.Include(xe => xe.Idmau).AsNoTracking().ToListAsync());
            return View(await mauXeList.ToListAsync());
        }

        //private IActionResult View(object p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
