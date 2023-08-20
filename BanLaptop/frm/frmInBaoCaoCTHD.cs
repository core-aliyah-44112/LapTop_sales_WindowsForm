using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanLaptop.dao;
using BanLaptop.models;
using Microsoft.Reporting.WinForms;

namespace BanLaptop.frm
{
    public partial class frmInBaoCaoCTHD : Form
    {
        ChiTietHDDAO cthdDAO = new ChiTietHDDAO();
        SanPhamDAO spDAO = new SanPhamDAO();
        public frmInBaoCaoCTHD()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoCTHD_Load(object sender, EventArgs e)
        {
            //
            cbTenSP.ComboBox.DataSource = spDAO.getList();
            cbTenSP.ComboBox.DisplayMember = "TenSP";
            cbTenSP.ComboBox.ValueMember = "MaSP";
            cbTenSP.ComboBox.SelectedIndex = 0;
            //
            List<ChiTietHDSanPham> listChiTietHD = cthdDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportChiTietHD.rdlc";
            var reportDataSource = new ReportDataSource("DataSetChiTietHD", listChiTietHD);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string masp = cbTenSP.ComboBox.SelectedValue.ToString();
            List<ChiTietHDSanPham> listChiTietHD = cthdDAO.getList(masp);
            this.reportViewer1.LocalReport.ReportPath = "ReportChiTietHD.rdlc";
            var reportDataSource = new ReportDataSource("DataSetChiTietHD", listChiTietHD);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChiTietHDDAO cthdDAO = new ChiTietHDDAO();
            List<ChiTietHDSanPham> listChiTietHD = cthdDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportChiTietHD.rdlc";
            var reportDataSource = new ReportDataSource("DataSetChiTietHD", listChiTietHD);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
