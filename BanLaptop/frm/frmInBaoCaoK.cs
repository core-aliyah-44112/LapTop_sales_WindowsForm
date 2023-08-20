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
    public partial class frmInBaoCaoK : Form
    {
        public frmInBaoCaoK()
        {
            InitializeComponent();
        }

        private void frmInBaoCaoK_Load(object sender, EventArgs e)
        {
            KhachDAO kDAO = new KhachDAO();
            List<Khach> listKhach = kDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "ReportKhach.rdlc";
            var reportDataSource = new ReportDataSource("DataSetKhach", listKhach);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
