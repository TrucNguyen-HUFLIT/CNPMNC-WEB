using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class NhanVien
    {
        public string Idnv { get; set; }
        public string Idtk { get; set; }
        public string TenNv { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Cmnd { get; set; }
        public string Avatar { get; set; }

        public virtual TaiKhoan IdtkNavigation { get; set; }
    }
}
