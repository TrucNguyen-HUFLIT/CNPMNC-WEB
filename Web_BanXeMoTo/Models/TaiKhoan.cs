using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            KhachHangs = new HashSet<KhachHang>();
            NhanViens = new HashSet<NhanVien>();
        }
        [Display(Name = "ID tài khoản")]
        [Required(ErrorMessage = "Không được bỏ trống, không được trùng lặp")]
        public string Idtk { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Pass")]
        public string Pass { get; set; }

        [Display(Name = "Vai trò")]
        public bool Type { get; set; }

        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
