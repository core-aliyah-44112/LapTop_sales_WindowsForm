using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanLaptop.models
{
    public class HoaDonKhach
    {
        public string MaHD { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int MaKhach { get; set; }
        public string TriGia { get; set; }
        public string TenKhach { get; set; }
    }
}