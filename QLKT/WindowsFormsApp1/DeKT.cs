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
    public partial class DeKT : Form
    {
        //Thông tin đề kiểm tra
        #region Biến cục bộ
        MyDataTable dataTable = new MyDataTable();
        string GVien = "";
        #endregion

        #region Hàm Dựng
        public DeKT()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        public DeKT(string gv)
        {
            GVien = gv;
            InitializeComponent();
            dataTable.OpenConnection();
        }
        #endregion

        #region Load dữ liệu
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
        public void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DeThi WHERE MaGV LIKE N'%" + GVien + "%'");
            dataTable.Fill(cmd);

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;

            txtMaDe.DataBindings.Clear();
            txtNguoiTaoDe.DataBindings.Clear();
            txtTenDe.DataBindings.Clear();
            txtSoCau.DataBindings.Clear();
            txtThoiGian.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();

            txtMaDe.DataBindings.Add("Text", binding, "MaDeThi");
            txtTenDe.DataBindings.Add("Text", binding, "TenDeThi");
            txtMatKhau.DataBindings.Add("Text", binding, "MatKhauDeThi");
            txtSoCau.DataBindings.Add("Text", binding, "SoCau");
            txtThoiGian.DataBindings.Add("Text", binding, "ThoiGian");
            txtNguoiTaoDe.DataBindings.Add("Text", binding, "MaGV");
       
        }
        private void DeKT_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        #endregion

        #region Các chức năng
        //Thêm mới
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow["MaDeThi"] = "Test";
            dataRow["TenDeThi"] = "";
            dataRow["MatKhauDeThi"] = "";
            dataRow["SoCau"] =0 ;
            dataRow["ThoiGian"] =0;
            dataRow["MaGV"] = GVien;
            dataTable.Rows.Add(dataRow);
            bindingNavigator1.BindingSource.MoveLast();
        }
        //Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
            }
        }
        //Cập nhật lại dữ liệu
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (KiemTra("MaDeThi") &&
              KiemTra("TenDeThi") &&
              KiemTra("SoCau") &&
              KiemTra("ThoiGian"))

            {
                int result = dataTable.Update();
                MessageBox.Show("Đã cập nhật thành công " + result + " dòng dữ liệu!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LayDuLieu();
        }
        //Lưu dòng vừa thêm
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMaDe.Text.Trim()=="")
                MessageBox.Show("Mã đề không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(txtTenDe.Text.Trim()=="")
                MessageBox.Show("Tên đề không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(txtSoCau.Text.Trim()=="")
                MessageBox.Show("Số câu không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(txtThoiGian.Text.Trim()=="")
                MessageBox.Show("Thời gian không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            { 
                string sql = @"INSERT INTO DeThi VALUES(@MaDeThi, @TenDe, @MatKhau, @SoCau, @ThoiGian, @MaGV)";
                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.Add("@MaDeThi", SqlDbType.NVarChar, 10).Value = txtMaDe.Text;
                cmd.Parameters.Add("@TenDe", SqlDbType.NVarChar, 50).Value =txtTenDe.Text;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 10).Value = txtMatKhau.Text;
                cmd.Parameters.Add("@SoCau", SqlDbType.NVarChar, 10).Value = txtSoCau.Text;
                cmd.Parameters.Add("@ThoiGian", SqlDbType.NVarChar, 10).Value = txtThoiGian.Text;
                cmd.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10).Value = txtNguoiTaoDe.Text;
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
