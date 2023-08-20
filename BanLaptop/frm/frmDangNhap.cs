using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanLaptop.dao;
using BanLaptop.models;
using BanLaptop.Library;

namespace BanLaptop.frm
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = MaHoa.ToMD5(txtPassword.Text.Trim());
            //Bổ sung
            QLLAPTOPDbContext db = new QLLAPTOPDbContext();
            //select TOP(1) FROM ThanhViens WHERE TenDangNhap ='username'
            ThanhVien tv = db.ThanhViens.Where(m => m.TenDangNhap == username).FirstOrDefault();
            if (tv == null)
            {
                lblThongBao.Text = "Tài khoản không tồn tại";
            }
            else
            {
                if (tv.MatKhau == password)
                {
                    frmMain.thanhvien = tv;
                    this.Close();
                }
                else
                {
                    lblThongBao.Text = "Mật khẩu không chính xác";
                }
            }
        }
    }
}
