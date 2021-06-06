using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            ChiTietDgs = new HashSet<ChiTietDg>();
            HoaDons = new HashSet<HoaDon>();
        }
        [Display(Name = "ID")]
        public int Idkh { get; set; }

        [Display(Name = "ID Loại TK")]
        public string Idtype { get; set; }

        public string Email { get; set; }

        [Display(Name ="Mật khẩu")]
        public string Pass { get; set; }

        [Display(Name = "Tên Khách Hàng")]
        public string TenKh { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "Số điện Thoại")]
        public string DienThoai { get; set; }

        public string Avatar { get; set; }

        public virtual TypeAcc IdtypeNavigation { get; set; }
        public virtual ICollection<ChiTietDg> ChiTietDgs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [NotMapped]
        public IFormFile UploadHinh { get; set; }

        // Change Password
        [NotMapped]
        [Display(Name = "Nhập mật khẩu cũ")]
        public string CurrentPassword { get; set; }

        [NotMapped]
        [Display(Name = "Nhập mật khẩu mới")]
        public string NewPassword { get; set; }

        [NotMapped]
        [Display(Name = "Xác nhận mật khẩu mới")]
        [Compare("NewPassword", ErrorMessage = "Xác nhận mật khẩu không chính xác, vui lòng kiểm tra lại !!!")]
        public string ConfirmNewPassword { get; set; }

    }
}
