using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_BanXeMoTo.Models
{
    public class ChangePassword
    {
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu hiện tại")]
        [Required(ErrorMessage = "Không được bỏ trống!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới")]
        [Required(ErrorMessage = "Không được bỏ trống!")]
        public string NewPassword { get; set; }

        [NotMapped]
        [Compare("NewPassword",ErrorMessage = "Mật khẩu không khớp!")]
        [Display(Name = "Nhập lại mật khẩu")]
        [Required(ErrorMessage = "Không được bỏ trống!")]
        [DataType(DataType.Password)]
        public string ConfirmPass { get; set; }
    }
}
