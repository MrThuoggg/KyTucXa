using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyTucXa.BUS;
using KyTucXa.DTO;
using KyTucXa.GUI;
using QL_KyTucXa.DAO;


namespace KyTucXa.DAO
{
    internal class DangKyPhongDAO
    {
        public static DataTable ThongTinDKPhong()
        {
            string sql = "Select MaDK, sv.MaSV,HoTen,p.MaPhong,TenPhong, NgayDK,NgayBD,NgayKT From Phong p, SinhVien sv, DangKyPhong dkp where sv.MaSV = dkp.MaSV and p.MaPhong = dkp.MaPhong";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
