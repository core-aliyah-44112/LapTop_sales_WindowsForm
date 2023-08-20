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
    public partial class frmHoaDon : Form
    {
        private HoaDonDAO hdDAO = new HoaDonDAO();
        private KhachDAO kDAO = new KhachDAO();
        private string AddOrEdit = null;

        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = hdDAO.getList();
            cbTenKhach.DataSource = kDAO.getList();
            cbTenKhach.DisplayMember = "TenKhach";
            cbTenKhach.ValueMember = "MaKhach";
            txtTongHD.Text = hdDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
            txtMaHD.Enabled = value;
            cbTenKhach.Enabled = value;
            txtMaNV.Enabled = value;
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
                if (string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                {
                    throw new Exception("Mã hóa đơn không được để trống");
                }
                if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                {
                    throw new Exception("Mã nhân viên không được để trống");
                }
                if (cbTenKhach.Text.Length < 4)
                { 
                    throw new Exception("Tên khách ít nhất 4 ký tự");
                }
                if (string.IsNullOrEmpty(dtpNgayLapHD.Text.Trim()))
                {
                    throw new Exception("Ngày lập hóa đơn không được để trống");
                }
                if (string.IsNullOrEmpty(txtTriGia.Text.Trim()))
                {
                    throw new Exception("Trị giá không được để trống");
                }
                //lấy thông tin
                string mahd = txtMaHD.Text.Trim();
                int manv = int.Parse(txtMaNV.Text.Trim());
                DateTime ngaylaphd = Convert.ToDateTime(dtpNgayLapHD.Text.ToString());
                int makhach = int.Parse(cbTenKhach.SelectedValue.ToString());
                string trigia = txtTriGia.Text.Trim();

                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            HoaDon hd = new HoaDon();
                            hd.MaHD = mahd;
                            hd.MaNV = manv;
                            hd.NgayLapHD = ngaylaphd;
                            hd.MaKhach = makhach;
                            hd.TriGia = trigia;
                            //Thêm
                            hdDAO.Insert(hd);
                            txtTongHD.Text = hdDAO.getCount().ToString();
                            dgvDanhSach.DataSource = hdDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            HoaDon hd = hdDAO.getRow(mahd);
                            hd.MaHD = mahd;
                            hd.MaNV = manv;
                            hd.NgayLapHD = ngaylaphd;
                            hd.MaKhach = makhach;
                            hd.TriGia = trigia;
                            //Cập nhật
                            hdDAO.Update(hd);
                            txtTongHD.Text = hdDAO.getCount().ToString();
                            dgvDanhSach.DataSource = hdDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                {
                    throw new Exception("Mã hóa đơn không được để trống");
                }
                string mahd = txtMaHD.Text.Trim();
                HoaDon hd = hdDAO.getRow(mahd);
                hdDAO.Delete(hd);
                txtTongHD.Text = hdDAO.getCount().ToString();
                dgvDanhSach.DataSource = hdDAO.getList();
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
                txtMaHD.Text = dgvDanhSach.Rows[vt].Cells["MaHD"].Value.ToString();
                txtMaNV.Text = dgvDanhSach.Rows[vt].Cells["MaNV"].Value.ToString();
                dtpNgayLapHD.Text = dgvDanhSach.Rows[vt].Cells["NgayLapHD"].Value.ToString();
                cbTenKhach.Text = dgvDanhSach.Rows[vt].Cells["TenKhach"].Value.ToString();
                txtTriGia.Text = dgvDanhSach.Rows[vt].Cells["TriGia"].Value.ToString();
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbHoaDon"]);
        }
    }
}
