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
        private string _madk;
        private string _masv;
        private string _maphong;
        private string _ngaydk;
        private string _ngaybd;
        private string _ngaykt;
        private string _hoten;
        private string _tenphong;

        // Các thuộc tính tương ứng
        public string madk
        {
            get { return _madk; }
            set { _madk = value; }
        }
        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        public string tenphong
        {
            get { return _tenphong; }
            set { _tenphong = value; }
        }

        public string masv
        {
            get { return _masv; }
            set { _masv = value; }
        }

        public string maphong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }

        public string ngaydk
        {
            get { return _ngaydk; }
            set { _ngaydk = value; }
        }

        public string ngaybd
        {
            get { return _ngaybd; }
            set { _ngaybd = value; }
        }

        public string ngaykt
        {
            get { return _ngaykt; }
            set { _ngaykt = value; }
        }

        // Constructor không tham số (khởi tạo mặc định)
        public DangKyPhongDTO()
        {
            _madk = "";
            _masv = "";
            _maphong = "";
            _ngaydk = "";
            _ngaybd = "";
            _ngaykt = "";
            _hoten = "";
            _tenphong = "";
        }

        // Constructor có tham số
        public DangKyPhongDTO(string MaDK, string MaSV, string MaPhong, string NgayDK, string NgayBD, string NgayKT, string HoTen, string TenPhong)
        {
            _madk = MaDK;
            _masv = MaSV;
            _maphong = MaPhong;
            _ngaydk = NgayDK;
            _ngaybd = NgayBD;
            _ngaykt = NgayKT;
            _hoten = HoTen;
            _tenphong = TenPhong;
        }
    }
}
