using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class ChiTietHd
    {
        public string Idhd { get; set; }
        public string Idxe { get; set; }
        public int? KhuyenMai { get; set; }
        public decimal GiaBan { get; set; }

        public virtual HoaDon IdhdNavigation { get; set; }
        public virtual Xe IdxeNavigation { get; set; }
    }
}
