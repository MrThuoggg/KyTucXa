using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyTucXa.DAO;
using KyTucXa.DTO;
using KyTucXa.GUI;
namespace KyTucXa.BUS
{
    internal class ThongBaoBUS
    {
        public static void ThemTB(ThongBaoDTO tb)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm thông báo  này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ThongBaoDAO.ThemThongBao(tb);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông báo không thành công!");
            }
        }
        public static void CapNhatTB(ThongBaoDTO tb)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật thông báo  này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ThongBaoDAO.Capnhatthongbao(tb);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thông báo không thành công!");
            }
        }
        public static void XoaThongBao(ThongBaoDTO tb)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa thông báo này không ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ThongBaoDAO.XoaThongBao(tb);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thông báo không thành công!");
            }
        }
    }
}
