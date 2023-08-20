using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanLaptop.models
{
    public class ChiTietHDSanPham
    {
        public int MaCTHD { get; set; }
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public int MaBH { get; set; }
        public string DonVT { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public string TenSP { get; set; }
    }
}