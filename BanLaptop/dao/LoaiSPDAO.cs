using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
    public class LoaiSPDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();
        //Trả về danh sách
        public List<LoaiSP> getList()
        {
            //SELECT * FROM LoaiSP
            List<LoaiSP> list = db.LoaiSPs.ToList();
            return list;
        }
        public LoaiSP getRow(int malsp)
        {
            LoaiSP lsp = db.LoaiSPs.Find(malsp);
            return lsp;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.LoaiSPs.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(LoaiSP lsp)
        {
            db.LoaiSPs.Add(lsp);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(LoaiSP lsp)
        {
            db.Entry(lsp).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(LoaiSP lsp)
        {
            db.LoaiSPs.Remove(lsp);
            db.SaveChanges();
        }
    }
}
