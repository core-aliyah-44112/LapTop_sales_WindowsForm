using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanLaptop.models;
using System.Data.Entity;

namespace BanLaptop.dao
{
    public class NhaCCDAO
    {
        QLLAPTOPDbContext db = new QLLAPTOPDbContext();
        //Trả về danh sách
        public List<NhaCC> getList()
        {
            //SELECT * FROM NhaCC
            List<NhaCC> list = db.NhaCCs.ToList();
            return list;
        }
        public NhaCC getRow(int mancc)
        {
            NhaCC ncc = db.NhaCCs.Find(mancc);
            return ncc;
        }
        //Trả về số lượng
        public int getCount()
        {
            return db.NhaCCs.Count();//Số mẫu tin
        }
        //Thêm
        public void Insert(NhaCC ncc)
        {
            db.NhaCCs.Add(ncc);
            db.SaveChanges(); //Lưu vào
        }
        //Sửa
        public void Update(NhaCC ncc)
        {
            db.Entry(ncc).State = EntityState.Modified;//
            db.SaveChanges();
        }
        //Xóa
        public void Delete(NhaCC ncc)
        {
            db.NhaCCs.Remove(ncc);
            db.SaveChanges();
        }
    }
}
