using KyTucXa.DAO;
using KyTucXa.DTO;
using QL_KyTucXa.DAO;
using QL_KyTucXa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyTucXa.BUS
{
    internal class QLNhanVienBUS
    {
        public static void ThemNV(QuanLiNhanVienDTO nv)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm nhân viên  này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QuanLiNhanVienDAO.ThemNhanVien(nv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm nhân viên không thành công!");
            }
        }
        public static void CapNhatNhanVien(QuanLiNhanVienDTO nv)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật nhân viên  này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QuanLiNhanVienDAO.CapNhatNhanVien(nv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật nhân viên  không thành công!");
            }
        }
        public static void XoaNhanVien(QuanLiNhanVienDTO nv)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QuanLiNhanVienDAO.XoaNhanVien(nv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa nhân viên  không thành công!");
            }
        }
    }
}
