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
        public static void DangKyPhong(DangKyPhongDTO dk)
        {
            string sql = "INSERT INTO DangKyPhong (MaDK, MaSV, HoTen, MaPhong, TenPhong, NgayDK, NgayBD, NgayKT) VALUES ('"+dk.madk+"', '"+dk.masv+"', N'"+dk.hoten+"','"+dk.maphong+"',  N'"+dk.tenphong+"','"+dk.ngaydk+"', '"+dk.ngaybd+"', '"+dk.ngaykt+"');";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void Capnhatdangky(DangKyPhongDTO dk)
        {
            string sql = "UPDATE DangKyPhong SET MaSV = N'" + dk.masv + "',NgayDK = N'" + dk.ngaydk + "',NgayBD = N'" + dk.ngaybd + "',NgayKT = N'" + dk.ngaykt + "',MaPhong = N'" + dk.maphong + "' WHERE MaDK = '" + dk.madk + "';";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaDangKyPhong(DangKyPhongDTO dk)
        {
            string sql = "delete from DangKyPhong where MaDK ='" + dk.madk + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
