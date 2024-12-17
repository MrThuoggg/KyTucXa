using KyTucXa.BUS;
using KyTucXa.DAO;
using KyTucXa.DTO;
using QL_KyTucXa.DAO;
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
    public partial class Form_ThongBao : Form
    {
        public Form_ThongBao()
        {
            InitializeComponent();
        }
        public void ThongTinTB()
        {
            DataTable dt = new DataTable();
            dt = ThongBaoDAO.ThongTinTB();
            dgTB.DataSource = dt;
        }
        public void DanhSachLoaiTB()
        {
            DataTable dt = new DataTable();
            dt = ThongBaoDAO.ThongTinTB();
            var distinctRows = dt.AsEnumerable()
                        .GroupBy(row => row.Field<string>("LoaiTB"))
                        .Select(g => g.First())
                        .CopyToDataTable();

            // Gán dữ liệu đã loại bỏ trùng vào ComboBox
            cbLoaiTB.DataSource = distinctRows;
            cbLoaiTB.DisplayMember = "LoaiTB";
            cbLoaiTB.ValueMember = "LoaiTB";
        }
        private void Form_ThongBao_Load(object sender, EventArgs e)
        {
            ThongTinTB();
            DanhSachLoaiTB();
        }

        private void dgTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTB.Text = dgTB.CurrentRow.Cells[0].Value.ToString();
            txtnoidung.Text = dgTB.CurrentRow.Cells[1].Value.ToString();
            cbLoaiTB.Text = dgTB.CurrentRow.Cells[3].Value.ToString();
            dtNgayTB.Value = DateTime.Parse(dgTB.CurrentRow.Cells[2].Value.ToString());
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ThongBaoDAO.ThongTinMTBLonNhat();
            string matb = dt.Rows[0][0].ToString();
            txtMaTB.Text = "TB" + (int.Parse(matb.Substring(matb.Length - 1)) + 1).ToString("000");
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            ThongBaoDTO tb = new ThongBaoDTO();
            tb.matb = txtMaTB.Text;
            tb.noidung = txtnoidung.Text;
            tb.ngaytb = dtNgayTB.Value.ToString("yyyy-MM-dd");
            tb.loaitb = cbLoaiTB.SelectedValue.ToString();
            ThongBaoBUS.ThemTB(tb);
            ThongTinTB();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            ThongBaoDTO tb = new ThongBaoDTO();
            tb.matb = txtMaTB.Text;
            tb.noidung = txtnoidung.Text;
            tb.ngaytb = dtNgayTB.Value.ToString("yyyy-MM-dd");
            tb.loaitb = cbLoaiTB.SelectedValue.ToString();
            ThongBaoBUS.CapNhatTB(tb);
            ThongTinTB();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            ThongBaoDTO tb = new ThongBaoDTO();
            tb.matb = txtMaTB.Text;
            ThongBaoBUS.XoaThongBao(tb);
            ThongTinTB();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.ShowDialog();

            this.Close();
        }
    }
}
