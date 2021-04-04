using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class LoaiKh
    {
        public LoaiKh()
        {
            KhachHangs = new HashSet<KhachHang>();
        }

        public string IdloaiKh { get; set; }
        public string Idkm { get; set; }
        public string TenLoaiKh { get; set; }

        public virtual KhuyenMai IdkmNavigation { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
