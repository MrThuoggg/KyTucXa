using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyTucXa.GUI;
using System.Windows.Forms;
using System.Data;
using KyTucXa.DAO;
using KyTucXa.DTO;
using KyTucXa.GUI;
using KyTucXa.BUS;
using QL_KyTucXa.DAO;
using QL_KyTucXa.DTO;

namespace KyTucXa.DAO
{
    internal class QuanLiNhanVienDAO
    {
        public static DataTable ThongTinNhanVien()
        {
            string sql = "SELECT * FROM NhanVien;";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemNhanVien(QuanLiNhanVienDTO nv)
        {
            string sql = "INSERT INTO NhanVien (MaNV, HoTen, Cccd, GioiTinh, NgaySinh, Email, Sdt) VALUES ('"+nv.manv+"', N'"+nv.hoten+"', '"+nv.cccd +"', N'"+nv.gt +"', '"+nv.ns +"', '"+nv.email +"', '"+nv.sdt +"')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static DataTable ThongTinNhanVienLonNhat()
        {
            string sql = "Select top 1 MaNV from NhanVien order by MaNV desc";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void CapNhatNhanVien(QuanLiNhanVienDTO nv)
        {
            string sql = "update NhanVien set HoTen= N'"+nv.hoten+"', Cccd ='"+nv.cccd+"', GioiTinh = N'"+nv.gt+"', NgaySinh = '"+nv.ns+"', Email = '"+nv.email+"', Sdt = '"+nv.sdt+"' where MaNV = '"+nv.manv+"';";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaNhanVien(QuanLiNhanVienDTO nv )
        {
            string sql = "delete from NhanVien where MaNV ='" + nv.manv + "';";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
