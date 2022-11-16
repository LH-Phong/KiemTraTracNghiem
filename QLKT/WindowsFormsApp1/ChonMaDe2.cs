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
    public partial class ChonMaDe2 : Form
    {
        //Hiện các mã đề đang có để tiến hành việc xem điểm kiểm tra
        MyDataTable dataTable = new MyDataTable();
        string maGV = "";
        public ChonMaDe2()
        {
            InitializeComponent();
        }

        public ChonMaDe2(string gv)
        {
            maGV = gv;
            InitializeComponent();
        }
        #region Load
        //Lấy mã đề 
        public void LayMaDe(ComboBox comboBox)
        {
           
            MyDataTable table = new MyDataTable();
            table.OpenConnection();
           
            string sql = "SELECT * FROM DeThi ";
            SqlCommand command = new SqlCommand(sql);
            table.Fill(command);

            comboBox.DataSource = table;
            comboBox.DisplayMember = "MaDeThi";
            comboBox.ValueMember = "MaDeThi";
        }
        public void LayMaDeGV(ComboBox comboBox)
        {
           
            MyDataTable table = new MyDataTable();
            table.OpenConnection();
     
            string sql = "SELECT * FROM DeThi WHERE MaGV LIKE N'%" + maGV + "%'";
            SqlCommand command = new SqlCommand(sql);
            table.Fill(command);
            comboBox.DataSource = table;
            comboBox.DisplayMember = "MaDeThi";
            comboBox.ValueMember = "MaDeThi";
        }
        private void ChonMaDe2_Load(object sender, EventArgs e)
        {
            if (maGV.Trim() == "")
                LayMaDe(cboChonDe2);
            else
                LayMaDeGV(cboChonDe2);
        }
        #endregion

        #region Các chức năng
        //Button Tiếp Tục
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Button Thoát
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
