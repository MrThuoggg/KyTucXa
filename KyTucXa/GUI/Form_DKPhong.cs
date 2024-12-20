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
            txtMaSV.Text = Text = dGDKPhong.CurrentRow.Cells["MaSV"].Value.ToString();
            txtTenPhong.Text = dGDKPhong.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtMaPhong.Text = dGDKPhong.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtMaDK.Text = dGDKPhong.CurrentRow.Cells["MaDK"].Value.ToString();
            dtNDK.Value = DateTime.Parse(dGDKPhong.CurrentRow.Cells["NgayDK"].Value.ToString());
            dtNBD.Value = DateTime.Parse(dGDKPhong.CurrentRow.Cells["NgayBD"].Value.ToString());
            dtNgayKT.Value = DateTime.Parse(dGDKPhong.CurrentRow.Cells["NgayKT"].Value.ToString());
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DangKyPhongDAO.MaDKPhongLonNhat();
            string madk = dt.Rows[0][0].ToString();
            txtMaDK.Text = "DK" + (int.Parse(madk.Substring(madk.Length - 1)) + 1).ToString("000");
            txthoten.Text = "";
            txtTenPhong.Text = "";
            
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            DangKyPhongDTO dk = new DangKyPhongDTO
            {
                madk = txtMaDK.Text,
                masv = txthoten.Text,
                maphong = txtMaPhong.Text,
                ngaybd = dtNBD.Value.ToString("yyyy-MM-dd"),
                ngaydk = dtNDK.Value.ToString("yyyy-MM-dd"),
                ngaykt = dtNgayKT.Value.ToString("yyyy-MM-dd")
            };
            DangKyPhong.DangKy(dk);
            ThongTinDKPhong();
        }


        private void btCapNhat_Click(object sender, EventArgs e)
        {
            DangKyPhongDTO dk = new DangKyPhongDTO();
            dk.madk = txtMaDK.Text;
            dk.masv = txthoten.Text;
            dk.maphong = txtMaPhong.Text;
            dk.maphong = txtTenPhong.Text;
            dk.ngaybd = dtNBD.Value.ToString("yyyy-MM-dd");
            dk.ngaydk = dtNDK.Value.ToString("yyyy-MM-dd");
            dk.ngaykt = dtNgayKT.Value.ToString("yyyy-MM-dd");
            DangKyPhong.CapNhatDK(dk);
            ThongTinDKPhong();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DangKyPhongDTO dk = new DangKyPhongDTO();
            dk.madk = txtMaDK.Text;
            DangKyPhong.XoaDangKy(dk);
            ThongTinDKPhong();
        }
    }
}
