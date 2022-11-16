using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DangNhap : Form
    {
        //Nhập tên tài khoản + mật khẩu để đăng nhập
        public DangNhap()
        {
            InitializeComponent();
        }
        #region Các chức năng
        //Button đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Button Thoát
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        //Keydown "EnTer" khi nhập mật khẩu
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
        #endregion
    }
}
