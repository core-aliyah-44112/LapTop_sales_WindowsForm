using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
    public class KhachDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();
        //Trả về danh sách
        public List<Khach> getList()
        {
            //SELECT * FROM Khach
            List<Khach> list = db.Khaches.ToList();
            return list;
        }
        public Khach getRow(int mak)
        {
            Khach k = db.Khaches.Find(mak);
            return k;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.Khaches.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(Khach k)
        {
            db.Khaches.Add(k);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(Khach k)
        {
            db.Entry(k).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(Khach k)
        {
            db.Khaches.Remove(k);
            db.SaveChanges();
        }
    }
}
