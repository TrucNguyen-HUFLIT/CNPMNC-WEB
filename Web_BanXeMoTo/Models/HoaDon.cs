using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHds = new HashSet<ChiTietHd>();
        }

        [Display(Name = "ID hóa đơn")]
        public string Idhd { get; set; }

        [Display(Name = "ID khách hàng")]
        public int Idkh { get; set; }

        [Display(Name = "Ngày đặt")]
   
        public DateTime NgayDat { get; set; }

        [Display(Name = "Trạng thái")]
        public TrangThaiHoaDon TrangThai { get; set; }

        public virtual KhachHang IdkhNavigation { get; set; }

        [Display(Name = "Chi tiết hóa đơn")]
        public virtual ICollection<ChiTietHd> ChiTietHds { get; set; }

    }
    public enum TrangThaiHoaDon
    {
        [Display(Name = "Chưa xác nhận")]
        ChuaXacNhan = 0,
        [Display(Name = "Đã xác nhận")]
        DaXacNhan = 1,
        [Display(Name = "Đã thanh toán")]
        DaThanhToan = 2,
    }
}
