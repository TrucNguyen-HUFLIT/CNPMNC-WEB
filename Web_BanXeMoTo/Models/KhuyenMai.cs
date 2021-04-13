using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            LoaiKhs = new HashSet<LoaiKh>();
            MauXes = new HashSet<MauXe>();
        }

        public string Idkm { get; set; }
        [DisplayName("Khuyến mãi")]
        public int GiaTri { get; set; }

        public virtual ICollection<LoaiKh> LoaiKhs { get; set; }
        public virtual ICollection<MauXe> MauXes { get; set; }
    }
}
