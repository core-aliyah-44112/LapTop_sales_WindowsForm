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
    public partial class frmInBaoCaoTV : Form
    {
        public frmInBaoCaoTV()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoTV_Load(object sender, EventArgs e)
        {
            ThanhVienDAO tvDAO = new ThanhVienDAO();
            List<ThanhVien> listThanhVien = tvDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportThanhVien.rdlc";
            var reportDataSource = new ReportDataSource("DataSetThanhVien", listThanhVien);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
