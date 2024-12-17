using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyTucXa.DTO
{
    internal class SinhVienDTO
    {
        private string _masv;
        private string _hoten;
        private string _gioitinh;
        private string _maphong;
        private string _nganhhoc;
        private string _cccd;
        private string _ngaysinh;
        private string _sdt;
        private string _diachi;
        private string _email;

        public string MaSV
        {
            get
            {
                return _masv;
            }

            set
            {
                _masv = value;
            }
        }

        public string MaPhong
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

        public string Hoten
        {
            get
            {
                return _hoten;
            }

            set
            {
                _hoten = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _gioitinh;
            }

            set
            {
                _gioitinh = value;
            }
        }

        public string Nganhhoc
        {
            get
            {
                return _nganhhoc;
            }

            set
            {
                _nganhhoc = value;
            }
        }
        public string Ngaysinh
        {
            get
            {
                return _ngaysinh;
            }

            set
            {
                _ngaysinh = value;
            }
        }
        public string Cccd
        {
            get
            {
                return _cccd;
            }

            set
            {
                _cccd = value;
            }
        }
        public string Sdt
        {
            get
            {
                return _sdt;
            }

            set
            {
                _sdt = value;
            }
        }
        public string Diachi
        {
            get
            {
                return _diachi;
            }

            set
            {
                _diachi = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        public SinhVienDTO()
        {
            _maphong = "";
            _hoten = "";
            _gioitinh = "";
            _masv = "";
            _nganhhoc = "";
            _ngaysinh = "";
            _cccd = "";
            _sdt = "";
            _diachi = "";
            _email = "";



        }
        public SinhVienDTO(string MaSV, string MaPhong, string Hoten, string GioiTinh, string Nganhhoc, string Ngaysinh, string Cccd, string Sdt,string Diachi,string Email)
        {
            _masv = MaSV;
            _maphong = MaPhong;
            _hoten = Hoten;
            _gioitinh = GioiTinh;
            _nganhhoc = Nganhhoc;
            _ngaysinh = Ngaysinh;
            _cccd = Cccd;
            _sdt = Sdt;
            _diachi = Diachi;
            _email = Email;

        }


    }
}
