using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class NhanVien
    {
        [Display(Name = "ID Nhân viên")]

        public int Idnv { get; set; }

        [Display(Name = "ID LoạiTK")]

        public string Idtype { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Email { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Pass { get; set; }

        [Display(Name = "Tên nhân viên")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TenNv { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string DienThoai { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "CMND")]
        public string Cmnd { get; set; }

        [Display(Name = "Avatar")]
        public string Avatar { get; set; }

        public virtual TypeAcc IdtypeNavigation { get; set; }

        [NotMapped]
        public IFormFile UpLoadAvt { get; set; }


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
