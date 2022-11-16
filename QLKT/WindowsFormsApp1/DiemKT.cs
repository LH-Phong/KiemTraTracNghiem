using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DiemKT : Form
    {
        //Hiển thị kết quả kiểm tra của cá nhân học sinh
        #region Biến cục bộ
        MyDataTable dataTable = new MyDataTable();
        string hsinh="",made="";
        #endregion

        #region Hàm Dựng
        public DiemKT()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        public DiemKT(string hs, string de)
        {
            hsinh = hs;
            made = de;
            InitializeComponent();
            dataTable.OpenConnection();
            
        }
        #endregion

        #region Load dữ liệu
        //Lấy điểm kiểm tra dựa vào "Mã Học Sinh" và "Mã Đề" để xin ra kết quả kiểm tra
        private void DiemKT_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KetQua WHERE MaHS= @Hs AND MaDeThi= @De");
            cmd.Parameters.Add("@Hs", SqlDbType.NVarChar, 10).Value = hsinh;
            cmd.Parameters.Add("@De", SqlDbType.NVarChar, 10).Value = made;
            dataTable.Fill(cmd);
            
            if (dataTable.Rows.Count > 0)
            {
                string dung, sai;
                txtMaHS.Text= dataTable.Rows[0]["MaHS"].ToString();
                txtMaDe.Text= dataTable.Rows[0]["MaDeThi"].ToString();
                txtTenHS.Text= dataTable.Rows[0]["TenHS"].ToString();
                txtLop.Text= dataTable.Rows[0]["Lop"].ToString();
                dung= dataTable.Rows[0]["SoCauDung"].ToString();
                sai= dataTable.Rows[0]["SoCauSai"].ToString();
                txtCDung.Text = dung;
                txtCSai.Text = sai;
                txtNgayKT.Text= dataTable.Rows[0]["NgayKT"].ToString();
                txtThoiGianLB.Text= dataTable.Rows[0]["ThoiGianLamBai"].ToString();
                //Tính điểm kiểm tra
                float diem = float.Parse(dung)/ (float.Parse(dung)+float.Parse(sai));
                diem = diem * 10;
                txtDiem.Text= Math.Round(diem,1).ToString()+" điểm";
            }
            else
            {
                MessageBox.Show("Bạn chưa làm bài kiểm tra này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
