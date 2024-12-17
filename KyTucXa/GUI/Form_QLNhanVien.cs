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
using KyTucXa.BUS;
using KyTucXa.DTO;
using QL_KyTucXa.BUS;
using QL_KyTucXa.DTO;

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

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QuanLiNhanVienDAO.ThongTinNhanVienLonNhat();
            string manv = dt.Rows[0][0].ToString();
            txtmanv.Text = "NV" + (int.Parse(manv.Substring(manv.Length - 1)) + 1).ToString("000");
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            QuanLiNhanVienDTO nv = new QuanLiNhanVienDTO();
            nv.manv = txtmanv.Text;
            nv.hoten = txthoten.Text;
            nv.cccd = txtcccd.Text;
            nv.ns = dtNS.Value.ToString("yyyy-MM-dd");
            nv.gt = cbGT.SelectedValue.ToString();
            nv.email = txtemail.Text;
            nv.sdt = txtsdt.Text;   
            QLNhanVienBUS.ThemNV(nv);
            ThongTinNhanVien();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            QuanLiNhanVienDTO nv = new QuanLiNhanVienDTO();
            nv.manv = txtmanv.Text;
            nv.hoten = txthoten.Text;
            nv.cccd = txtcccd.Text;
            nv.ns = dtNS.Value.ToString("yyyy-MM-dd");
            nv.gt = cbGT.SelectedValue.ToString();
            nv.email = txtemail.Text;
            nv.sdt = txtsdt.Text;
            QLNhanVienBUS.CapNhatNhanVien(nv);
            ThongTinNhanVien();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            QuanLiNhanVienDTO nv = new QuanLiNhanVienDTO();
            nv.manv = txtmanv.Text;
            QLNhanVienBUS.XoaNhanVien(nv);
            ThongTinNhanVien();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.ShowDialog();

            this.Close();
        }
    }
 }

