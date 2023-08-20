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
    public partial class frmInBaoCaoHD : Form
    {
        HoaDonDAO hdDAO = new HoaDonDAO();
        KhachDAO kDAO = new KhachDAO();
        public frmInBaoCaoHD()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoHD_Load(object sender, EventArgs e)
        {
            //
            cbTenKhach.ComboBox.DataSource = kDAO.getList();
            cbTenKhach.ComboBox.DisplayMember = "TenKhach";
            cbTenKhach.ComboBox.ValueMember = "MaKhach";
            cbTenKhach.ComboBox.SelectedIndex = 0;
            //
            List<HoaDonKhach> listHoaDon = hdDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportHoaDon.rdlc";
            var reportDataSource = new ReportDataSource("DataSetHoaDonKhach", listHoaDon);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int makhach = int.Parse(cbTenKhach.ComboBox.SelectedValue.ToString());
            List<HoaDonKhach> listHoaDon = hdDAO.getList(makhach);
            this.reportViewer1.LocalReport.ReportPath = "ReportHoaDon.rdlc";
            var reportDataSource = new ReportDataSource("DataSetHoaDonKhach", listHoaDon);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HoaDonDAO hdDAO = new HoaDonDAO();
            List<HoaDonKhach> listHoaDon = hdDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportHoaDon.rdlc";
            var reportDataSource = new ReportDataSource("DataSetHoaDonKhach", listHoaDon);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
