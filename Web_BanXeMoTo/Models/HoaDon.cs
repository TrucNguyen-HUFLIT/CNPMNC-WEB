using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHds = new HashSet<ChiTietHd>();
        }

        public string Idhd { get; set; }
        public string Idkh { get; set; }
        public DateTime NgayDat { get; set; }
        public decimal TongTien { get; set; }

        public virtual KhachHang IdkhNavigation { get; set; }
        public virtual ICollection<ChiTietHd> ChiTietHds { get; set; }
    }
}
