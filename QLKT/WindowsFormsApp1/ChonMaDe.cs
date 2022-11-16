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
    public partial class ChonMaDe : Form
    {
        //Hiện các mã đề đang có để tiến hành kiểm tra
        MyDataTable dataTable = new MyDataTable();
        public ChonMaDe()
        {
            InitializeComponent();
        }
        #region Load
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
        
        private void ChonMaDe_Load(object sender, EventArgs e)
        {
            LayMaDe(cboChonDe);
        }
        #endregion

        #region Các Chức Năng

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
