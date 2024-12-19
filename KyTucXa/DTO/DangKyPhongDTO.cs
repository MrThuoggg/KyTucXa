using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KyTucXa.DTO
{
    internal class DangKyPhongDTO
    {
        private string  _MaDK;
        private string _MaSV;
        private string _HoTen;
        private string _MaPhong;
        private string _TenPhong;
        private string _NgayDK;
        private string _NgayBD;
        private string _NgayKT;

        public string MaDK {  get { return _MaDK; } set {  _MaDK = value; } }
        public string MaSV { get { return _MaSV; } set { _MaSV = value; } }
        public string HoTen { get { return _HoTen; } set { _HoTen = value; } }
        public string MaPhong { get { return _MaPhong; } set { _MaPhong = value; } }
        public string TenPhong { get { return _TenPhong;} set { _TenPhong = value;} }
        public string NgayDK { get { return _NgayDK;} set { _NgayDK = value;} }
        public string NgayBD { get { return _NgayBD; } set { _NgayBD = value; } }
        public string NgayKT { get { return _NgayKT; } set { _NgayKT = value; } }


        public DangKyPhongDTO() { 
            _MaDK = "";
            _MaSV = "";
            _HoTen = "";
            _MaPhong= "";
            _TenPhong= "";
            _NgayDK = "";
            _NgayBD = "";
            _NgayKT = "";
        }
        public DangKyPhongDTO(string MaDK, string MaSV, string HoTen, string MaPhong, string TenPhong, string NgayDK, string NgayBD, string NgayKT)
        {
            _MaDK = MaDK;
            _MaSV = MaSV;
            _HoTen = HoTen;
            _MaPhong= MaPhong;
            _TenPhong= TenPhong;
            _NgayDK = NgayDK;
            _NgayBD = NgayBD;
            _NgayKT = NgayKT;

        }
    }
}
