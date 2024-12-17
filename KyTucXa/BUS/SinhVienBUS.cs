using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyTucXa.DAO;
using KyTucXa.DTO;
namespace KyTucXa.BUS
{
    internal class SinhVienBUS
    {
        public static void ThemSV(SinhVienDTO sinhVien)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm sinh viên  này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SinhVienDao.ThemSinhVien(sinhVien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sinh viên không thành công!");
            }
        }
        public static void CapNhatSinhVien(SinhVienDTO sinhVien)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật sinh viên  này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SinhVienDao.Capnhatsinhvien(sinhVien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật sinh viên  không thành công!");
            }
        }
        public static void XoaSinhVien(SinhVienDTO sinhVien)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SinhVienDao.Xoasinhvien(sinhVien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa sinh viên  không thành công!");
            }
        }
    }
}
