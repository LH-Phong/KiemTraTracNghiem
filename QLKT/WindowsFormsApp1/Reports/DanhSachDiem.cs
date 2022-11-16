using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Reports
{
    public partial class DanhSachDiem : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string made = "";
        
        public DanhSachDiem()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        public DanhSachDiem(string de)
        {
            made = de;
            InitializeComponent();
            dataTable.OpenConnection();
        }

        IList<DSKiemTra> LayDuLieu()
        {
            IList<DSKiemTra> list = new List<DSKiemTra>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM KetQua WHERE MaDeThi = @de");
            cmd.Parameters.Add("@de", SqlDbType.NVarChar, 10).Value = made;
            dataTable.Fill(cmd);
            foreach (DataRow row in dataTable.Rows)
            {
                DSKiemTra ds = new DSKiemTra();
                ds.HocSinh= row["MaHS"].ToString();
                ds.MaDe= row["MaDeThi"].ToString();
                ds.TenHS= row["TenHS"].ToString();
                ds.Lop= row["Lop"].ToString();
                ds.SoCauDung = row["SoCauDung"].ToString();
                ds.SoCauSai = row["SoCauSai"].ToString();
                ds.ThoiGianLamBai= row["ThoiGianLamBai"].ToString();
                ds.NgayKT= row["NgayKT"].ToString(); ;
                list.Add(ds);
            }
            return list;
        }
        IList<DSKiemTra> LayDuLieu_TheoDe()
        {
            IList<DSKiemTra> list = new List<DSKiemTra>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM KetQua WhERE MaDeThi= @de");
            cmd.Parameters.Add("@de", SqlDbType.NVarChar, 10).Value = made;
            dataTable.Fill(cmd);
            foreach (DataRow row in dataTable.Rows)
            {
                DSKiemTra ds = new DSKiemTra();
                ds.HocSinh = row["MaHS"].ToString();
                ds.MaDe = row["MaDeThi"].ToString();
                ds.TenHS = row["TenHS"].ToString();
                ds.Lop = row["Lop"].ToString();
                ds.SoCauDung = row["SoCauDung"].ToString();
                ds.SoCauSai = row["SoCauSai"].ToString();
                ds.ThoiGianLamBai = row["ThoiGianLamBai"].ToString();
                ds.NgayKT = row["NgayKT"].ToString(); ;
                list.Add(ds);
            }
            return list;
        }
        private void DanhSachDiem_Load(object sender, EventArgs e)
        {
            IList<DSKiemTra> list = LayDuLieu();
            bindingSource1.DataSource = list;
            this.reportViewer1.RefreshReport();
        }
    }
}
