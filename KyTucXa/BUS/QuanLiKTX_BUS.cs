using QL_KyTucXa.DAO;
using QL_KyTucXa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KyTucXa.BUS
{
    internal class QuanLiKTX_BUS
    {
        public static void themphong(QuanLiKTX_DTO phong)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm phòng này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QuanLiKTX_DAO.ThemPhong(phong);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm phòng không thành công!");
            }
        }
        public static void capnhatphong(QuanLiKTX_DTO phong)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật phòng này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QuanLiKTX_DAO.CapNhatPhong(phong);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật phòng không thành công!");
            }
        }
        public static void Xoaphong(QuanLiKTX_DTO phong)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa phòng và tất cả sinh viên ở phòng này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QuanLiKTX_DAO.XoaPhong(phong);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa phòng không thành công!");
            }
        }
    }
}
