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
    public partial class frmInBaoCaoSP : Form
    {
        SanPhamDAO spDAO = new SanPhamDAO();
        LoaiSPDAO lspDAO = new LoaiSPDAO();
        public frmInBaoCaoSP()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoSP_Load(object sender, EventArgs e)
        {
            //
            cbTenLoai.ComboBox.DataSource = lspDAO.getList();
            cbTenLoai.ComboBox.DisplayMember = "TenLoai";
            cbTenLoai.ComboBox.ValueMember = "MaLoai";
            cbTenLoai.ComboBox.SelectedIndex = 0;
            //
            List<SanPhamLoaiSP> listSanPham = spDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportSanPham.rdlc";
            var reportDataSource = new ReportDataSource("DataSetSanPham", listSanPham);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int maloai = int.Parse(cbTenLoai.ComboBox.SelectedValue.ToString());
            List<SanPhamLoaiSP> listSanPham = spDAO.getList(maloai);
            this.reportViewer1.LocalReport.ReportPath = "ReportSanPham.rdlc";
            var reportDataSource = new ReportDataSource("DataSetSanPham", listSanPham);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SanPhamDAO spDAO = new SanPhamDAO();
            List<SanPhamLoaiSP> listSanPham = spDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportSanPham.rdlc";
            var reportDataSource = new ReportDataSource("DataSetSanPham", listSanPham);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
