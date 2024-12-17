using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KyTucXa.DTO
{
    internal class QuanLiKTX_DTO
    {
        private string _maphong;
        private string _tenphong;
        private string _tinhtrang;
        private string _soluongsv;
        private string _giaphong;

        public string Maphong
        {
            get
            {
                return _maphong;
            }

            set
            {
                _maphong = value;
            }
        }

        public string Tenphong
        {
            get
            {
                return _tenphong;
            }

            set
            {
                _tenphong = value;
            }
        }

        public string Tinhtrang
        {
            get
            {
                return _tinhtrang;
            }

            set
            {
                _tinhtrang = value;
            }
        }

        public string Soluongsv
        {
            get
            {
                return _soluongsv;
            }

            set
            {
                _soluongsv = value;
            }
        }

        public string Giaphong
        {
            get
            {
                return _giaphong;
            }

            set
            {
                _giaphong = value;
            }
        }

        public QuanLiKTX_DTO()
        {
            _maphong = "";
            _tenphong = "";
            _tinhtrang = "";
            _soluongsv = "";
            _giaphong = "";
           
        }
        public QuanLiKTX_DTO(string MaPhong, string TenPhong, string TinhTrang, string SoLuongSV, string GiaPhong)
        {
            _maphong = MaPhong;
            _tenphong = TenPhong;
            _tinhtrang = TinhTrang;
            _soluongsv = SoLuongSV;
            _giaphong = GiaPhong;
        }
    }
}
