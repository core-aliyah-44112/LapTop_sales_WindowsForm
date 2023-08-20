using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanLaptop.models;
using BanLaptop.dao;
using BanLaptop.Library;

namespace BanLaptop.frm
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //Thành viên đang đăng nhập
                ThanhVien thanhVien = frmMain.thanhvien;
                string matkhauccu = MaHoa.ToMD5(txtMatKhauCu.Text.Trim());
                if (!thanhVien.MatKhau.Equals(matkhauccu))
                {
                    throw new Exception("Mật khẩu cũ không chính xác");
                }
                if (!txtMatKhauMoi.Text.Equals(txtXacNhanMatKhau.Text.Trim()))
                {
                    throw new Exception("Mật khẩu mới không khớp");
                }
                string matkhau = MaHoa.ToMD5(txtMatKhauMoi.Text.Trim());
                thanhVien.MatKhau = matkhau; //cập nhật mật khẩu
                ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
                thanhVienDAO.Update(thanhVien);
                MessageBox.Show("Cập nhật thành công");
                frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbDoiMatKhau"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbDoiMatKhau"]);
        }
    }
}
