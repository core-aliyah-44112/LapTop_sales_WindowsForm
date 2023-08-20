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
    public partial class frmInBaoCaoLSP : Form
    {
        public frmInBaoCaoLSP()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoLSP_Load(object sender, EventArgs e)
        {
            LoaiSPDAO lspDAO = new LoaiSPDAO();
            List<LoaiSP> listLoaiSP = lspDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportLoaiSP.rdlc";
            var reportDataSource = new ReportDataSource("DataSetLoaiSP", listLoaiSP);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
