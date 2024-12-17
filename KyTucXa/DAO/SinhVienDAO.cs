using KyTucXa.DTO;
using QL_KyTucXa.DAO;
using QL_KyTucXa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KyTucXa.DAO
{
    internal class SinhVienDao
    {
        public static DataTable ThongTinSinhVien()
        {
            string sql = "select * from SinhVien";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThongTinPhong()
        {
            string sql = "SELECT *FROM phong";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThongTinChiTietSinhVien()
        {
            string sql = " SELECT sv.MaSV AS [Mã Sinh Viên],sv.HoTen AS [Họ Tên],sv.NgaySinh AS [Ngày Sinh],sv.GioiTinh AS [Giới Tính],sv.Cccd AS [CCCD],sv.Sdt AS [Số Điện Thoại],sv.DiaChi AS [Địa Chỉ],sv.NganhHoc AS [Ngành Học],sv.Email AS [Email],sv.MaPhong AS [Mã Phòng],p.TenPhong AS [Tên Phòng],p.TinhTrang AS [Tình Trạng],p.SoLuongSV AS [Số Lượng Sinh Viên],p.GiaPhong AS [Giá Phòng]FROM SinhVien sv LEFT JOIN Phong p ON sv.MaPhong = p.MaPhong";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemSinhVien(SinhVienDTO sinhVien)
        {
            string sql = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Cccd, Sdt, DiaChi, NganhHoc, Email, MaPhong) VALUES('" + sinhVien.MaSV + "', N'" + sinhVien.Hoten + "', '" + sinhVien.Ngaysinh + "', N'" + sinhVien.GioiTinh + "', '" + sinhVien.Cccd + "','" + sinhVien.Sdt + "', N'" + sinhVien.Diachi + "', N'" + sinhVien.Nganhhoc + "', '" + sinhVien.Email + "', '" + sinhVien.MaPhong + "')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void Xoasinhvien(SinhVienDTO sinhVien)
        {
            string sql = "delete from SinhVien where MaSV='" + sinhVien.MaSV + "' ; delete from SINHVIEN where MaSV='" + sinhVien.MaSV + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void Capnhatsinhvien(SinhVienDTO sinhVien)
        {
            string sql = "UPDATE SinhVien SET HoTen = N'" + sinhVien.Hoten + "',NgaySinh = '" + sinhVien.Ngaysinh + "',GioiTinh = N'" + sinhVien.GioiTinh + "',Cccd = '" + sinhVien.Cccd + "',Sdt = '" + sinhVien.Sdt + "',DiaChi = N'" + sinhVien.Diachi + "',NganhHoc = N'" + sinhVien.Nganhhoc + "',Email = '" + sinhVien.Email + "',MaPhong = '" + sinhVien.MaPhong + "'WHERE MaSV = '" + sinhVien.MaSV + "';";

            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static DataTable MaSinhVienLonNhat()
        {
            string sql = "Select top 1 MaSV from SinhVien order by MaSV desc";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}



       
    


