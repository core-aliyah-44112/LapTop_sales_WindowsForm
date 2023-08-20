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
    public partial class frmKhach : Form
    {
        HoaDonDAO hdDAO = new HoaDonDAO();
        private KhachDAO kDAO = new KhachDAO();
        private string AddOrEdit = null;
        public frmKhach()
        {
            InitializeComponent();
        }

        private void frmKhach_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = kDAO.getList();
            txtTongKhach.Text = kDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
            txtMaKhach.Enabled = value;
            txtTenKhach.Enabled = value;
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
                if (string.IsNullOrEmpty(txtMaKhach.Text.Trim()))
                {
                    throw new Exception("Mã khách không được để trống");
                }
                if (txtTenKhach.Text.Length < 4)
                {
                    throw new Exception("Tên khách ít nhất 4 ký tự");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                {
                    throw new Exception("Địa chỉ không được để trống");
                }
                if (string.IsNullOrEmpty(txtDienThoai.Text.Trim()))
                {
                    throw new Exception("Xin vui lòng nhập số điện thoại vào");
                }
                if (string.IsNullOrEmpty(cbGioiTinh.Text.Trim()))
                {
                    throw new Exception("Giới tính không được để trống");
                }
                if (string.IsNullOrEmpty(dtpNgaySinh.Text.Trim()))
                {
                    throw new Exception("Ngày sinh không được để trống");
                }
                //Lấy thông tin
                int mak = int.Parse(txtMaKhach.Text.Trim());
                string tenk = txtTenKhach.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                string dienthoai = txtDienThoai.Text.Trim();
                DateTime ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text.ToString());
                string gioitinh = cbGioiTinh.Text;

                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            Khach k = new Khach();
                            k.MaKhach = mak;
                            k.TenKhach = tenk;
                            k.DiaChi = diachi;
                            k.DienThoai = dienthoai;
                            k.NgaySinh = ngaysinh;
                            k.GioiTinh = gioitinh;
                            //Thêm
                            kDAO.Insert(k);
                            txtTongKhach.Text = kDAO.getCount().ToString();
                            dgvDanhSach.DataSource = kDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            Khach k = kDAO.getRow(mak);
                            k.MaKhach = mak;
                            k.TenKhach = tenk;
                            k.DiaChi = diachi;
                            k.DienThoai = dienthoai;
                            k.NgaySinh = ngaysinh;
                            k.GioiTinh = gioitinh;
                            //Cập nhật
                            kDAO.Update(k);
                            txtTongKhach.Text = kDAO.getCount().ToString();
                            dgvDanhSach.DataSource = kDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaKhach.Text.Trim()))
                {
                    throw new Exception("Mã sản phẩm không được để trống");
                }
                if (string.IsNullOrEmpty(txtTenKhach.Text.Trim()))
                {
                    throw new Exception("Tên khách không được để trống");
                }
                int mak = int.Parse(txtMaKhach.Text.Trim());
                Khach k = kDAO.getRow(mak);
                kDAO.Delete(k);
                txtTongKhach.Text = kDAO.getCount().ToString();
                dgvDanhSach.DataSource = kDAO.getList();
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
                txtMaKhach.Text = dgvDanhSach.Rows[vt].Cells["MaKhach"].Value.ToString();
                txtTenKhach.Text = dgvDanhSach.Rows[vt].Cells["TenKhach"].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[vt].Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = dgvDanhSach.Rows[vt].Cells["DienThoai"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[vt].Cells["NgaySinh"].Value.ToString();
                cbGioiTinh.Text = dgvDanhSach.Rows[vt].Cells["GioiTinh"].Value.ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbKhach"]);
        }
    }
}
