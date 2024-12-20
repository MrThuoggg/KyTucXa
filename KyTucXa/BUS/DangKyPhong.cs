using KyTucXa.DAO;
using KyTucXa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyTucXa.BUS
{
    internal class DangKyPhong
    {
        public static void DangKy(DangKyPhongDTO dk)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn đăng ký phòng này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DangKyPhongDAO.DangKyPhong(dk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng ký phòng không thành công!");
            }
        }
        public static void CapNhatDK(DangKyPhongDTO dk)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DangKyPhongDAO.Capnhatdangky(dk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
        public static void XoaDangKy(DangKyPhongDTO dk)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa đăng ký phòng này không ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DangKyPhongDAO.XoaDangKyPhong(dk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa đăng ký phòng không thành công!");
            }
        }
    }
}
