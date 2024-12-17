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
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        public static DataTable ThongNguoidung(string ten, string mk)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan = '" + ten + "' AND MatKhau = '" + mk + "'";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static string loaitk;
        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ThongNguoidung(txttaikhoan.Text, txtmatkhau.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu chưa đúng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                loaitk = dt.Rows[0]["MaLoai"].ToString();
                MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (loaitk == "ADMIN")
                {
                    Form_Menu frmQuanLi = new Form_Menu();
                    frmQuanLi.Show();
                }
                this.Hide();
            }
        }
    }
}
