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
    public partial class frmNhaCC : Form
    {
        private NhaCCDAO nccDAO = new NhaCCDAO();
        private string AddOrEdit = null;
        public frmNhaCC()
        {
            InitializeComponent();
        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = nccDAO.getList();
            txtTongNhaCC.Text = nccDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
            txtMaNCC.Enabled = value;
            txtTenNCC.Enabled = value;
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
                if (string.IsNullOrEmpty(txtMaNCC.Text.Trim()))
                {
                    throw new Exception("Mã nhà cung cấp không được để trống");
                }
                if (string.IsNullOrEmpty(txtTenNCC.Text.Trim()))
                {
                    throw new Exception("Tên nhà cung cấp không được để trống");
                }
                //Lấy thông tin
                int mancc = int.Parse(txtMaNCC.Text.Trim());
                string tenncc = txtTenNCC.Text.Trim();

                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            NhaCC ncc = new NhaCC();
                            ncc.MaNCC = mancc;
                            ncc.TenNCC = tenncc;
                            //Thêm
                            nccDAO.Insert(ncc);
                            txtTongNhaCC.Text = nccDAO.getCount().ToString();
                            dgvDanhSach.DataSource = nccDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            NhaCC ncc = nccDAO.getRow(mancc);
                            ncc.MaNCC = mancc;
                            ncc.TenNCC = tenncc; ;
                            //Cập nhật
                            nccDAO.Update(ncc);
                            txtTongNhaCC.Text = nccDAO.getCount().ToString();
                            dgvDanhSach.DataSource = nccDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaNCC.Text.Trim()))
                {
                    throw new Exception("Mã nhà cung cấp không được để trống");
                }
                int mancc = int.Parse(txtMaNCC.Text.Trim());
                NhaCC ncc = nccDAO.getRow(mancc);
                nccDAO.Delete(ncc);
                txtTongNhaCC.Text = nccDAO.getCount().ToString();
                dgvDanhSach.DataSource = nccDAO.getList();
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
                txtMaNCC.Text = dgvDanhSach.Rows[vt].Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = dgvDanhSach.Rows[vt].Cells["TenNCC"].Value.ToString();
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbNhaCungCap"]);
        }
    }
}
