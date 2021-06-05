using BraintreeHttp;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;
using PayPal.Core;
using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Claims;
using System.Threading.Tasks;
using Web_BanXeMoTo.Helpers;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class GioHangController : Controller
    {
        private readonly QLMTContext database;
        private readonly string _clientId;
        private readonly string _secretKey;
        public double TyGiaUSD = 23300;
        public GioHangController(QLMTContext db, IConfiguration config)
        {
            database = db;
            _clientId = config["PaypalSettings:ClientId"];
            _secretKey = config["PaypalSettings:SecretKey"];
        }
        public List<CartModel> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartModel>>("GioHang");
                if (data == null)
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
        public async Task<IActionResult> AddToCartAsync(string id, string type = "Normal")
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.Idmau == id);
            var amount = database.Xes.Where(x => x.Idmau == id && x.TrangThai == TrangThaiXe.ChuaBan).ToArray().Length;
            int soLuong = item == null ? 0 : item.SoLuong;
            double tongTien = 0, thanhTien = item == null ? 0 : item.ThanhTien;

            if (item == null)
            {
                var mauxe = await database.MauXes.SingleOrDefaultAsync(p => p.Idmau == id);
                item = new CartModel
                {
                    Idmau = id,
                    TenXe = mauxe.TenXe,
                    GiaBan = (double)mauxe.GiaBan,
                    SoLuong = soLuong = 1,
                    Hinh = mauxe.HinhAnh1,
                };

                myCart.Add(item);
            }
            else
            {
                if (item.SoLuong < amount)
                {
                    soLuong = ++item.SoLuong;
                    thanhTien = item.ThanhTien;
                }
                else
                    return BadRequest();
            }

            foreach (var mauxe in myCart)
            {
                tongTien += mauxe.ThanhTien;
            }
            HttpContext.Session.Set("GioHang", myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    id,
                    tongTien,
                    thanhTien,
                    soLuong,
                    total = Carts.Sum(c => c.SoLuong),
                });
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult MinusFromCart(string id, string type = "Normal")
        {
            var myCart = Carts;
            var mauxe = database.MauXes.SingleOrDefault(p => p.Idmau == id);
            int soLuong = 0;
            double tongTien = 0, thanhTien = 0;

            foreach (var item in myCart)
            {

                if (item.Idmau == mauxe.Idmau && item.SoLuong > 0)
                {
                    item.SoLuong--;
                    thanhTien = item.ThanhTien;
                    soLuong = item.SoLuong;
                    break;
                }
            }

            foreach (var item in myCart)
            {
                tongTien += item.ThanhTien;
            }

            HttpContext.Session.Set("GioHang", myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    id,
                    tongTien,
                    thanhTien,
                    soLuong,
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

                if (item.Idmau == mauxe.Idmau)
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


        public async Task<IActionResult> ThanhToan()
        {
            var myCart = Carts;
            if (User.FindFirst(ClaimTypes.Email) == null)
            {
                return RedirectToAction("Login", "Login");
            }
            string email = User.FindFirst(ClaimTypes.Email).Value;
            var khachHang = await database.KhachHangs.Where(x => x.Email == email).FirstOrDefaultAsync();

            var hoaDon = new HoaDon
            {
                Idhd = GetIDHD(),
                Idkh = khachHang.Idkh,
                NgayDat = DateTime.Now,
                TrangThai = TrangThaiHoaDon.ChuaXacNhan,

            };
            database.Add(hoaDon);
            await database.SaveChangesAsync();

            foreach (var item in myCart)
            {
                var Idkm = await database.MauXes.Where(x => x.Idmau == item.Idmau).Select(x => x.Idkm).FirstOrDefaultAsync();
                var listXe = await database.Xes.Where(x => x.Idmau == item.Idmau && x.TrangThai == TrangThaiXe.ChuaBan).ToArrayAsync();

                var khuyenMai = await database.KhuyenMais.Where(x => x.Idkm == Idkm).Select(x => x.GiaTri).FirstOrDefaultAsync();

                for (int count = 0; count < item.SoLuong; count++)
                {
                    database.Add(new ChiTietHd
                    {
                        Idhd = hoaDon.Idhd,
                        Idxe = listXe[count].Idxe,
                        KhuyenMai = khuyenMai,
                        GiaBan = (decimal)item.GiaBan,

                    });
                    listXe[count].TrangThai = TrangThaiXe.DaBan;

                    database.Xes.Update(listXe[count]);
                    await database.SaveChangesAsync();

                }
            }
            return View("Notify");
        }

        [Authorize]
        public async Task<IActionResult> PaypalCheckOut()
        {
            var environment = new SandboxEnvironment(_clientId, _secretKey);
            var client = new PayPalHttpClient(environment);

            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };
            var total = Math.Round(Carts.Sum(p => p.ThanhTien) / TyGiaUSD, 2);
            foreach (var item in Carts)
            {
                itemList.Items.Add(new Item()
                {
                    Name = item.TenXe,
                    Currency = "USD",
                    Price = Math.Round(item.GiaBan / TyGiaUSD, 2).ToString(),
                    Quantity = item.SoLuong.ToString(),
                    Sku = "sku",
                    Tax = "0"
                });
            }

            var paypalOrderId = DateTime.Now.Ticks;
            var hostname = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = total.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = total.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = $"Invoice #{paypalOrderId}",
                        InvoiceNumber = paypalOrderId.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = $"{hostname}/GioHang/CheckoutFail",
                    ReturnUrl = $"{hostname}/GioHang/CheckoutSuccess"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };
            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                var response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                //Process when Checkout with Paypal fails
                return Redirect("/GioHang/CheckoutFail");
            }
        }
        public async Task<IActionResult> CheckoutFail()
        {
            var myCart = Carts;
            string email = User.FindFirst(ClaimTypes.Email).Value;
            var khachHang = await database.KhachHangs.Where(x => x.Email == email).FirstOrDefaultAsync();

            var hoaDon = new HoaDon
            {
                Idhd = GetIDHD(),
                Idkh = khachHang.Idkh,
                NgayDat = DateTime.Now,
                TrangThai = TrangThaiHoaDon.ChuaXacNhan,

            };
            database.Add(hoaDon);
            await database.SaveChangesAsync();

            foreach (var item in myCart)
            {
                var Idkm = await database.MauXes.Where(x => x.Idmau == item.Idmau).Select(x => x.Idkm).FirstOrDefaultAsync();
                var listXe = await database.Xes.Where(x => x.Idmau == item.Idmau && x.TrangThai == TrangThaiXe.ChuaBan).ToArrayAsync();

                var khuyenMai = await database.KhuyenMais.Where(x => x.Idkm == Idkm).Select(x => x.GiaTri).FirstOrDefaultAsync();

                for (int count = 0; count < item.SoLuong; count++)
                {
                    database.Add(new ChiTietHd
                    {
                        Idhd = hoaDon.Idhd,
                        Idxe = listXe[count].Idxe,
                        KhuyenMai = khuyenMai,
                        GiaBan = (decimal)item.GiaBan,

                    });
                    listXe[count].TrangThai = TrangThaiXe.DaBan;

                    database.Xes.Update(listXe[count]);
                    await database.SaveChangesAsync();

                }
            }
            return View();
        }
        public async Task<IActionResult> CheckoutSuccess()
        {
            var myCart = Carts;
            string email = User.FindFirst(ClaimTypes.Email).Value;
            var khachHang = await database.KhachHangs.Where(x => x.Email == email).FirstOrDefaultAsync();

            var hoaDon = new HoaDon
            {
                Idhd = GetIDHD(),
                Idkh = khachHang.Idkh,
                NgayDat = DateTime.Now,
                TrangThai = TrangThaiHoaDon.DaThanhToan,

            };
            database.Add(hoaDon);
            await database.SaveChangesAsync();

            foreach (var item in myCart)
            {
                var Idkm = await database.MauXes.Where(x => x.Idmau == item.Idmau).Select(x => x.Idkm).FirstOrDefaultAsync();
                var listXe = await database.Xes.Where(x => x.Idmau == item.Idmau && x.TrangThai == TrangThaiXe.ChuaBan).ToArrayAsync();

                var khuyenMai = await database.KhuyenMais.Where(x => x.Idkm == Idkm).Select(x => x.GiaTri).FirstOrDefaultAsync();

                for (int count = 0; count < item.SoLuong; count++)
                {
                    database.Add(new ChiTietHd
                    {
                        Idhd = hoaDon.Idhd,
                        Idxe = listXe[count].Idxe,
                        KhuyenMai = khuyenMai,
                        GiaBan = (decimal)item.GiaBan,

                    });
                    listXe[count].TrangThai = TrangThaiXe.DaBan;

                    database.Xes.Update(listXe[count]);
                    await database.SaveChangesAsync();

                }
            }
            SendEmailConfirm(hoaDon);

            return View();
        }

        public async Task SendEmailConfirm(HoaDon hoaDon )
        {
            var khachHang = await database.KhachHangs.Where(x => x.Idkh == hoaDon.Idkh).FirstOrDefaultAsync();
            
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new("H2T Moto", "h2t.moto.huflit@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new(khachHang.TenKh, khachHang.Email);
            message.To.Add(to);

            message.Subject = "Thanh toán thành công";
            BodyBuilder bodyBuilder = new()
            {
                HtmlBody = $"<h1>Bạn đã thanh toán thành công hóa đơn {hoaDon.Idhd}, cảm ơn bạn đã đồng hành cùng chúng tôi  </h1>",
                TextBody = "Đơn hàng của bạn đã được thanh toán "
            };
            message.Body = bodyBuilder.ToMessageBody();
            SmtpClient client = new();
            //connect (smtp address, port , true)
            await client.ConnectAsync("smtp.gmail.com", 465, true);
            await client.AuthenticateAsync("h2t.moto.huflit@gmail.com", "H2tmotohuflit");
            //send email
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
            client.Dispose();

        }
        public string GetIDHD()
        {
            var list = database.HoaDons.ToArray();

            int.TryParse(list[list.Length - 1].Idhd.Substring(2), out int lastID);

            string ID = "HD" + ++lastID;

            return ID;
        }
    }
}
