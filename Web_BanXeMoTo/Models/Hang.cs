using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class Hang
    {
        public Hang()
        {
            MauXes = new HashSet<MauXe>();
        }

        public string Idhang { get; set; }
        public string TenHang { get; set; }

        public virtual ICollection<MauXe> MauXes { get; set; }
    }
}
