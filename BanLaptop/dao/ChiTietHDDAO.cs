using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
    public class ChiTietHDDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();
        //Trả về danh sách
        public List<ChiTietHDSanPham> getList()
        {
            List<ChiTietHDSanPham> list = db.ChiTietHDs.Join(
                  db.SanPhams,
                  cthd => cthd.MaSP,
                  sp => sp.MaSP,
                  (cthd, sp) => new ChiTietHDSanPham
                  {
                      MaCTHD = cthd.MaCTHD,
                      MaHD = cthd.MaHD,
                      DonVT = cthd.DonVT,
                      MaBH = cthd.MaBH,
                      DonGia = cthd.DonGia,
                      SoLuong = cthd.SoLuong,
                      ThanhTien = cthd.ThanhTien,
                      MaSP = sp.MaSP,
                      TenSP = sp.TenSP
                  }
                 ).ToList();
            return list;
        }
        public List<ChiTietHDSanPham> getList(string masp)
        {
            List<ChiTietHDSanPham> list = db.ChiTietHDs.Join(
                  db.SanPhams,
                  cthd => cthd.MaSP,
                  sp => sp.MaSP,
                  (cthd, sp) => new ChiTietHDSanPham
                  {
                      MaCTHD = cthd.MaCTHD,
                      MaHD = cthd.MaHD,
                      DonVT = cthd.DonVT,
                      MaBH = cthd.MaBH,
                      DonGia = cthd.DonGia,
                      SoLuong = cthd.SoLuong,
                      ThanhTien = cthd.ThanhTien,
                      MaSP = sp.MaSP,
                      TenSP = sp.TenSP
                  }
                 )
                .Where(m => m.MaSP == masp)
                .ToList();
            return list;
        }
        public ChiTietHD getRow(int macthd)
        {
            ChiTietHD cthd = db.ChiTietHDs.Find(macthd);
            return cthd;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.ChiTietHDs.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(ChiTietHD cthd)
        {
            db.ChiTietHDs.Add(cthd);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(ChiTietHD cthd)
        {
            db.Entry(cthd).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(ChiTietHD cthd)
        {
            db.ChiTietHDs.Remove(cthd);
            db.SaveChanges();
        }
    }
}
