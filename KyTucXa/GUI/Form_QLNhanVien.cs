using KyTucXa.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyTucXa.DAO;
using KyTucXa.GUI;

namespace KyTucXa.GUI
{
    public partial class Form_QLNhanVien : Form
    {
        public Form_QLNhanVien()
        {
            InitializeComponent();
        }
        public void ThongTinNhanVien()
        {
            DataTable dt = new DataTable();
            dt = QuanLiNhanVienDAO.ThongTinNhanVien();
            dgTT.DataSource = dt;
        }
        public void GioiTinh()
        {
            DataTable dt = new DataTable();
            dt = QuanLiNhanVienDAO.ThongTinNhanVien();
            cbGT.DataSource = dt;
            cbGT.DisplayMember = "GioiTinh";
            cbGT.ValueMember = "GioiTinh";
        }


        private void Form_QLNhanVien_Load(object sender, EventArgs e)
        {
            ThongTinNhanVien();
            GioiTinh();
        }

        private void dgTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dgTT.CurrentRow.Cells[0].Value.ToString();
            txthoten.Text = dgTT.CurrentRow.Cells[1].Value.ToString();
            txtcccd.Text = dgTT.CurrentRow.Cells[2].Value.ToString();
            dtNS.Value = DateTime.Parse(dgTT.CurrentRow.Cells[4].Value.ToString());
            txtemail.Text = dgTT.CurrentRow.Cells[5].Value.ToString();
            txtsdt.Text = dgTT.CurrentRow.Cells[6].Value.ToString();
            cbGT.SelectedValue = dgTT.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
