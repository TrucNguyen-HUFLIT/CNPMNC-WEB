using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class DatLich
    {
        public string IddatLich { get; set; }
        public string Idmau { get; set; }
        public string Idkh { get; set; }
        public DateTime NgayDat { get; set; }
        public bool XacNhan { get; set; }

        public virtual KhachHang IdkhNavigation { get; set; }
        public virtual MauXe IdmauNavigation { get; set; }
    }
}
