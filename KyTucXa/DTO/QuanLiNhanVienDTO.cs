using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyTucXa.DAO;
using KyTucXa.GUI;
using KyTucXa.DTO;

namespace KyTucXa.DTO
{
    internal class QuanLiNhanVienDTO
    {

        private string _manv;
        private string _hoten;
        private string _cccd;
        private string _gt;
        private string _ns;
        private string _email;
        private string _sdt;

        public string manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        public string cccd
        {
            get { return _cccd; }
            set { _cccd = value; }
        }
        public string gt
        {
            get { return _gt; }
            set { _gt = value; }
        }
        public string ns
        {
            get { return _ns; }
            set { _ns = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public QuanLiNhanVienDTO()
        {
            _manv = "";
            _hoten = "";
            _gt = "";
            _cccd = "";
            _ns = "";
            _email = "";
            _sdt = "";
        }
        public QuanLiNhanVienDTO(string MaNV, string HoTen, string Cccd, string GioiTinh, string NgaySinh, string Email, string Sdt)
        {
            _manv = MaNV;
            _hoten = HoTen;
            _cccd = Cccd;
            _gt = GioiTinh;
            _ns = NgaySinh;
            _email = Email;
            _sdt = Sdt;
        }
    }
}
