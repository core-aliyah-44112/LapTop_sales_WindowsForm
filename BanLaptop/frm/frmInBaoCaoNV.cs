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
    public partial class frmInBaoCaoNV : Form
    {
        public frmInBaoCaoNV()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoNV_Load(object sender, EventArgs e)
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            List<NhanVien> listNhanVien = nvDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportNhanVien.rdlc";
            var reportDataSource = new ReportDataSource("DataSetNhanVien", listNhanVien);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
