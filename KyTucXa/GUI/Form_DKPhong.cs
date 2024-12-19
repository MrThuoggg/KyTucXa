using KyTucXa.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyTucXa.GUI
{
    public partial class Form_DKPhong : Form
    {
        public Form_DKPhong()
        {
            InitializeComponent();
        }
        public void ThongTinDKPhong()
        {
            DataTable dt = new DataTable();
            dt = DangKyPhongDAO.ThongTinDKPhong();
            dGDKPhong.DataSource = dt;
        }
        private void Form_DKPhong_Load(object sender, EventArgs e)
        {
            ThongTinDKPhong();
        }

        private void dGDKPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txthoten.Text = dGDKPhong.CurrentRow.Cells["HoTen"].Value.ToString();
            txtTenPhong.Text = dGDKPhong.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtMaDK.Text = dGDKPhong.CurrentRow.Cells["MaDK"].Value.ToString();
            dtNDK.Value = DateTime.Parse(dGDKPhong.CurrentRow.Cells["NgayDK"].Value.ToString());
            dtNBD.Value = DateTime.Parse(dGDKPhong.CurrentRow.Cells["NgayBD"].Value.ToString());
            dtNgayKT.Value = DateTime.Parse(dGDKPhong.CurrentRow.Cells["NgayKT"].Value.ToString());

        }
    }
}
