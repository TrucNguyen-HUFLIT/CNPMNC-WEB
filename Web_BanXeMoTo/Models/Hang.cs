using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


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

        [NotMapped]
        public List<Hang> ListHang { get; set; }

    }
}
