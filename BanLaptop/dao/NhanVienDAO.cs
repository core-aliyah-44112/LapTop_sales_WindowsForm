using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
    public class NhanVienDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();
        //Trả về danh sách
        public List<NhanVien> getList()
        {
            //SELECT * FROM NhanVien
            List<NhanVien> list = db.NhanViens.ToList();
            return list;
        }
        public NhanVien getRow(int manv)
        {
            NhanVien nv = db.NhanViens.Find(manv);
            return nv;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.NhanViens.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(NhanVien nv)
        {
            db.Entry(nv).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(NhanVien nv)
        {
            db.NhanViens.Remove(nv);
            db.SaveChanges();
        }
    }
}
