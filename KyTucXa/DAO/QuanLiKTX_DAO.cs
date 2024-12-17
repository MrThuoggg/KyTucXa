using QL_KyTucXa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KyTucXa.DAO
{
    internal class QuanLiKTX_DAO
    {
        public static DataTable ThongTinPhong()
        {
            string sql = "SELECT * FROM Phong";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThongTinPhongLonNhat()
        {
            string sql = "Select top 1 MaPhong from Phong order by MaPhong desc";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThongTinTinhTrangPhong()
        {
            string sql = "SELECT distinct TinhTrang FROM Phong";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemPhong(QuanLiKTX_DTO phong)
        {
            string sql = "INSERT INTO Phong (MaPhong, TenPhong, TinhTrang, SoLuongSV, GiaPhong) VALUES ('"+phong.Maphong+"', N'"+phong.Tenphong+"', N'"+phong.Tinhtrang+"', "+phong.Soluongsv+", "+phong.Giaphong+")";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatPhong(QuanLiKTX_DTO phong)
        {
            string sql = "update Phong set TenPhong='"+phong.Tenphong+"', TinhTrang=N'"+phong.Tinhtrang+"', SoLuongSV='"+phong.Soluongsv+"', GiaPhong='"+phong.Giaphong+"' where MaPhong='" + phong.Maphong +"'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaPhong(QuanLiKTX_DTO phong)
        {
            string sql = "delete from SinhVien where MaPhong='"+phong.Maphong+"' ; delete from Phong where MaPhong='"+phong.Maphong+"'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
