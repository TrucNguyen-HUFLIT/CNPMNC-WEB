using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            ChiTietDgs = new HashSet<ChiTietDg>();
            DatLiches = new HashSet<DatLich>();
            HoaDons = new HashSet<HoaDon>();
        }
        [Display(Name = "ID")]
        public string Idkh { get; set; }
        [Display(Name = "ID Tai Khoan")]
        public string Idtk { get; set; }
        [Display(Name = "Loại Khách Hàng")]
        public string IdloaiKh { get; set; }
        [Display(Name = "Tên Khach Hàng")]
        public string TenKh { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Số điện Thoại")]
        public string DienThoai { get; set; }
        public string Avatar { get; set; }

        public virtual LoaiKh IdloaiKhNavigation { get; set; }
        public virtual TaiKhoan IdtkNavigation { get; set; }
        public virtual ICollection<ChiTietDg> ChiTietDgs { get; set; }
        public virtual ICollection<DatLich> DatLiches { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
        [NotMapped]
        public IEnumerable<LoaiKh> ListLoaiKh { get; set; }
    }
}
