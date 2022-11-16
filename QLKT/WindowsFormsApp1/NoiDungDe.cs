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
    public partial class NoiDungDe : Form
    {
        //Nội dung các câu hỏi kiểm tra
        #region Biến cục bộ
        MyDataTable dataTable = new MyDataTable();
        string maGV = "";
        string maDe = "";
        int socau = 0;
        #endregion

        #region Hàm Dựng
        public NoiDungDe()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        
        public NoiDungDe(string gv, string de,int so)
        {
            maGV = gv;
            maDe = de;
            socau = so;
            InitializeComponent();
            dataTable.OpenConnection();
        }
        #endregion

        #region Load dữ liệu
        public void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NoiDung WHERE MaDeThi=@MaDe");
            cmd.Parameters.Add("@MaDe", SqlDbType.NVarChar, 10).Value = maDe;
            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;
            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;

            txtID.DataBindings.Clear();
            txtMaDe.DataBindings.Clear();
            txtCau.DataBindings.Clear();
            txtCauHoi.DataBindings.Clear();
            txtDapAn1.DataBindings.Clear();
            txtDapAn2.DataBindings.Clear();
            txtDapAn3.DataBindings.Clear();
            txtDapAn4.DataBindings.Clear();
            cboDapAn.DataBindings.Clear();
            txtDapAnChon.DataBindings.Clear();

            txtID.DataBindings.Add("Text", binding, "ID");
            txtMaDe.DataBindings.Add("Text", binding, "MaDeThi");
            txtCau.DataBindings.Add("Text", binding, "CauSo");
            txtCauHoi.DataBindings.Add("Text", binding, "CauHoi");
            txtDapAn1.DataBindings.Add("Text", binding, "DapAn1");
            txtDapAn2.DataBindings.Add("Text", binding, "DapAn2");
            txtDapAn3.DataBindings.Add("Text", binding, "DapAn3");
            txtDapAn4.DataBindings.Add("Text", binding, "DapAn4");
            cboDapAn.DataBindings.Add("Text", binding, "DapAnDung");
            txtDapAnChon.DataBindings.Add("Text", binding, "DapAnDaChon");
            if (KiemTraSoCauHoi() >= socau)
                btnAdd.Enabled = false;
            else
                btnAdd.Enabled = true;

        }
        private void NoiDungDe_Load(object sender, EventArgs e)
        {
            txtMaGV.Text= maGV;
            txtSoCau.Text = "/" + socau;
            LayDuLieu();
        }


        #endregion

        #region Các chức năng
        //Kiểm tra câu hỏi
        public bool KiemTra(string columnName)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string value = row.Cells[columnName].Value.ToString();
                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Giá trị của ô không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public int KiemTraSoCauHoi()
        {  
            string sql = @"SELECT * FROM NoiDung WHERE MaDeThi=@De";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@De", SqlDbType.NVarChar, 10).Value = txtMaDe.Text;
            dataTable.Fill(cmd);
            return dataTable.Rows.Count;
        }
        //Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int c = KiemTraSoCauHoi() + 1;
            DataRow dataRow = dataTable.NewRow();
            dataRow["ID"] = maDe + "_" + c; 
            dataRow["MaDeThi"] = maDe;
            dataRow["CauSo"] = c;
            dataRow["CauHoi"] = "";
            dataRow["DapAn1"] = "";
            dataRow["DapAn2"] = "";
            dataRow["DapAn3"] = "";
            dataRow["DapAn4"] = "";
            dataRow["DapAnDung"] = 1;
            dataRow["DapAnDaChon"] = 0;
            dataTable.Rows.Add(dataRow);
            bindingNavigator1.BindingSource.MoveLast();
            txtCauHoi.Focus();
        }
        //Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = @"DELETE NoiDung WHERE MaDeThi=@De AND CauSo=@cau";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.Add("@De", SqlDbType.NVarChar, 10).Value = txtMaDe.Text;
                cmd.Parameters.Add("@cau", SqlDbType.Int).Value = txtCau.Text;
                dataTable.Update(cmd);
                bindingNavigator1.BindingSource.RemoveCurrent();
                
            }
            LayDuLieu();
        }
        //Cập nhật
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (KiemTra("ID") &&
               KiemTra("CauHoi") &&
               KiemTra("DapAn1") &&
               KiemTra("DapAn2") &&
               KiemTra("DapAn3") &&
               KiemTra("DapAn4"))
            {
                string sql = @"UPDATE NoiDung SET ID=@id, CauHoi=@Hoi, DapAn1=@d1 ,DapAn2=@d2, DapAn3=@d3, DapAn4= @d4, DapAnDung=@dung WHERE MaDeThi=@De AND CauSo=@cau";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 20).Value = txtID.Text;
                cmd.Parameters.Add("@Hoi", SqlDbType.NVarChar).Value =txtCauHoi.Text;
                cmd.Parameters.Add("@d1", SqlDbType.NVarChar).Value = txtDapAn1.Text;
                cmd.Parameters.Add("@d2", SqlDbType.NVarChar).Value = txtDapAn2.Text;
                cmd.Parameters.Add("@d3", SqlDbType.NVarChar).Value = txtDapAn3.Text;
                cmd.Parameters.Add("@d4", SqlDbType.NVarChar).Value = txtDapAn4.Text;
                cmd.Parameters.Add("@dung", SqlDbType.Int).Value = cboDapAn.Text;
                cmd.Parameters.Add("@De", SqlDbType.NVarChar, 10).Value = maDe;
                cmd.Parameters.Add("@cau", SqlDbType.Int).Value = txtCau.Text;
                dataTable.Update(cmd);
                LayDuLieu();
            }
            LayDuLieu();
        }
        //Lưu dồng vừa thêm
        private void btnSave_Click(object sender, EventArgs e)
        {
            int cau = int.Parse(txtCau.Text);
            if (txtID.Text.Trim() == "")
                MessageBox.Show("ID không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtCauHoi.Text.Trim() == "")
                MessageBox.Show("Câu Hỏi không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDapAn1.Text.Trim() == "")
                MessageBox.Show("Đáp Án 1 không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDapAn2.Text.Trim() == "")
                MessageBox.Show("Đáp Án 2 không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDapAn3.Text.Trim() == "")
                MessageBox.Show("Đáp Án 3 không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDapAn4.Text.Trim() == "")
                MessageBox.Show("Đáp Án 4 không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cau > socau || cau <=0)
            {
                MessageBox.Show("Vượt quá số lượng câu hỏi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LayDuLieu();
            }
            else
            {
                string sql = @"INSERT INTO NoiDung VALUES(@iD, @maDe, @cau, @cHoi, @d1, @d2, @d3, @d4, @dDung, @dChon)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.Add("@iD", SqlDbType.NVarChar, 20).Value = txtID.Text;
                cmd.Parameters.Add("@maDe", SqlDbType.NVarChar, 10).Value = maDe;
                cmd.Parameters.Add("@cau", SqlDbType.Int).Value = txtCau.Text;
                cmd.Parameters.Add("@cHoi", SqlDbType.NVarChar).Value = txtCauHoi.Text;
                cmd.Parameters.Add("@d1", SqlDbType.NVarChar).Value = txtDapAn1.Text;
                cmd.Parameters.Add("@d2", SqlDbType.NVarChar).Value = txtDapAn2.Text;
                cmd.Parameters.Add("@d3", SqlDbType.NVarChar).Value = txtDapAn3.Text;
                cmd.Parameters.Add("@d4", SqlDbType.NVarChar).Value = txtDapAn4.Text;
                cmd.Parameters.Add("@dDung", SqlDbType.Int).Value = cboDapAn.Text;
                cmd.Parameters.Add("@dChon", SqlDbType.Int).Value = 0;
                dataTable.Update(cmd);
                LayDuLieu();
                bindingNavigator1.BindingSource.MoveLast();
            }

        }
        //Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
