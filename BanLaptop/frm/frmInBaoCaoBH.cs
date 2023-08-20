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
    public partial class frmInBaoCaoBH : Form
    {
        public frmInBaoCaoBH()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoBH_Load(object sender, EventArgs e)
        {
            BaoHanhDAO bhDAO = new BaoHanhDAO();
            List<BaoHanh> listBaoHanh = bhDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportBaoHanh.rdlc";
            var reportDataSource = new ReportDataSource("DataSetBaoHanh", listBaoHanh);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
