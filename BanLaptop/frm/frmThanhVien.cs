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

namespace BanLaptop.frm
{
    public partial class frmThanhVien : Form
    {
        ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
        private string AddOrEdit = null;
        public frmThanhVien()
        {
            InitializeComponent();
        }
        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = thanhVienDAO.getList();
            txtTongTV.Text = thanhVienDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
            txtTenDangNhap.Enabled = value;
            txtMatKhau.Enabled = value;
            txtHoTen.Enabled = value;
            txtEmail.Enabled = value;
            txtDienThoai.Enabled = value;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            OnOff(true);
            btnLuu.Text = "Lưu[Thêm]";
            AddOrEdit = "Add";

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            OnOff(true);
            btnLuu.Text = "Lưu[Sửa]";
            AddOrEdit = "Edit";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTV.Text.Trim()))
                {
                    throw new Exception("Mã thành viên không được để trống");
                }
                if (string.IsNullOrEmpty(txtTenDangNhap.Text.Trim()))
                {
                    throw new Exception("Tên đăng nhập không được để trống");
                }
                if (string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
                {
                    throw new Exception("Xin vui lòng nhập mật khẩu");
                }
                if (string.IsNullOrEmpty(txtHoTen.Text.Trim()))
                {
                    throw new Exception("Họ tên không được để trống!");
                }
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    throw new Exception("Xin vui lòng nhập Email");
                }
                if (string.IsNullOrEmpty(txtDienThoai.Text.Trim()))
                {
                    throw new Exception("Xin vui lòng nhập số điện thoại");
                }
                if (string.IsNullOrEmpty(cbQuyen.Text.Trim()))
                {
                    throw new Exception("Xin hãy chọn quyền của bạn");
                }
                //Lấy thông tin
                int matv = int.Parse(txtMaTV.Text.Trim());
                string tendangnhap = txtTenDangNhap.Text.Trim();
                string matkhau = txtMatKhau.Text.Trim();
                string hoten = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string dienthoai = txtDienThoai.Text.Trim();
                string quyen = cbQuyen.Text;
                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            ThanhVien tv = new ThanhVien();
                            tv.MaTV = matv;
                            tv.TenDangNhap = tendangnhap;
                            tv.MatKhau = matkhau;
                            tv.HoTen = hoten;
                            tv.Email = email;
                            tv.DienThoai = dienthoai;
                            tv.Quyen = quyen;
                            //Thêm
                            thanhVienDAO.Insert(tv);
                            txtTongTV.Text = thanhVienDAO.getCount().ToString();
                            dgvDanhSach.DataSource = thanhVienDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            ThanhVien tv = thanhVienDAO.getRow(matv);
                            tv.MaTV = matv;
                            tv.TenDangNhap = tendangnhap;
                            tv.MatKhau = matkhau;
                            tv.HoTen = hoten;
                            tv.Email = email;
                            tv.DienThoai = dienthoai;
                            tv.Quyen = quyen;
                            //Cập nhật
                            thanhVienDAO.Update(tv);
                            txtTongTV.Text = thanhVienDAO.getCount().ToString();
                            dgvDanhSach.DataSource = thanhVienDAO.getList();
                            MessageBox.Show("Sửa thành công", "Thông báo!");
                            break;
                        }
                }
                OnOff(false);
                btnLuu.Text = "Lưu";
                AddOrEdit = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTV.Text.Trim()))
                {
                    throw new Exception("Mã thành viên không được để trống");
                }
                int matv = int.Parse(txtMaTV.Text.Trim());
                ThanhVien tv = thanhVienDAO.getRow(matv);
                thanhVienDAO.Delete(tv);
                txtTongTV.Text = thanhVienDAO.getCount().ToString();
                dgvDanhSach.DataSource = thanhVienDAO.getList();
                MessageBox.Show("Xóa thành công", "Thông báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbThanhVien"]);
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                //Đưa dữ liệu lên lưới
                txtMaTV.Text = dgvDanhSach.Rows[vt].Cells["MaTV"].Value.ToString();
                txtTenDangNhap.Text = dgvDanhSach.Rows[vt].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvDanhSach.Rows[vt].Cells["MatKhau"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[vt].Cells["HoTen"].Value.ToString();
                txtDienThoai.Text = dgvDanhSach.Rows[vt].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dgvDanhSach.Rows[vt].Cells["Email"].Value.ToString();
                cbQuyen.Text = dgvDanhSach.Rows[vt].Cells["Quyen"].Value.ToString();
            }
        }
    }
}
