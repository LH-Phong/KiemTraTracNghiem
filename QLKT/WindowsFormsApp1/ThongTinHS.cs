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

namespace WindowsFormsApp1
{
    public partial class ThongTinHS : Form
    {
        //Hiển thị thông tin cá nhân của học sỉnh đang đăng nhập
        #region Biến cục bộ
        string hsinh;
        #endregion

        #region Lấy dữ liệu
        public ThongTinHS(string hs)
        {
            hsinh = hs;
            InitializeComponent();
        }
        public ThongTinHS()
        {
            InitializeComponent();
        }


        private void ThongTinHS_Load(object sender, EventArgs e)
        {

            MyDataTable dataTable = new MyDataTable();
            dataTable.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HocSinh WHERE MaHS = @hs ");
            cmd.Parameters.Add("@hs", SqlDbType.NVarChar, 10).Value= hsinh;
            dataTable.Fill(cmd);
            if (dataTable.Rows.Count > 0)
            {
                txtMaHS.Text= dataTable.Rows[0]["MaHS"].ToString();
                txtHoTen.Text= dataTable.Rows[0]["TenHS"].ToString();
                string gt= dataTable.Rows[0]["GioiTinh"].ToString();
                if (gt == "1")
                    chkGioitinh.Checked = true;
                txtLop.Text= dataTable.Rows[0]["Lop"].ToString();
                txtDiaChi.Text= dataTable.Rows[0]["DiaChi"].ToString();
                string nsinh= dataTable.Rows[0]["NgaySinh"].ToString();
               //txtNgaySinh.Text = nsinh;
               //Xóa đoạn thời gian sau ngày tháng năm 
                txtNgaySinh.Text = nsinh.Remove(nsinh.IndexOf(' '),12);
                
            }

        }
        #endregion
    }
}
