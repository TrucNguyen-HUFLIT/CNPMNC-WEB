using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using System;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;
using X.PagedList;

namespace Web_BanXeMoTo.Controllers
{
    public class BanHangController : Controller
    {
        private readonly QLMTContext database;

        public BanHangController(QLMTContext db)
        {
            database = db;
        }

        public async Task<IActionResult> ChuaXacNhan(int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging
            ViewBag.Role = TempData["Role"];

            var ModelList = database.HoaDons.Where(x=>x.TrangThai==TrangThaiHoaDon.ChuaXacNhan).OrderByDescending(p => p.NgayDat).ToList();

            int pageSize = 5;
            //set page to one is there is no value, ??  is called the null-coalescing operator.
            int pageNumber = (page ?? 1);
            //return the Model data with paged
            var modelv = new HoaDonViewModel
            {
                ListHoaDon = ModelList.ToPagedList(pageNumber, pageSize),
                ListChiTietHd = await database.ChiTietHds.ToArrayAsync(),
                ListKhachHang = await database.KhachHangs.ToArrayAsync()
            };
            return View(modelv);
        }

        public async Task<IActionResult> XacNhan(string ID)
        {
            var hoaDon = await database.HoaDons.Where(x => x.Idhd == ID).FirstOrDefaultAsync();
            var khachHang = await database.KhachHangs.Where(x => x.Idkh == hoaDon.Idkh).Select(x => new { x.TenKh, x.Email }).FirstOrDefaultAsync();

            hoaDon.TrangThai = TrangThaiHoaDon.DaXacNhan;
            database.HoaDons.Update(hoaDon);
            await database.SaveChangesAsync();

            #region Gửi mail xác nhận
            MimeMessage message = new();
            MailboxAddress from = new("H2T Moto", "h2t.moto.huflit@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new(khachHang.TenKh, khachHang.Email);
            message.To.Add(to);

            message.Subject = "Xác nhận đơn hàng";
            BodyBuilder bodyBuilder = new()
            {
                HtmlBody = $"<h1>Đơn hàng của bạn đã được xác nhận, hãy ghé cửa hàng sớm nhất để thanh toán!</h1>" +
                $"<br/><h1>Để kiểm tra thông tin đơn hàng hãy vào lịch sử đơn hàng của bạn!</h1>",
                TextBody = "Xác nhận đơn hàng thành công"
            };
            message.Body = bodyBuilder.ToMessageBody();
            // xac thuc email
            SmtpClient client = new();
            //connect (smtp address, port , true)
            await client.ConnectAsync("smtp.gmail.com", 465, true);
            await client.AuthenticateAsync("h2t.moto.huflit@gmail.com", "H2tmotohuflit");
            //send email
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
            client.Dispose();
            #endregion

            return RedirectToAction("DaXacNhan");
        }

        public async Task<IActionResult> ThanhToan(string ID)
        {
            var hoaDon = await database.HoaDons.Where(x => x.Idhd == ID).FirstOrDefaultAsync();
            var khachHang = await database.KhachHangs.Where(x => x.Idkh == hoaDon.Idkh).Select(x => new { x.TenKh, x.Email }).FirstOrDefaultAsync();

            hoaDon.TrangThai = TrangThaiHoaDon.DaThanhToan;
            database.HoaDons.Update(hoaDon);
            await database.SaveChangesAsync();

            #region Gửi mail xác nhận
            MimeMessage message = new();
            MailboxAddress from = new("H2T Moto", "h2t.moto.huflit@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new(khachHang.TenKh, khachHang.Email);
            message.To.Add(to);

            message.Subject = "Thanh toán đơn hàng";
            BodyBuilder bodyBuilder = new()
            {
                HtmlBody = $"<h1>Đơn hàng của bạn đã được thanh toán!</h1>" +
                $"<br/><h1>Để kiểm tra thông tin đơn hàng hãy vào lịch sử đơn hàng của bạn!</h1>" +
                $"<br/><h1>Cảm ơn bạn đã chọn H2T! Hẹn gặp bạn lần tới!</h1>",
                TextBody = "Thanh toán đơn hàng thành công"
            };
            message.Body = bodyBuilder.ToMessageBody();
            // xac thuc email
            SmtpClient client = new();
            //connect (smtp address, port , true)
            await client.ConnectAsync("smtp.gmail.com", 465, true);
            await client.AuthenticateAsync("h2t.moto.huflit@gmail.com", "H2tmotohuflit");
            //send email
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
            client.Dispose();
            #endregion

            return RedirectToAction("Index","HoaDon");
        }

        public async Task<IActionResult> DaXacNhan(int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in 
            //  the paging links in order to keep the sort order the same while paging
            ViewBag.Role = TempData["Role"];

            var ModelList = database.HoaDons.Where(x => x.TrangThai == TrangThaiHoaDon.DaXacNhan).OrderByDescending(p => p.NgayDat).ToList();

            int pageSize = 5;
            //set page to one is there is no value, ??  is called the null-coalescing operator.
            int pageNumber = (page ?? 1);
            //return the Model data with paged
            var modelv = new HoaDonViewModel
            {
                ListHoaDon = ModelList.ToPagedList(pageNumber, pageSize),
                ListChiTietHd = await database.ChiTietHds.ToArrayAsync(),
                ListKhachHang = await database.KhachHangs.ToArrayAsync()
            };
            return View(modelv);
        }

        public async Task<IActionResult> Create()
        {
            var now = DateTime.Now;
            var date = now.AddMilliseconds(-now.Millisecond);

            var model = new HoaDonViewModel
            {
                HoaDon = new HoaDon 
                {
                    Idhd = GetIDHD(),
                    NgayDat = date,
                },
                ListKhachHang = await database.KhachHangs.ToArrayAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                hoaDon.TrangThai = TrangThaiHoaDon.ChuaXacNhan;
                database.HoaDons.Add(hoaDon);
                await database.SaveChangesAsync();
                return RedirectToAction("CTHD", new { ID = hoaDon.Idhd });
            }

            return View(hoaDon);
        }

        public async Task<IActionResult> Details(string ID)
        {
            var model = new HoaDonViewModel
            {
                HoaDon = await database.HoaDons.FindAsync(ID),
                ChiTietHd = new ChiTietHd { Idhd = ID },
                ListChiTietHd = await database.ChiTietHds.Where(x => x.Idhd == ID).ToArrayAsync(),
            };

            return View(model);
        }

        public async Task<IActionResult> CTHD(string ID)
        {
            var model = new HoaDonViewModel
            {
                ChiTietHd = new ChiTietHd { Idhd = ID },
                ListMauXe = database.MauXes.ToArray(),
                ListXe = await database .Xes.Where(x => x.TrangThai == TrangThaiXe.ChuaBan).ToArrayAsync(),
            };

            foreach (var mauxe in model.ListMauXe)
            {
                mauxe.IdhangNavigation = await database.Hangs.Where(x => x.Idhang == mauxe.Idhang).FirstOrDefaultAsync();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CTHD(ChiTietHd chiTietHd)
        {
            try
            {
                var Xe = await database.Xes.Where(x => x.Idxe == chiTietHd.Idxe).FirstOrDefaultAsync();
                var MauXe = await database.MauXes.Where(x => x.Idmau == Xe.Idmau).Select(x => new { x.GiaBan, x.Idkm }).FirstOrDefaultAsync();
                var KhuyenMai = await database.KhuyenMais.Where(x => x.Idkm == MauXe.Idkm).Select(x => x.GiaTri).FirstOrDefaultAsync();

                Xe.TrangThai = TrangThaiXe.DaBan;
                database.Xes.Update(Xe);

                chiTietHd.KhuyenMai = KhuyenMai;
                chiTietHd.GiaBan = MauXe.GiaBan;
                database.ChiTietHds.Add(chiTietHd);
                await database.SaveChangesAsync();

                return RedirectToAction("Details", new { ID = chiTietHd.Idhd });
            }
            catch
            {
                ViewBag.Error = "Xe đã có trong hóa đơn!";

                var model = new HoaDonViewModel
                {
                    ChiTietHd = chiTietHd,
                    ListMauXe = database.MauXes.ToArray(),
                    ListXe = database.Xes.ToArray(),
                };

                foreach (var mauxe in model.ListMauXe)
                {
                    mauxe.IdhangNavigation = await database.Hangs.Where(x => x.Idhang == mauxe.Idhang).FirstOrDefaultAsync();
                }

                return View(model);
            }
        }

        public async Task<IActionResult> DeleteCTHD(string idXe, string idHD)
        {
            var Xe = await database.Xes.Where(x => x.Idxe == idXe).FirstOrDefaultAsync();
            var ChiTietHD = await database.ChiTietHds.Where(x => x.Idhd == idHD && x.Idxe == idXe).FirstOrDefaultAsync();

            Xe.TrangThai = TrangThaiXe.ChuaBan;
            database.Xes.Update(Xe);

            database.Remove(ChiTietHD);
            await database.SaveChangesAsync();

            return RedirectToAction("Details", new { ID = idHD });
        }

        public string GetIDHD()
        {
            var list = database.HoaDons.OrderByDescending(p => p.NgayDat).ToArray();

            int.TryParse(list[0].Idhd.Substring(2), out int lastID);

            string ID = "HD" + ++lastID;

            return ID;
        }
    }
}
