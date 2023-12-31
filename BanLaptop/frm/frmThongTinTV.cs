﻿using System;
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
    public partial class frmThongTinTV : Form
    {
        public frmThongTinTV()
        {
            InitializeComponent();
        }
        private void frmThongTinTV_Load(object sender, EventArgs e)
        {
            ThanhVien thanhVien = frmMain.thanhvien;
            txtTenDangNhap.Text = thanhVien.TenDangNhap;
            txtMatKhau.Text = thanhVien.MatKhau;
            txtHoTen.Text = thanhVien.HoTen;
            txtEmail.Text = thanhVien.Email;
            txtDienThoai.Text = thanhVien.DienThoai;
            cbQuyen.Text = thanhVien.Quyen;
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbThongTinThanhVien"]);
            //Tạo Tabpage
            TabPage tab = new TabPage();
            tab.Text = "Đổi Mật Khẩu";
            tab.Name = "tbDoiMatKhau";
            tab.ImageIndex = 10;
            //Tạo form
            Form frm = new frmDoiMatKhau();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            //kiểm tra về add 
            if (!ExistTabPage(frmMain.tabControl, "tbDoiMatKhau"))
            {
                frmMain.tabControl.TabPages.Add(tab);
            }
            frmMain.tabControl.SelectedTab = frmMain.tabControl.TabPages["tbDoiMatKhau"];
        }
        private bool ExistTabPage(TabControl control, string tabPageName)
        {
            bool check = false;
            for (int i = 0; i < control.TabPages.Count; i++)
            {
                if (control.TabPages[i].Name == tabPageName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbThongTinThanhVien"]);
        }
    }
}
