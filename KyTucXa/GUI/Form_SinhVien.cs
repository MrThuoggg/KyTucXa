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
    public partial class Form_SinhVien : Form
    {
        public Form_SinhVien()
        {
            InitializeComponent();
        }
        public void DanhSachSinhVien()
        {
            DataTable dtsv = new DataTable();
            dtsv = SinhVienDao.ThongTinSinhVien();
            dgdanhsach.DataSource = dtsv;
        }
        public void DanhSachNganhHoc()
        {
            DataTable dt = new DataTable();
            dt = SinhVienDao.ThongTinSinhVien();
            cbnganhhoc.DataSource = dt;
            cbnganhhoc.DisplayMember = "NganhHoc";
            cbnganhhoc.ValueMember = "NganhHoc";
        }
        public void DanhSachGioiTinh()
        {
            DataTable dt = new DataTable();
            dt = SinhVienDao.ThongTinSinhVien();
            cbgioitinh.DataSource = dt;
            cbgioitinh.DisplayMember = "GioiTinh";
            cbgioitinh.ValueMember = "GioiTinh";
        }
        private void Form_SinhVien_Load(object sender, EventArgs e)
        {
            DanhSachSinhVien();
            DanhSachNganhHoc();
            DanhSachGioiTinh();
        }

        private void dgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasinhvien.Text = dgdanhsach.CurrentRow.Cells[0].Value.ToString();
            txthoten.Text = dgdanhsach.CurrentRow.Cells[1].Value.ToString();

            cbgioitinh.SelectedValue = dgdanhsach.CurrentRow.Cells[3].Value.ToString();
            txtmaphong.Text = dgdanhsach.CurrentRow.Cells[9].Value.ToString();

            cbnganhhoc.SelectedValue = dgdanhsach.CurrentRow.Cells[7].Value.ToString();
            dtngaysinh.Value = DateTime.Parse(dgdanhsach.CurrentRow.Cells[2].Value.ToString());

            txtcccd.Text = dgdanhsach.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = dgdanhsach.CurrentRow.Cells[5].Value.ToString();

            txtdiachi.Text = dgdanhsach.CurrentRow.Cells[6].Value.ToString();
            txtemail.Text = dgdanhsach.CurrentRow.Cells[8].Value.ToString();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            SinhVienDTO dt = new SinhVienDTO();
            dt.MaSV = txtmasinhvien.Text;
            // viết hàm bus 
            SinhVienBUS.XoaSinhVien(dt);
            DanhSachSinhVien();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SinhVienDao.MaSinhVienLonNhat();
            string manv = dt.Rows[0][0].ToString();
            txtmasinhvien.Text = "SV" + (int.Parse(manv.Substring(manv.Length - 1)) + 1).ToString("000");
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            SinhVienDTO dt = new SinhVienDTO();
            dt.MaSV = txtmasinhvien.Text;
            dt.Hoten = txthoten.Text;
            dt.GioiTinh = cbgioitinh.SelectedValue.ToString();
            dt.MaPhong = txtmaphong.Text;
            dt.Nganhhoc = cbnganhhoc.SelectedValue.ToString();
            dt.Ngaysinh = dtngaysinh.Value.ToString("yyyy-MM-dd");
            dt.Cccd = txtcccd.Text;
            dt.Sdt = txtsdt.Text;
            dt.Diachi = txtdiachi.Text;
            dt.Email = txtemail.Text;

            //thiếu BUS
            SinhVienBUS.ThemSV(dt);
            DanhSachSinhVien();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            SinhVienDTO dt = new SinhVienDTO();
            dt.MaSV = txtmasinhvien.Text;
            dt.Hoten = txthoten.Text;
            dt.GioiTinh = cbgioitinh.SelectedValue.ToString();
            dt.MaPhong = txtmaphong.Text;
            dt.Nganhhoc = cbnganhhoc.SelectedValue.ToString();
            dt.Ngaysinh = dtngaysinh.Value.ToString("yyyy-MM-dd");
            dt.Cccd = txtcccd.Text;
            dt.Sdt = txtsdt.Text;
            dt.Diachi = txtdiachi.Text;
            dt.Email = txtemail.Text;

            //thiếu BUS
            SinhVienBUS.CapNhatSinhVien(dt);
            DanhSachSinhVien();

        }
    }
}
