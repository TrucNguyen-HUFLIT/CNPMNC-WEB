using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class LoaiXe
    {
        public LoaiXe()
        {
            MauXes = new HashSet<MauXe>();
        }

        public string IdloaiXe { get; set; }
        public string TenLoaiXe { get; set; }

        public virtual ICollection<MauXe> MauXes { get; set; }
    }
}
