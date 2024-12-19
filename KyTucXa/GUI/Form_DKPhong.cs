using KyTucXa.BUS;
using KyTucXa.DAO;
using KyTucXa.DTO;
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
            txtMaSV.Text=  dGDKPhong.CurrentRow.Cells["MaSV"].Value.ToString();
            txtMaPhong.Text = dGDKPhong.CurrentRow.Cells["MaPhong"].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DangKyPhongDAO.MaDKPhongLonNhat();
            string madk = dt.Rows[0][0].ToString();
            DataTable sv = new DataTable();
            sv = SinhVienDao.MaSinhVienLonNhat();
            string masv = sv.Rows[0][0].ToString();
            txtMaDK.Text = "DK" + (int.Parse(madk.Substring(madk.Length - 1)) + 1).ToString("000");
            txthoten.Text = "";
            txtTenPhong.Text = "Phòng ";
            dtNDK.Text = "";
            dtNDK.Text = "";
            dtNgayKT.Text = "";
            txtMaSV.Text = "SV" + (int.Parse(masv.Substring(masv.Length - 1)) + 1).ToString("000");
            txtMaPhong.Text = "P";
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            DangKyPhongDTO dkp = new DangKyPhongDTO();
            dkp.MaDK = txtMaDK.Text;
            dkp.MaSV = txtMaSV.Text;
            dkp.HoTen = txthoten.Text;
            dkp.MaPhong = txtMaPhong.Text;
            dkp.TenPhong = txtTenPhong.Text;
            dkp.NgayDK = dtNDK.Value.ToString("yyyy-MM-dd");
            dkp.NgayBD = dtNBD.Value.ToString("yyyy-MM-dd");
            dkp.NgayKT = dtNgayKT.Value.ToString("yyyy-MM-dd");
            DangKyPhong.ThemPhong(dkp);
            ThongTinDKPhong();
        }
    }
}
