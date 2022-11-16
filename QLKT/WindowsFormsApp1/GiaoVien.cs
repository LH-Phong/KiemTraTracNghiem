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
    public partial class GiaoVien : Form
    {
        //Bảng thông tin về "Giáo Viên"
        #region Biến cục bộ
        MyDataTable dataTable = new MyDataTable();
        #endregion

        #region Hàm dựng
        public GiaoVien()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        #endregion

        #region Load dữ liệu
        public void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaoVien");
            dataTable.Fill(cmd);
            
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;

            // Liên kết dữ liệu từ DataGridView lên các control
            txtMaGV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtNamSinh.DataBindings.Clear();
            txtBoMon.DataBindings.Clear();
            chkGioitinh.DataBindings.Clear();
            
            
            txtMaGV.DataBindings.Add("Text", binding, "MaGV");
            txtHoTen.DataBindings.Add("Text", binding, "TenGV");
            txtNamSinh.DataBindings.Add("Text", binding, "NamSinh");
            txtSDT.DataBindings.Add("Text", binding, "SoDienThoai");
            txtBoMon.DataBindings.Add("Text", binding, "BoMon");
            chkGioitinh.DataBindings.Add("Checked", binding, "GioiTinh");
        }
        public void LayDuLieu(string tu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaoVien WHERE MaGV LIKE N'%" + tu + "%' OR TenGV LIKE N'%" + tu + "%'");
            dataTable.Fill(cmd);

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;

            // Liên kết dữ liệu từ DataGridView lên các control
            txtMaGV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtNamSinh.DataBindings.Clear();
            txtBoMon.DataBindings.Clear();
            chkGioitinh.DataBindings.Clear();


            txtMaGV.DataBindings.Add("Text", binding, "MaGV");
            txtHoTen.DataBindings.Add("Text", binding, "TenGV");
            txtNamSinh.DataBindings.Add("Text", binding, "NamSinh");
            txtSDT.DataBindings.Add("Text", binding, "SoDienThoai");
            txtBoMon.DataBindings.Add("Text", binding, "BoMon");
            chkGioitinh.DataBindings.Add("Checked", binding, "GioiTinh");
        }
        private void GiaoVien_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        #endregion

        #region ChucNang
        //Kiểm tra cột dữ liệu trống
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
        //Thêm mới 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow["MaGV"] = "GV";
            dataRow["TenGV"] = "";
            dataRow["GioiTinh"] = 0;
            dataRow["NamSinh"] = 1980;
            dataRow["BoMon"] = "";
            dataRow["SoDienThoai"] = "";
            dataTable.Rows.Add(dataRow);
            bindingNavigator1.BindingSource.MoveLast();
            txtMaGV.Focus();
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
            if (KiemTra("MaGV") &&
               KiemTra("TenGV") &&
               KiemTra("BoMon") &&
               KiemTra("NamSinh"))
             
            {
                int result = dataTable.Update();
                MessageBox.Show("Đã cập nhật thành công " + result + " dòng dữ liệu!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LayDuLieu();
        }
        //Lưu dòng dữ liệu vừa thêm
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
                MessageBox.Show("Mã giáo viên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtHoTen.Text.Trim() == "")
                MessageBox.Show("Họ và tên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtBoMon.Text.Trim() == "")
                MessageBox.Show("Bộ môn không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtNamSinh.Text.Trim() == "")
                MessageBox.Show("Năm Sinh không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sql = @"INSERT INTO GiaoVien VALUES(@MaGV, @TenGV, @SoDienThoai, @NamSinh, @GioiTinh, @BoMon)";
                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10).Value = txtMaGV.Text;
                cmd.Parameters.Add("@TenGV", SqlDbType.NVarChar, 50).Value = txtHoTen.Text;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 15).Value = txtSDT.Text;
                cmd.Parameters.Add("@NamSinh", SqlDbType.SmallInt).Value =txtNamSinh.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.TinyInt).Value = chkGioitinh.Checked ? 1 : 0;
                cmd.Parameters.Add("@BoMon", SqlDbType.NVarChar, 30).Value = txtBoMon.Text;
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
        //Tìm kiếm theo Mã GV- Tên GV
        private void btnTim_Click(object sender, EventArgs e)
        {
            LayDuLieu(txtTuKhoa.Text);
        }
        #endregion


    }
}
