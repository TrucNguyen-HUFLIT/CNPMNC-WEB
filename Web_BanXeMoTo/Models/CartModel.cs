using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_BanXeMoTo.Models
{
    public class CartModel
    {
        public string Idmau { get; set; }
        public string TenXe { get; set; }

        public string Hinh { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien => (SoLuong * (double)GiaBan);
       

    }
}
