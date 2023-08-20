using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
    public class ThanhVienDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();
        //Trả về danh sách
        public List<ThanhVien> getList()
        {
            //SELECT * FROM ThanhVien
            List<ThanhVien> list = db.ThanhViens.ToList();
            return list;
        }
        public ThanhVien getRow(string username)
        {
            ThanhVien tv = db.ThanhViens
               .Where(m => m.TenDangNhap == username)
               .FirstOrDefault();
            return tv;
        }
        public ThanhVien getRow(int matv)
        {
            ThanhVien tv = db.ThanhViens.Find(matv);
            return tv;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.ThanhViens.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(ThanhVien tv)
        {
            db.ThanhViens.Add(tv);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(ThanhVien tv)
        {
            db.Entry(tv).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(ThanhVien tv)
        {
            db.ThanhViens.Remove(tv);
            db.SaveChanges();
        }
    }
}
