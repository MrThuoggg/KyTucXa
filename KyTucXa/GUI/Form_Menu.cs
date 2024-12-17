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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdangkyphong_Click(object sender, EventArgs e)
        {
            Form_DKPhong form_DKPhong = new Form_DKPhong();
            form_DKPhong.Show();
        }

        private void btquanlynhanvien_Click(object sender, EventArgs e)
        {
            Form_QLNhanVien form_QLNhanVien = new Form_QLNhanVien();
            form_QLNhanVien.Show();
        }

        private void btquanlyphong_Click(object sender, EventArgs e)
        {
            Form_QLPhong form_QLPhong = new Form_QLPhong();
            form_QLPhong.Show();
        }

        private void qlsinhvien_Click(object sender, EventArgs e)
        {
            Form_QLSinhVien form_QLSinhVien = new Form_QLSinhVien();
            form_QLSinhVien.Show();
        }

        private void btthongbao_Click(object sender, EventArgs e)
        {
            Form_ThongBao form_ThongBao = new Form_ThongBao();
            form_ThongBao.Show();
        }

        private void btthongke_Click(object sender, EventArgs e)
        {
            Form_BaoCao form_BaoCao = new Form_BaoCao();
            form_BaoCao.Show();
        }
    }
}
