using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
    public class HoaDonDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();
        //Trả về danh sách
        public List<HoaDonKhach> getList()
        {
            List<HoaDonKhach> list = db.HoaDons.Join(
                   db.Khaches,
                  hd => hd.MaKhach,
                  k => k.MaKhach,
                  (hd, k) => new HoaDonKhach
                  {
                      MaHD = hd.MaHD,
                      MaNV = hd.MaNV,
                      NgayLapHD = hd.NgayLapHD,
                      TriGia = hd.TriGia,
                      MaKhach = k.MaKhach,
                      TenKhach = k.TenKhach
                  }
                  ).ToList();
            return list;
        }
        public List<HoaDonKhach> getList(int mak)
        {
            List<HoaDonKhach> list = db.HoaDons.Join(
                   db.Khaches,
                  hd => hd.MaKhach,
                  k => k.MaKhach,
                  (hd, k) => new HoaDonKhach
                  {
                      MaHD = hd.MaHD,
                      MaNV = hd.MaNV,
                      NgayLapHD = hd.NgayLapHD,
                      TriGia = hd.TriGia,
                      MaKhach = k.MaKhach,
                      TenKhach = k.TenKhach
                  }
                  )
                  .Where(m => m.MaKhach == mak)
                  .ToList();
            return list;
        }
        public HoaDon getRow(string mahd)
        {
            HoaDon hd = db.HoaDons.Find(mahd);
            return hd;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.HoaDons.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(HoaDon hd)
        {
            db.Entry(hd).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(HoaDon hd)
        {
            db.HoaDons.Remove(hd);
            db.SaveChanges();
        }
    }
}
