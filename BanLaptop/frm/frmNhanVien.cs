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
    public partial class frmNhanVien : Form
    {
        private NhanVienDAO nvDAO = new NhanVienDAO();
        private string AddOrEdit = null;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = nvDAO.getList();
            txtTongNV.Text = nvDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
            txtMaNV.Enabled = value;
            txtHoTenNV.Enabled = value;
            cbGioiTinh.Enabled = value;
            txtDiaChi.Enabled = value;
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
                if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                {
                    throw new Exception("Mã nhân viên không được để trống");
                }
                if (string.IsNullOrEmpty(txtHoTenNV.Text.Trim()))
                {
                    throw new Exception("Họ tên nhân viên không được để trống");
                }
                if (string.IsNullOrEmpty(cbGioiTinh.Text.Trim()))
                {
                    throw new Exception("Giới tính không được để trống");
                }
                if (string.IsNullOrEmpty(dtpNgaySinh.Text.Trim()))
                {
                    throw new Exception("Vui lòng chọn ngày sinh");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                {
                    throw new Exception("Xin vui lòng nhập địa chỉ");
                }
                if (string.IsNullOrEmpty(txtDienThoai.Text.Trim()))
                {
                    throw new Exception("Xin vui lòng nhập số điện thoại");
                }
                //Lấy thông tin
                int manv = int.Parse(txtMaNV.Text.Trim());
                string hotennv = txtHoTenNV.Text.Trim();
                DateTime ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text.ToString());
                string gioitinh = cbGioiTinh.Text;
                string diachi = txtDiaChi.Text.Trim();
                string dienthoai = txtDienThoai.Text.Trim();

                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            NhanVien nv = new NhanVien();
                            nv.MaNV = manv;
                            nv.HoTenNV = hotennv;
                            nv.NgaySinh = ngaysinh;
                            nv.GioiTinh = gioitinh;
                            nv.DiaChi = diachi;
                            nv.DienThoai = dienthoai;
                            //Thêm
                            nvDAO.Insert(nv);
                            txtTongNV.Text = nvDAO.getCount().ToString();
                            dgvDanhSach.DataSource = nvDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            NhanVien nv = nvDAO.getRow(manv);
                            nv.MaNV = manv;
                            nv.HoTenNV = hotennv;
                            nv.NgaySinh = ngaysinh;
                            nv.GioiTinh = gioitinh;
                            nv.DiaChi = diachi;
                            nv.DienThoai = dienthoai;
                            //Cập nhật
                            nvDAO.Update(nv);
                            txtTongNV.Text = nvDAO.getCount().ToString();
                            dgvDanhSach.DataSource = nvDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                {
                    throw new Exception("Mã nhân viên không được để trống");
                }
                if (string.IsNullOrEmpty(txtHoTenNV.Text.Trim()))
                {
                    throw new Exception("Mã họ tên nhân viên không được để trống");
                }
                int manv = int.Parse(txtMaNV.Text.Trim());
                NhanVien nv = nvDAO.getRow(manv);
                nvDAO.Delete(nv);
                txtTongNV.Text = nvDAO.getCount().ToString();
                dgvDanhSach.DataSource = nvDAO.getList();
                MessageBox.Show("Xóa thành công", "Thông báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                //Đưa dữ liệu lên lưới
                txtMaNV.Text = dgvDanhSach.Rows[vt].Cells["MaNV"].Value.ToString();
                txtHoTenNV.Text = dgvDanhSach.Rows[vt].Cells["HoTenNV"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[vt].Cells["NgaySinh"].Value.ToString();
                cbGioiTinh.Text = dgvDanhSach.Rows[vt].Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[vt].Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = dgvDanhSach.Rows[vt].Cells["DienThoai"].Value.ToString();
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbNhanVien"]);
        }
    }
}
