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
    public partial class HocSinh : Form
    {
        //Bảng Thông tin về "Học Sinh"
        #region Biến cục bộ 
        MyDataTable dataTable = new MyDataTable();
        #endregion

        #region Hàm dựng
        public HocSinh()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        #endregion

        #region Lấy dữ liệu
        public void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HocSinh");
            dataTable.Fill(cmd);

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            // Liên kết dữ liệu từ DataGridView lên các control
            txtMaHS.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtLop.DataBindings.Clear();
            chkGioitinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();

            txtMaHS.DataBindings.Add("Text",binding,"MaHS");
            txtHoTen.DataBindings.Add("Text", binding, "TenHS");
            txtLop.DataBindings.Add("Text", binding, "Lop");
            chkGioitinh.DataBindings.Add("Checked", binding, "GioiTinh");
            dateNgaySinh.DataBindings.Add("Value",binding,"NgaySinh");
            txtDiaChi.DataBindings.Add("Text", binding, "DiaChi");


        }
        public void LayDuLieu(string tu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HocSinh WHERE MaHS LIKE N'%" + tu + "%' OR TenHS LIKE N'%" + tu + "%'");
            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            // Liên kết dữ liệu từ DataGridView lên các control
            txtMaHS.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtLop.DataBindings.Clear();
            chkGioitinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();

            txtMaHS.DataBindings.Add("Text", binding, "MaHS");
            txtHoTen.DataBindings.Add("Text", binding, "TenHS");
            txtLop.DataBindings.Add("Text", binding, "Lop");
            chkGioitinh.DataBindings.Add("Checked", binding, "GioiTinh");
            dateNgaySinh.DataBindings.Add("Value", binding, "NgaySinh");
            txtDiaChi.DataBindings.Add("Text", binding, "DiaChi");
        }
        private void HocSinh_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        #endregion

        #region Chức năng

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
        //Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow["MaHS"] = "HS";
            dataRow["TenHS"] = "";
            dataRow["GioiTinh"] = 0;
            dataRow["NgaySinh"] = DateTime.Today;
            dataRow["Lop"] = "";
            dataRow["DiaChi"] = "";
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
        //Cập nhật
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (KiemTra("MaHS") &&
               KiemTra("TenHS") &&
               KiemTra("Lop") &&
               KiemTra("NgaySinh")&&
               KiemTra("DiaChi")&&
               KiemTra("GioiTinh"))
            {
                int result = dataTable.Update();
                MessageBox.Show("Đã cập nhật thành công " + result + " dòng dữ liệu!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LayDuLieu();
        }
        //Lưu dòng vừa thêm
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text.Trim() == "")
                MessageBox.Show("Mã Học Sinh không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtHoTen.Text.Trim() == "")
                MessageBox.Show("Họ và tên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtLop.Text.Trim() == "")
                MessageBox.Show("Lớp không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDiaChi.Text.Trim() == "")
                MessageBox.Show("Địa chỉ không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sql = @"INSERT INTO HocSinh VALUES(@MaHS, @TenHS, @GioiTinh, @NgaySinh, @Lop, @DiaChi)";
                SqlCommand cmd = new SqlCommand(sql);
               
                cmd.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10).Value = txtMaHS.Text;
                cmd.Parameters.Add("@TenHS", SqlDbType.NVarChar, 50).Value = txtHoTen.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.TinyInt).Value = chkGioitinh.Checked ? 1 : 0;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateNgaySinh.Value;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar, 10).Value = txtLop.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar,50).Value = txtDiaChi.Text;
                dataTable.Update(cmd);

                LayDuLieu();
                bindingNavigator1.BindingSource.MoveLast();
            }
        }
        //Tìm kiếm Họ tên - Mã học sinh
        private void btnTim_Click(object sender, EventArgs e)
        {
            LayDuLieu(txtTuKhoa.Text);
        }
        //Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

      
    }
}
