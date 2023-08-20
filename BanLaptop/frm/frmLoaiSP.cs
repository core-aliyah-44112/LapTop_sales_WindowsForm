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
    public partial class frmLoaiSP : Form
    {
        private SanPhamDAO spDAO = new SanPhamDAO();
        private LoaiSPDAO lspDAO = new LoaiSPDAO();
        private string AddOrEdit = null;
        private int malsp;
        public frmLoaiSP()
        {
            InitializeComponent();
        }
        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = lspDAO.getList();
            txtTongLSP.Text = lspDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
            txtMaLoai.Enabled = value;
            txtTenLoai.Enabled = value;
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
                if (string.IsNullOrEmpty(txtMaLoai.Text.Trim()))
                {
                    throw new Exception("Mã loại không được để trống");
                }
                if (string.IsNullOrEmpty(txtTenLoai.Text.Trim()))
                {
                    throw new Exception("Tên loại không được để trống");
                }
                //lấy thông tin
                string tenloai = txtTenLoai.Text.Trim();
                string chitiet = txtChiTiet.Text.Trim();
                //Do khóa tăng tự động
                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            LoaiSP lsp = new LoaiSP();
                            lsp.TenLoai = tenloai;
                            lsp.ChiTiet = chitiet;
                            //Thêm
                            lspDAO.Insert(lsp);
                            txtTongLSP.Text = lspDAO.getCount().ToString();
                            dgvDanhSach.DataSource = lspDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            LoaiSP lsp = lspDAO.getRow(malsp);
                            lsp.TenLoai = tenloai;
                            lsp.ChiTiet = chitiet;
                            //Cập nhật
                            lspDAO.Update(lsp);
                            txtTongLSP.Text = lspDAO.getCount().ToString();
                            dgvDanhSach.DataSource = lspDAO.getList();
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
            LoaiSP lsp = lspDAO.getRow(malsp);
            lspDAO.Delete(lsp);
            txtTongLSP.Text = lspDAO.getCount().ToString();
            dgvDanhSach.DataSource = lspDAO.getList();
            MessageBox.Show("Xóa thành công", "Thông báo!");
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                malsp = int.Parse(dgvDanhSach.Rows[vt].Cells["MaLoai"].Value.ToString());
                //Đưa dữ liệu lên lưới
                txtMaLoai.Text = dgvDanhSach.Rows[vt].Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = dgvDanhSach.Rows[vt].Cells["TenLoai"].Value.ToString();
                txtChiTiet.Text = dgvDanhSach.Rows[vt].Cells["ChiTiet"].Value.ToString();
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbLoaiSP"]);
        }
    }
}
