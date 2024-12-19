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
        public static void ThemPhong(DangKyPhongDTO dkp)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn đăng kí phòng này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DangKyPhongDAO.GhiDKPhong(dkp);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm đăng kí không thành công!");
            }
        }
    }
}
