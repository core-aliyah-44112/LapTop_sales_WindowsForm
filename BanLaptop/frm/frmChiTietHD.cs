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
    public partial class frmChiTietHD : Form
    {
        private ChiTietHDDAO cthdDAO = new ChiTietHDDAO();
        private SanPhamDAO spDAO = new SanPhamDAO();
        private string AddOrEdit = null;

        public frmChiTietHD()
        {
            InitializeComponent();
        }
        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = cthdDAO.getList();
            cbTenSP.DataSource = spDAO.getList();
            cbTenSP.DisplayMember = "TenSP";
            cbTenSP.ValueMember = "MaSP";
            txtTongCTHD.Text = cthdDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
            txtMaCTHD.Enabled = value;
            txtMaHD.Enabled = value;
            cbTenSP.Enabled = value;
            txtDonGia.Enabled = value;
            txtThanhTien.Enabled = value;
            txtMaBH.Enabled = value;
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
                if (string.IsNullOrEmpty(txtMaCTHD.Text.Trim()))
                {
                    throw new Exception("Mã chi tiết hóa đơn không được để trống");
                }
                if (string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                {
                    throw new Exception("Mã hóa đơn không được để trống");
                }
                if (string.IsNullOrEmpty(cbTenSP.Text.Trim()))
                {
                    throw new Exception("Mã sản phẩm không được để trống");
                }
                if (string.IsNullOrEmpty(txtMaBH.Text.Trim()))
                {
                    throw new Exception("Mã bảo hành không được để trống");
                }
                if (string.IsNullOrEmpty(nudSoLuong.Text.Trim()))
                {
                    throw new Exception("Xin vui lòng nhập số lượng");
                }
                if (string.IsNullOrEmpty(txtDonGia.Text.Trim()))
                {
                    throw new Exception("Đơn giá không được để trống");
                }
                //lấy thông tin
                int macthd = int.Parse(txtMaCTHD.Text.Trim());
                int mabh = int.Parse(txtMaBH.Text.Trim());
                string mahd = txtMaHD.Text.Trim();
                string masp = cbTenSP.SelectedValue.ToString();
                string donvt = cbDonVT.Text;
                decimal dongia = Convert.ToInt32(txtDonGia.Text.ToString());
                int soluong = int.Parse(nudSoLuong.Text.Trim());
                decimal thanhtien = dongia * soluong;
                //Do khóa tăng tự động
                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            ChiTietHD cthd = new ChiTietHD();
                            cthd.MaCTHD = macthd;
                            cthd.MaBH = mabh;
                            cthd.MaHD = mahd;
                            cthd.MaSP = masp;
                            cthd.DonVT = donvt;
                            cthd.DonGia = dongia;
                            cthd.SoLuong = soluong;
                            cthd.ThanhTien = thanhtien;
                            //Thêm
                            cthdDAO.Insert(cthd);
                            txtTongCTHD.Text = cthdDAO.getCount().ToString();
                            dgvDanhSach.DataSource = cthdDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            ChiTietHD cthd = cthdDAO.getRow(macthd);
                            cthd.MaCTHD = macthd;
                            cthd.MaBH = mabh;
                            cthd.MaHD = mahd;
                            cthd.MaSP = masp;
                            cthd.DonVT = donvt;
                            cthd.DonGia = dongia;
                            cthd.SoLuong = soluong;
                            cthd.ThanhTien = thanhtien;
                            //Cập nhật
                            cthdDAO.Update(cthd);
                            txtTongCTHD.Text = cthdDAO.getCount().ToString();
                            dgvDanhSach.DataSource = cthdDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaCTHD.Text.Trim()))
                {
                    throw new Exception("Mã chi tiết hóa đơn không được để trống");
                }
                int macthd = int.Parse(txtMaCTHD.Text.Trim());
                ChiTietHD cthd = cthdDAO.getRow(macthd);
                cthdDAO.Delete(cthd);
                txtTongCTHD.Text = cthdDAO.getCount().ToString();
                dgvDanhSach.DataSource = cthdDAO.getList();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                //Đưa dữ liệu lên lưới
                txtMaCTHD.Text = dgvDanhSach.Rows[vt].Cells["MaCTHD1"].Value.ToString();
                txtMaHD.Text = dgvDanhSach.Rows[vt].Cells["MaHD"].Value.ToString();
                txtMaBH.Text = dgvDanhSach.Rows[vt].Cells["MaBH"].Value.ToString();
                cbTenSP.Text = dgvDanhSach.Rows[vt].Cells["TenSP"].Value.ToString();
                cbDonVT.Text = dgvDanhSach.Rows[vt].Cells["DonVT"].Value.ToString();
                txtDonGia.Text = dgvDanhSach.Rows[vt].Cells["DonGia"].Value.ToString();
                nudSoLuong.Text = dgvDanhSach.Rows[vt].Cells["SoLuong"].Value.ToString();
                txtThanhTien.Text = dgvDanhSach.Rows[vt].Cells["ThanhTien"].Value.ToString();
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbHoaDonChiTiet"]);
        }
    }
}
