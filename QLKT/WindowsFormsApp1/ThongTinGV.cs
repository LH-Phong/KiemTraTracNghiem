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
    public partial class ThongTinGV : Form
    {
        //Hiển thị thông tin các nhân của giáo viên đang đăng nhập
        #region Biến cục bộ
        string magvien;
        #endregion

        #region Load dữ liệu
        public ThongTinGV()
        {
            InitializeComponent();
        }
        
        public ThongTinGV(string gv)
        {
            magvien = gv;
            InitializeComponent();
        }
        
        private void ThongTinGV_Load(object sender, EventArgs e)
        {
            MyDataTable dataTable = new MyDataTable();
            dataTable.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaoVien WHERE MaGV=@gv");
            cmd.Parameters.Add("@gv", SqlDbType.NVarChar,10).Value = magvien;
            dataTable.Fill(cmd);
            if (dataTable.Rows.Count > 0)
            {
                txtMaGV.Text = dataTable.Rows[0]["MaGV"].ToString();
                txtHoTen.Text = dataTable.Rows[0]["TenGV"].ToString();
                string gt = dataTable.Rows[0]["GioiTinh"].ToString();
                if (gt == "1")
                    chkGioitinh.Checked = true;
                txtSDT.Text = dataTable.Rows[0]["SoDienThoai"].ToString();
                txtBoMon.Text = dataTable.Rows[0]["BoMon"].ToString();
                txtNamSinh.Text = dataTable.Rows[0]["NamSinh"].ToString();
                txtBoMon.Enabled = false;
                txtHoTen.Enabled = false;
                txtNamSinh.Enabled = false;
                chkGioitinh.Enabled = false;
                txtSDT.Enabled = false;
                btnLuu.Enabled = false;

            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtBoMon.Enabled = true;
            txtHoTen.Enabled = true;
            txtNamSinh.Enabled = true;
            chkGioitinh.Enabled = true;
            txtSDT.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MyDataTable dataTable = new MyDataTable();
            dataTable.OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE GiaoVien SET TenGV=@ten ,SoDienThoai=@sdt, NamSinh=@nSinh, GioiTinh=@gt, BoMon=@bm WHERE MaGV = @gv");
            cmd.Parameters.Add("@gv", SqlDbType.NVarChar, 10).Value = magvien;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = txtHoTen.Text;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 15).Value = txtSDT.Text;
            cmd.Parameters.Add("@nSinh", SqlDbType.SmallInt).Value = txtNamSinh.Text;
            byte gt=0; 
            if (chkGioitinh.Checked == true) gt = 1;
            cmd.Parameters.Add("@gt", SqlDbType.TinyInt).Value = gt;
            cmd.Parameters.Add("@bm", SqlDbType.NVarChar, 30).Value = txtBoMon.Text;
            dataTable.Update(cmd);
            MessageBox.Show("Đã cập nhật. ", "Thành công", MessageBoxButtons.OK);
            ThongTinGV_Load(sender, e);
        }
        #endregion


    }
}
