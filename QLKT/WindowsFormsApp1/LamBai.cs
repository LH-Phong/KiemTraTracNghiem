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
    public partial class LamBai : Form
    {
        //Làm bài kiểm tra và lưu kết quả
        #region Biến cục bộ
        string made; //Mã đề
        int thoigian,m=0,s=0,phut,giay=59; //Biến đếm thời gian
        string hsinh,tenhs,lop;//Thông tin Học sinh (MaHS, TenHS, Lop)
        string tende;//Tên đề kiểm tra
        string socau ;//Tổng số câu hỏi
        int donghientai = 0;//Câu hiện tại đang làm
        int[] danhsachcauhoi;//Danh sách lưu đáp án làm bài

        MyDataTable dataTable = new MyDataTable();
        #endregion

        #region Hàm Dựng
        public LamBai()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }
        public LamBai(string de,string time, string hs,string tde,string n)
        {
            made = de;
            phut = int.Parse(time.ToString())-1;
            thoigian= int.Parse(time.ToString());
            hsinh = hs;
            tende = tde;
            socau = n;
            danhsachcauhoi= new int[int.Parse(socau)];
            InitializeComponent();
            dataTable.OpenConnection();
        }
        #endregion

        #region Load dữ liệu
        //Lấy dữ liệu câu hỏi + các đáp án
        public void Laydulieu(string de)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NoiDung WHERE MaDeThi LIKE N'%" + de + "%' ORDER BY CauSo ASC;");
            
            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;
            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            txtCauHoi.DataBindings.Clear();
            txtCau.DataBindings.Clear();
            txtDapAn1.DataBindings.Clear();
            txtDapAn2.DataBindings.Clear();
            txtDapAn3.DataBindings.Clear();
            txtDapAn4.DataBindings.Clear();
            txtMaDe.DataBindings.Clear();
            chkDapAn1.Checked = false;
            chkDapAn2.Checked = false;
            chkDapAn3.Checked = false;
            chkDapAn4.Checked = false;
            txtCau.DataBindings.Add("Text", binding, "CauSo");
            txtCauHoi.DataBindings.Add("Text", binding, "CauHoi");
            txtDapAn1.DataBindings.Add("Text", binding, "DapAn1");
            txtDapAn2.DataBindings.Add("Text", binding, "DapAn2");
            txtDapAn3.DataBindings.Add("Text", binding, "DapAn3");
            txtDapAn4.DataBindings.Add("Text", binding, "DapAn4");
        }

        private void LamBai_Load(object sender, EventArgs e)
        {
            //Hiển thị thông tin đề kiểm tra
            txtMaDe.Text = made;
            txtThoiGian.Text = thoigian.ToString() + " phút";
            txtTenDe.Text = tende;
            //Khởi tạo biến đếm thời gian
            timer1.Interval = 1000;
            timer1.Start();
            //Reset ô chọn kết quả
            SqlCommand cmdRS = new SqlCommand("UPDATE NoiDung SET DapAnDaChon=NULL WHERE MaDeThi=@de");
            cmdRS.Parameters.Add("@de", SqlDbType.NVarChar, 10).Value = txtMaDe.Text;
            dataTable.Update(cmdRS);

            Laydulieu(made);
        }
        //Lấy thông tin Học Sinh đang làm bài kiểm tra
        public void layThongTin()
        {
            dataTable.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HocSinh WHERE MaHS = @hs ");
            cmd.Parameters.Add("@hs", SqlDbType.NVarChar, 10).Value = hsinh;
            dataTable.Fill(cmd);
            if (dataTable.Rows.Count > 0)
            {
                tenhs = dataTable.Rows[0]["TenHS"].ToString();
                lop = dataTable.Rows[0]["Lop"].ToString();
            }
        }
        #endregion
       
        #region Chọn đáp án
        
        private void chkDapAn1_Click(object sender, EventArgs e)
        {
            chkDapAn2.Checked = false;
            chkDapAn3.Checked = false;
            chkDapAn4.Checked = false;
            donghientai=Convert.ToInt32(dataGridView1.CurrentRow.Index); //Lưu lại vị trí câu hiện tại
            //Lưu đáp án đã chọn 
            SqlCommand cmd = new SqlCommand("UPDATE NoiDung SET DapAnDaChon=1 WHERE MaDeThi=@de AND CauSo=@cau");
            cmd.Parameters.Add("@de", SqlDbType.NVarChar, 10).Value = txtMaDe.Text;
            cmd.Parameters.Add("@cau", SqlDbType.Int).Value = txtCau.Text;
            dataTable.Update(cmd);
            Laydulieu(made);
            //Chuyển đến câu kế tiếp sau khi chọn đáp án 
            for (int i = 0; i <= donghientai; i++)
                bindingNavigator1.BindingSource.MoveNext();

            //Tương tự đối với các đáp án khác
        }

        private void chkDapAn2_Click(object sender, EventArgs e)
        {
            chkDapAn1.Checked = false;
            chkDapAn3.Checked = false;
            chkDapAn4.Checked = false;
            donghientai = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            SqlCommand cmd = new SqlCommand("UPDATE NoiDung SET DapAnDaChon=2 WHERE MaDeThi=@de AND CauSo=@cau");
            cmd.Parameters.Add("@de", SqlDbType.NVarChar, 10).Value = txtMaDe.Text;
            cmd.Parameters.Add("@cau", SqlDbType.Int).Value = txtCau.Text;
            dataTable.Update(cmd);
            Laydulieu(made);
            for (int i = 0; i <= donghientai; i++)
                bindingNavigator1.BindingSource.MoveNext();

        }

        private void chkDapAn3_Click(object sender, EventArgs e)
        {
            chkDapAn1.Checked = false;
            chkDapAn2.Checked = false;
            chkDapAn4.Checked = false;
            donghientai = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            SqlCommand cmd = new SqlCommand("UPDATE NoiDung SET DapAnDaChon=3 WHERE MaDeThi=@de AND CauSo=@cau");
            cmd.Parameters.Add("@de", SqlDbType.NVarChar, 10).Value = txtMaDe.Text;
            cmd.Parameters.Add("@cau", SqlDbType.Int).Value = txtCau.Text;
            dataTable.Update(cmd);
            Laydulieu(made);
            for (int i = 0; i <= donghientai; i++)
                bindingNavigator1.BindingSource.MoveNext();
        }

        private void chkDapAn4_Click(object sender, EventArgs e)
        {
            chkDapAn1.Checked = false;
            chkDapAn2.Checked = false;
            chkDapAn3.Checked = false;
            donghientai = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            SqlCommand cmd = new SqlCommand("UPDATE NoiDung SET DapAnDaChon=4 WHERE MaDeThi=@de AND CauSo=@cau");
            cmd.Parameters.Add("@de", SqlDbType.NVarChar, 10).Value = txtMaDe.Text;
            cmd.Parameters.Add("@cau", SqlDbType.Int).Value = txtCau.Text;
            dataTable.Update(cmd);
            Laydulieu(made);
            for (int i = 0; i <= donghientai; i++)
                bindingNavigator1.BindingSource.MoveNext();
        }

        //Chọn đáp án phía trên
        private void txtDapAn1_Click(object sender, EventArgs e)
        {
            chkDapAn1_Click(sender, e);
        }

        private void txtDapAn2_Click(object sender, EventArgs e)
        {
            chkDapAn2_Click(sender, e);
        }

        private void txtDapAn3_Click(object sender, EventArgs e)
        {
            chkDapAn3_Click(sender, e);
        }

        private void txtDapAn4_Click(object sender, EventArgs e)
        {
            chkDapAn4_Click(sender, e);
        }
        #endregion

        #region Các chức năng
        //Tính điểm kiểm tra
        public void TinhDiem(string de)
        {
            //So sánh Đáp Án đã chọn với Đáp Án đúng 
            for (int i = 0; i < int.Parse(socau); i++)
            { 
                SqlCommand cmd = new SqlCommand("SELECT DapAnDaChon,DapAnDung FROM NoiDung WHERE MaDeThi LIKE N'%" + de + "%' AND CauSo LIKE N'%" + i + "%'");
                dataTable.Fill(cmd);
                if (dataTable.Rows.Count > 0)
                {
                    string Chon= dataTable.Rows[0]["DapAnDaChon"].ToString();
                    string KQ = dataTable.Rows[0]["DapAnDung"].ToString();
                    if (Chon == KQ)
                    {
                        danhsachcauhoi[i] = 1;
                    }
                    else
                        danhsachcauhoi[i] = 0;
                }
            }

        }
       
        //Nộp bài kiểm tra
        public void btnNopBai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Nộp bài không?", "Nộp bài", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Stop();
                int dung = 0, sai = 0;
                layThongTin();
                TinhDiem(made);
                //Đếm số câu đúng và số câu sai
                for (int i = 0; i < int.Parse(socau); i++)
                {
                    if (danhsachcauhoi[i] == 1)
                        dung++;
                    else
                        sai++;
                }
                //Lưu bài đã làm vào table "KetQua"
                string day = DateTime.Today.ToString();//Lấy ngày hiện tại để lưu vào bài kiểm tra
                string sql = @"INSERT INTO KetQua VALUES(@MaHS, @MaDe, @TenHS, @Lop, @CDung, @CSai, @TGLam, @NgayKt)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10).Value = hsinh;
                cmd.Parameters.Add("@MaDe", SqlDbType.NVarChar, 10).Value = made;
                cmd.Parameters.Add("@TenHS", SqlDbType.NVarChar, 50).Value = tenhs;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar, 10).Value = lop;
                cmd.Parameters.Add("@CDung", SqlDbType.Int).Value = dung;
                cmd.Parameters.Add("@CSai", SqlDbType.Int, 20).Value = sai;
                cmd.Parameters.Add("@TGLam", SqlDbType.NVarChar, 20).Value = txtTimer2.Text;//Thời gian làm bài
                cmd.Parameters.Add("@NgayKt", SqlDbType.NVarChar, 50).Value = day.Remove(day.IndexOf(' '), 12);// xóa dòng thời gian (chỉ lấy ngày tháng năm)
                dataTable.Update(cmd); 
            }
            this.Close();
            MessageBox.Show("Đã Nộp bài", "Nộp", MessageBoxButtons.OK);
        }
        //Timer đếm thời gian làm bài, Hết thời gian tiến hành nộp bài
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (phut < 0 )
            {
                timer1.Stop();
                MessageBox.Show("Đã hết giờ làm bài!", "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNopBai_Click(sender, e);
            }
            giay--;
            s++;
            if(giay<=0)
            {
                phut--;
                giay = 59;
            }
            if(s>= 60)
            {
                m++;
                s = 0;
            }
            
            txtTimer.Text =phut.ToString()+":"+ giay.ToString();
            txtTimer2.Text = m.ToString() + ":" + s.ToString();
            
        }
        #endregion
    }
}
