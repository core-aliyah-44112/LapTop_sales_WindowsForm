using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
   public class BaoHanhDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();
        //Trả về danh sách
        public List<BaoHanh> getList()
        {
            //SELECT * FROM BaoHanh
            List<BaoHanh> list = db.BaoHanhs.ToList();
            return list;
        }
        public BaoHanh getRow(int mabh)
        {
            BaoHanh bh = db.BaoHanhs.Find(mabh);
            return bh;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.BaoHanhs.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(BaoHanh bh)
        {
            db.BaoHanhs.Add(bh);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(BaoHanh bh)
        {
            db.Entry(bh).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(BaoHanh bh)
        {
            db.BaoHanhs.Remove(bh);
            db.SaveChanges();
        }
    }
}
