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
    public partial class frmInBaoCaoNCC : Form
    {
        public frmInBaoCaoNCC()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoNCC_Load(object sender, EventArgs e)
        {
            NhaCCDAO nccDAO = new NhaCCDAO();
            List<NhaCC> listNhaCC = nccDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportNhaCC.rdlc";
            var reportDataSource = new ReportDataSource("DataSetNhaCC", listNhaCC);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
