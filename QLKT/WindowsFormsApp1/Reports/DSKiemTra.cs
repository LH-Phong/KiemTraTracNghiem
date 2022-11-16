using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Reports
{
    class DSKiemTra
    {
        string hocSinh;
        string maDe;
        string tenHS;
        string lop;
        string soCauDung;
        string soCauSai;
        string thoiGianLamBai;
        string ngayKT;

        public string HocSinh { get => hocSinh; set => hocSinh = value; }
        public string MaDe { get => maDe; set => maDe = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public string Lop { get => lop; set => lop = value; }
       
        public string ThoiGianLamBai { get => thoiGianLamBai; set => thoiGianLamBai = value; }
        public string NgayKT { get => ngayKT; set => ngayKT = value; }
        public string SoCauDung { get => soCauDung; set => soCauDung = value; }
        public string SoCauSai { get => soCauSai; set => soCauSai = value; }
    }
}
