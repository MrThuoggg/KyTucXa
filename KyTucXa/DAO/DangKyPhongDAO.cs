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
            string sql = "SELECT * FROM DangKyPhong;";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaDKPhongLonNhat()
        {
            string sql = "Select top 1 MaDK from DangKyPhong order by MaDK desc";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemDKPhong(DangKyPhongDTO dkp)
        {
            string sql = "INSERT INTO DangKyPhong (MaDK, MaSV,HoTen, MaPhong,TenPhong, NgayDK, NgayBD, NgayKT) VALUES ('"+dkp.MaDK+"', '"+dkp.MaSV+"', N'"+dkp.HoTen+"', '"+dkp.MaPhong+"', N'"+dkp.TenPhong+"', '"+dkp.NgayDK+"', '"+dkp.NgayBD+"', '"+dkp.NgayKT+"');";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
