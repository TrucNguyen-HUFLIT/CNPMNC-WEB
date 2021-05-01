using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_BanXeMoTo.Models
{
    public class KhachHangCreate : KhachHang
    {
        public SelectList DepartmentNameSL { get; set; }

        public void DropdownList(QLMoToContext _context, object selected = null )
        {
            var query = from ds in _context.LoaiKhs
                        orderby ds.TenLoaiKh
                        select ds;
            DepartmentNameSL = new SelectList(query.ToArray(), "IdloaiKh", "TenLoaiKh", selected);
        }
    }
}
