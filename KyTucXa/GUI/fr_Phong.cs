using Microsoft.Reporting.WinForms;
using QL_KyTucXa.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyTucXa.GUI
{
    public partial class fr_Phong : Form
    {
        public fr_Phong()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void fr_Phong_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Phong";
            reportViewer1.LocalReport.ReportEmbeddedResource = "KyTucXa.rpPhong.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPhong", KetNoiCSDL.DocDuLieu(sql)));

            this.reportViewer1.RefreshReport();
        }
    }
}
