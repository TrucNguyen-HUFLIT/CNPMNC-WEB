using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_BanXeMoTo.Models
{
    public class TaiKhoanNVModel
    {
        [Display(Name = "ID tài khoản")]
        [Required(ErrorMessage = "Không được bỏ trống, không được trùng lặp")]
        public string Idtk { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Pass")]
        public string Pass { get; set; }

        [Display(Name = "Vai trò")]
        public bool Type { get; set; }

        [Display(Name = "ID Nhân viên")]
        [Required(ErrorMessage = "Không được bỏ trống, không được trùng lặp")]
        public string Idnv { get; set; }


        [Display(Name = "Tên nhân viên")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TenNv { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string DienThoai { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Không được bỏ trống")]

        public string DiaChi { get; set; }
        [Display(Name = "CMND")]
        [Required(ErrorMessage = "Không được bỏ trống")]

        public string Cmnd { get; set; }
        [Display(Name = "Avatar")]
        public string Avatar { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Hãy chọn hình")]
        public IFormFile UpLoadAvt { get; set; }
    }
}
