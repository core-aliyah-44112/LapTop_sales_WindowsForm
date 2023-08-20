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
    public partial class frmSanPham : Form
    {
        private SanPhamDAO spDAO = new SanPhamDAO();
        private LoaiSPDAO lspDAO = new LoaiSPDAO();
        private string AddOrEdit = null;
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = spDAO.getList();
            cbTenLoai.DataSource = lspDAO.getList();
            cbTenLoai.DisplayMember = "TenLoai";
            cbTenLoai.ValueMember = "MaLoai";
            txtTongSP.Text = spDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
            txtMaSP.Enabled = value;
            txtMaNCC.Enabled = value;
            cbTenSP.Enabled = value;
            txtDonGiaNhap.Enabled = value;
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
                if (string.IsNullOrEmpty(txtMaSP.Text.Trim()))
                {
                    throw new Exception("Mã sản phẩm không được để trống");
                }
                if (string.IsNullOrEmpty(cbTenLoai.Text.Trim()))
                {
                    throw new Exception("Tên loại không được để trống");
                }
                if (string.IsNullOrEmpty(txtDonGiaNhap.Text.Trim()))
                {
                    throw new Exception("Xin vui lòng nhập đơn giá");
                }
                //lấy thông tin
                string masp = txtMaSP.Text.Trim();
                string tensp = cbTenSP.Text;
                int mancc = int.Parse(txtMaNCC.Text.ToString());
                int maloai = int.Parse(cbTenLoai.SelectedValue.ToString());
                int soluong = int.Parse(nudSoLuong.Text.Trim());
                string dongianhap = txtDonGiaNhap.Text.Trim();
                string ghichu = txtGhiChu.Text.Trim();

                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            SanPham sp = new SanPham();
                            sp.MaSP = masp;
                            sp.TenSP = tensp;
                            sp.MaLoai = maloai;
                            sp.MaNCC = mancc;
                            sp.SoLuong = soluong;
                            sp.DonGiaNhap = dongianhap;
                            sp.GhiChu = ghichu;
                            //Thêm
                            spDAO.Insert(sp);
                            txtTongSP.Text = spDAO.getCount().ToString();
                            dgvDanhSach.DataSource = spDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            SanPham sp = spDAO.getRow(masp);
                            sp.MaSP = masp;
                            sp.TenSP = tensp;
                            sp.MaLoai = maloai;
                            sp.MaNCC = mancc;
                            sp.SoLuong = soluong;
                            sp.DonGiaNhap = dongianhap;
                            sp.GhiChu = ghichu;
                            //Cập nhật
                            spDAO.Update(sp);
                            txtTongSP.Text = spDAO.getCount().ToString();
                            dgvDanhSach.DataSource = spDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaSP.Text.Trim()))
                {
                    throw new Exception("Mã sản phẩm không được để trống");
                }
                if (string.IsNullOrEmpty(cbTenSP.Text.Trim()))
                {
                    throw new Exception("Tên sản phẩm không được để trống");
                }
                string masp = txtMaSP.Text.Trim();
                SanPham sp = spDAO.getRow(masp);
                spDAO.Delete(sp);
                txtTongSP.Text = spDAO.getCount().ToString();
                dgvDanhSach.DataSource = spDAO.getList();
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
                txtMaSP.Text = dgvDanhSach.Rows[vt].Cells["MaSP"].Value.ToString();
                cbTenSP.Text = dgvDanhSach.Rows[vt].Cells["TenSP"].Value.ToString();
                cbTenLoai.Text = dgvDanhSach.Rows[vt].Cells["TenLoai"].Value.ToString();
                txtMaNCC.Text = dgvDanhSach.Rows[vt].Cells["MaNCC"].Value.ToString();
                nudSoLuong.Text = dgvDanhSach.Rows[vt].Cells["SoLuong"].Value.ToString();
                txtDonGiaNhap.Text = dgvDanhSach.Rows[vt].Cells["DonGiaNhap"].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.Rows[vt].Cells["GhiChu"].Value.ToString();
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbSanPham"]);
        }
    }
}
