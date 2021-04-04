using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class MauXe
    {
        public MauXe()
        {
            DatLiches = new HashSet<DatLich>();
            Xes = new HashSet<Xe>();
        }

        public string Idmau { get; set; }
        public string Idkm { get; set; }
        public string Idhang { get; set; }
        public string TenXe { get; set; }
        public decimal GiaBan { get; set; }
        public string HinhAnh1 { get; set; }
        public string HinhAnh2 { get; set; }
        public string HinhAnh3 { get; set; }
        public int BaoHanh { get; set; }
        public string MoTa { get; set; }

        public virtual Hang IdhangNavigation { get; set; }
        public virtual KhuyenMai IdkmNavigation { get; set; }
        public virtual ICollection<DatLich> DatLiches { get; set; }
        public virtual ICollection<Xe> Xes { get; set; }
    }
}
