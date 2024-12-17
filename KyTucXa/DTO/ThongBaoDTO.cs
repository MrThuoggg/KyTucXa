using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KyTucXa.DTO
{
    internal class ThongBaoDTO
    {
        private string _matb;
        private string _noidung;
        private string _ngaytb;
        private string _loaitb;

        public string matb
        {
            get { return _matb; }
            set { _matb = value; }
        }
        public string noidung
        {
            get { return _noidung; }
            set { _noidung = value; }
        }
        public string ngaytb
        {
            get { return _ngaytb; }
            set { _ngaytb = value; }
        }
        public string loaitb
        {
            get { return _loaitb; }
            set { _loaitb = value; }
        }

        public ThongBaoDTO()
        {
            _matb= "";
            _noidung = ""; 
            _ngaytb = "";
            _loaitb = "";
        }
        public ThongBaoDTO(string MaTB,string NoiDung, string NgayTB, string LoaiTB)
        {
            _matb = MaTB;
            _noidung = NoiDung;
            _ngaytb = NgayTB;
            _loaitb = LoaiTB;
        }
    }
}
