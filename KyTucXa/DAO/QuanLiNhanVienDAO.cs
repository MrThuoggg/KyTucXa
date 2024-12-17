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
using QL_KyTucXa.DAO;

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
    }
}
