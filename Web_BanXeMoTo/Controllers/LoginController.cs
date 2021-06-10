using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class LoginController : Controller
    {
        private readonly QLMTContext database;

        public LoginController(QLMTContext db)
        {
            database = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var modelNV = await database.NhanViens.Where(x => x.Email == loginModel.Email && x.Pass == Common.HashPassword.MD5Hash(loginModel.Password)).FirstOrDefaultAsync();
            var modelKH = await database.KhachHangs.Where(x => x.Email == loginModel.Email && x.Pass == Common.HashPassword.MD5Hash(loginModel.Password)).FirstOrDefaultAsync();
            if (modelNV != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, loginModel.Email),
                    new Claim(ClaimTypes.Role, database.TypeAccs.Where(x=>x.Idtype==modelNV.Idtype).FirstOrDefault().Name),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                HttpContext.Session.SetString("email", loginModel.Email);
                return RedirectToAction("ProfileNhanVien", "Profile");
            }
            else if (modelKH != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, loginModel.Email),
                    new Claim(ClaimTypes.Role, database.TypeAccs.Where(x=>x.Idtype==modelKH.Idtype).FirstOrDefault().Name),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                HttpContext.Session.SetString("email", loginModel.Email);
                return RedirectToAction("Home", "Customer");

            }

            ViewBag.error = "Sai thông tin tài khoản";
            return View("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModels)
        {
            if (ModelState.IsValid)
            {
                var emailExisted = database.KhachHangs.Any(x => x.Email == registerModels.Email);
                if (emailExisted)
                {
                    ViewBag.error = "Email đã tồn tại!";
                    return View(registerModels);
                }
                var model = new KhachHang
                {
                    Idkh = database.KhachHangs.ToArray()[^1].Idkh + 1,
                    TenKh = "Cập nhật tên",
                    Email = registerModels.Email,
                    Pass = Common.HashPassword.MD5Hash(registerModels.Password),
                    DiaChi = "Hãy cập nhật địa chỉ của bạn",
                    DienThoai = "",
                    Avatar = "/img/Avatar/avt-default.png",
                    Idtype = "type3",
                };
                ViewBag.success = "Đã đăng ký thành công!";
                database.KhachHangs.Add(model);
                await database.SaveChangesAsync();
                return View("Login");
            }
            return View(registerModels);
        }


        [HttpGet]
        public IActionResult Reset()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reset(ResetModel resetModel)
        {

            if (ModelState.IsValid)
            {
                var model = await database.KhachHangs.Where(x => x.Email == resetModel.Email).FirstOrDefaultAsync();
                if (model == null)
                {
                    ViewBag.error = "Email không tồn tại trong hệ thống!";
                    return View(resetModel);
                }

                //model.pass đã được set new password
                model.Pass = GetPasswordRandom();
                database.KhachHangs.Update(model);
                await database.SaveChangesAsync();

                #region Send mail
                MimeMessage message = new();

                MailboxAddress from = new("H2T Moto", "h2t.moto.huflit@gmail.com");
                message.From.Add(from);

                MailboxAddress to = new(model.TenKh, model.Email);
                message.To.Add(to);

                message.Subject = "Reset Mật khẩu thành công";
                BodyBuilder bodyBuilder = new()
                {
                    HtmlBody = $"<h1>Mật khẩu của bạn đã được reset, mật khẩu mới: {model.Pass}  </h1>",
                    TextBody = "Mật Khẩu của bạn đã được thay đổi "
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
                ViewBag.success = "Hãy kiểm tra email của bạn để lấy mật khẩu mới!";

                return View("Login");
            }
            return View(resetModel);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            StaticAcc.Avatar = "";
            StaticAcc.Name = "";
            HttpContext.Session.Remove("email");
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (StaticAcc.TypeAcc == "customer")
            {
                StaticAcc.TypeAcc = "";
                return RedirectToAction("Home", "customer");
            }
            else
            {
                StaticAcc.TypeAcc = "";
                return RedirectToAction("Login");
            }
        }

        public string GetPasswordRandom()
        {
            Random rnd = new();
            string value = "";
            for (int i = 0; i < 6; i++)
            {
                value += rnd.Next(0, 9).ToString();
            }
            return value;
        }
    }
}
