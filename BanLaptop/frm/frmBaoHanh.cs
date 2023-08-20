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
    public partial class frmBaoHanh : Form
    {
        private BaoHanhDAO bhDAO = new BaoHanhDAO();
        private string AddOrEdit = null;
        public frmBaoHanh()
        {
            InitializeComponent();
        }
        private void frmBaoHanh_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = bhDAO.getList();
            txtTongBH.Text = bhDAO.getCount().ToString();
            OnOff(false);
        }
        private void OnOff(bool value)
        {
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
                if (string.IsNullOrEmpty(txtMaBH.Text.Trim()))
                {
                    throw new Exception("Mã bảo hành không được để trống");
                }
                if (string.IsNullOrEmpty(dtpNgayBH.Text.Trim()))
                {
                    throw new Exception("Ngày bảo hành không được để trống");
                }
                if (string.IsNullOrEmpty(dtpNgayHanCuoi.Text.Trim()))
                {
                    throw new Exception("Ngày hạn cuối không được để trống");
                }
                //lấy thông tin
                int mabh =int.Parse(txtMaBH.Text.Trim());
                DateTime ngaybh = Convert.ToDateTime(dtpNgayBH.Text.ToString());
                DateTime ngayhancuoi = Convert.ToDateTime(dtpNgayHanCuoi.Text.ToString());
                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            BaoHanh bh = new BaoHanh();
                            bh.MaBH = mabh;
                            bh.NgayBH = ngaybh;
                            bh.NgayHanCuoi = ngayhancuoi;
                            //Thêm
                            bhDAO.Insert(bh);
                            txtTongBH.Text = bhDAO.getCount().ToString();
                            dgvDanhSach.DataSource = bhDAO.getList();
                            MessageBox.Show("Thêm thành công", "Thông báo!");
                            break;
                        }
                    case "Edit":
                        {
                            BaoHanh bh = bhDAO.getRow(mabh);
                            bh.MaBH = mabh;
                            bh.NgayBH = ngaybh;
                            bh.NgayHanCuoi = ngayhancuoi;
                            //Cập nhật
                            bhDAO.Update(bh);
                            txtTongBH.Text = bhDAO.getCount().ToString();
                            dgvDanhSach.DataSource = bhDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaBH.Text.Trim()))
                {
                    throw new Exception("Mã bảo hành không được để trống");
                }
                int mabh = int.Parse(txtMaBH.Text.Trim());
                BaoHanh bh = bhDAO.getRow(mabh);
                bhDAO.Delete(bh);
                txtTongBH.Text = bhDAO.getCount().ToString();
                dgvDanhSach.DataSource = bhDAO.getList();
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
                txtMaBH.Text = dgvDanhSach.Rows[vt].Cells["MaBH"].Value.ToString();
                dtpNgayBH.Text = dgvDanhSach.Rows[vt].Cells["NgayBH"].Value.ToString();
                dtpNgayHanCuoi.Text = dgvDanhSach.Rows[vt].Cells["NgayHanCuoi"].Value.ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbBaoHanh"]);
        }
    }
}
