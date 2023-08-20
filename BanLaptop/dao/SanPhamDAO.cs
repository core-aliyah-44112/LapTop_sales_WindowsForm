using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
    public class SanPhamDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();

        //Trả về danh sách
        public List<SanPhamLoaiSP> getList()
        {
            List<SanPhamLoaiSP> list = db.SanPhams.Join(
                  db.LoaiSPs,
                  sp => sp.MaLoai,
                  lsp => lsp.MaLoai,
                  (sp, lsp) => new SanPhamLoaiSP
                  {
                      MaSP = sp.MaSP,
                      TenSP = sp.TenSP,
                      MaNCC = sp.MaNCC,
                      SoLuong = sp.SoLuong,
                      DonGiaNhap = sp.DonGiaNhap,
                      GhiChu = sp.GhiChu,
                      TenLoai = lsp.TenLoai,
                      MaLoai = lsp.MaLoai
                  }
                 ).ToList();
            return list;
        }
        public List<SanPhamLoaiSP> getList(int malsp)
        {
            List<SanPhamLoaiSP> list = db.SanPhams.Join(
                  db.LoaiSPs,
                  sp => sp.MaLoai,
                  lsp => lsp.MaLoai,
                  (sp, lsp) => new SanPhamLoaiSP
                  {
                      MaSP = sp.MaSP,
                      TenSP = sp.TenSP,
                      MaNCC = sp.MaNCC,
                      SoLuong = sp.SoLuong,
                      DonGiaNhap = sp.DonGiaNhap,
                      GhiChu = sp.GhiChu,
                      TenLoai = lsp.TenLoai,
                      MaLoai = lsp.MaLoai
                  }
                 )
                .Where(m => m.MaLoai == malsp)
                .ToList();
            return list;
        }
        public SanPham getRow(string masp)
        {
            SanPham sp = db.SanPhams.Find(masp);
            return sp;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.SanPhams.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(SanPham sp)
        {
            db.Entry(sp).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(SanPham sp)
        {
            db.SanPhams.Remove(sp);
            db.SaveChanges();
        }
    }
}
