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
    public partial class DoiMatKhau : Form
    {
        //Đổi mật khẩu đăng nhập
        #region Biến cục bộ
        string tentaiKhoan = "";
        MyDataTable dataTable = new MyDataTable();
        #endregion

        #region Hàm dựng
        public DoiMatKhau()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        public DoiMatKhau(string tk)
        {
            tentaiKhoan = tk;
            InitializeComponent();
            dataTable.OpenConnection();

        }
        #endregion

        #region Các chức năng
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            if(txtMatKhau.Text==txtXacNhanMK.Text)
            {
                SqlCommand cmd = new SqlCommand("UPDATE TaiKhoan SET MatKhau=@mK WHERE TenDangNhap=@tK");
                cmd.Parameters.Add("@tK", SqlDbType.NVarChar, 50).Value = tentaiKhoan;
                cmd.Parameters.Add("@mK", SqlDbType.NVarChar, 100).Value = txtMatKhau.Text;
                dataTable.Update(cmd);
                MessageBox.Show("Đã thay đổi mật khẩu!", "Thành công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
