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
    public partial class TaiKhoan : Form
    {
        #region Biến cục bộ
        MyDataTable dataTable = new MyDataTable();
        #endregion

        #region Hàm dựng
        public TaiKhoan()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        #endregion

        #region Load dữ liệu
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        public void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan");
            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;
            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            txtMaTaiKhoan.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            cboQuyenHan.DataBindings.Clear();

            txtMaTaiKhoan.DataBindings.Add("Text", binding, "MaTaiKhoan");
            txtHoTen.DataBindings.Add("Text", binding, "HoTen");
            txtGhiChu.DataBindings.Add("Text", binding, "GhiChu");
            txtTenDangNhap.DataBindings.Add("Text", binding, "TenDangNhap");
            txtMatKhau.DataBindings.Add("Text", binding, "MatKhau");
            cboQuyenHan.DataBindings.Add("Text", binding, "QuyenHan");
        }
        public void LayDuLieu(string tu)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM TaiKhoan WHERE MaTaiKhoan LIKE N'%" + tu + "%' " +
                                             "OR TenDangNhap LIKE N'%" + tu + "%' OR HoTen LIKE N'%" + tu+ "%'");
            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;
            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            txtMaTaiKhoan.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            cboQuyenHan.DataBindings.Clear();

            txtMaTaiKhoan.DataBindings.Add("Text", binding, "MaTaiKhoan");
            txtHoTen.DataBindings.Add("Text", binding, "HoTen");
            txtGhiChu.DataBindings.Add("Text", binding, "GhiChu");
            txtTenDangNhap.DataBindings.Add("Text", binding, "TenDangNhap");
            txtMatKhau.DataBindings.Add("Text", binding, "MatKhau");
            cboQuyenHan.DataBindings.Add("Text", binding, "QuyenHan");
        }
        #endregion

        #region Các chức năng
        //Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow["MaTaiKhoan"] = "TK";
            dataRow["HoTen"] = "";
            dataRow["TenDangNhap"] = "";
            dataRow["MatKhau"] = "";
            dataRow["QuyenHan"] = "HocSinh";
            dataTable.Rows.Add(dataRow);
            bindingNavigator1.BindingSource.MoveLast();
        }
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
        //Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
            }
        }
        //Lưu dòng vừa thêm
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaTaiKhoan.Text.Trim() == "")
                MessageBox.Show("Mã tài khoản không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtHoTen.Text.Trim() == "")
                MessageBox.Show("Họ và tên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtTenDangNhap.Text.Trim() == "")
                MessageBox.Show("Tên đăng nhập không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtMatKhau.Text.Trim() == "")
                MessageBox.Show("Mật khẩu không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboQuyenHan.Text.Trim() == "")
                MessageBox.Show("Quyền hạn không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sql = @"INSERT INTO TaiKhoan VALUES(@MaTaiKhoan, @HoTen, @TenDangNhap, @MatKhau, @QuyenHan, @GhiChu)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.Add("@MaTaiKhoan", SqlDbType.NVarChar, 10).Value = txtMaTaiKhoan.Text;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50).Value = txtHoTen.Text;
                cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 50).Value = txtTenDangNhap.Text;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 100).Value = txtMatKhau.Text;
                cmd.Parameters.Add("@QuyenHan", SqlDbType.NVarChar, 10).Value = cboQuyenHan.Text;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text;
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
        //Cập nhật
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (KiemTra("MaTaiKhoan") &&
               KiemTra("HoTen") &&
               KiemTra("TenDangNhap") &&
               KiemTra("MatKhau") &&
               KiemTra("QuyenHan"))
            {
                int result = dataTable.Update();
                MessageBox.Show("Đã cập nhật thành công " + result + " dòng dữ liệu!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LayDuLieu();
        }
        //Ẩn mật khẩu
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "MatKhau")
            {
                e.Value = "**********";
            }
        }
        //Tìm kiếm theo Tài khoản - Mã Tài khoản - Họ Tên
        private void btnTim_Click(object sender, EventArgs e)
        {
            LayDuLieu(txtTuKhoa.Text);
        }
        #endregion


    }
}
