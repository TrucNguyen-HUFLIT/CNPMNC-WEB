using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_BanXeMoTo.Models
{
    public class LoginModel

    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email not empty")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password not empty ")]

        public string Password { get; set; }
    }
}
