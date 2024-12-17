using QL_KyTucXa.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyTucXa.DAO;
using KyTucXa.DTO;
using KyTucXa.GUI;
using KyTucXa.BUS;
namespace KyTucXa.DAO
{
    internal class ThongBaoDAO
    {
        public static DataTable ThongTinTB()
        {
            string sql = "SELECT * FROM ThongBao;";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThongTinMTBLonNhat()
        {
            string sql = "Select top 1 MaTB from ThongBao order by MaTB desc";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemThongBao(ThongBaoDTO tb)
        {
            string sql = "INSERT INTO ThongBao(MaTB, NoiDung, NgayTB, LoaiTB ) VALUES ('"+tb.matb+"', N'"+tb.noidung+"','"+tb.ngaytb+"',N'"+tb.loaitb+"')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void Capnhatthongbao(ThongBaoDTO tb)
        {
            string sql = "UPDATE ThongBao SET NoiDung = N'" + tb.noidung + "',NgayTB = N'" + tb.ngaytb + "',LoaiTB = N'" + tb.loaitb + "' WHERE MaTB = '" + tb.matb + "';";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaThongBao(ThongBaoDTO tb)
        {
            string sql = "delete from ThongBao where MaTB ='" + tb.matb+ "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
