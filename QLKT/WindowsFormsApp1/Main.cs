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
    public partial class Main : Form
    {
        //Trang chủ
        #region Biến cục bộ
        string hoVaTen = "";
        string ghiChu = "";//Lưu mã học sinh or mã giáo viên của người đang đăng nhập
        string quyenHan = "";
        string taikhoan = "";//Lưu mã tài khoản đang đăng nhập
        DangNhap dangNhap = null;
        TaiKhoan taiKhoan = null;
        GiaoVien giaoVien = null;
        HocSinh hocSinh = null;
        ThongTinHS thongTinHS = null;
        ThongTinGV thongTinGV = null;
        DeKT deKT = null;
        NoiDungDe noiDungDe = null;
        ChonMaDe chonMaDe = null;
        ChonMaDe2 chonMaDe2 = null;
        LamBai lamBai = null;
        About about = null;
        DiemKT diemKT = null;
        DoiMatKhau doiMatKhau = null;
        Reports.DanhSachDiem danhSachDiem = null;

        #endregion

        #region Hàm dựng
        public Main()
        {
            Flash flash = new Flash();
            flash.ShowDialog();
            InitializeComponent();
            
        }
        #endregion

        #region Đăng nhập
        //Khởi tạo bảng (Hiện tất cả các nút)
        public void KhoiTao()
        {
            //button
            tbtnDangNhap.Enabled = true;
            tbtnDangNhap.Visible = true;
            tbtnDangXuat.Visible = true;
            tbtnDangXuat.Enabled = true;
            tbtnLamBai.Visible = true;
            tbtnLamBai.Enabled = true;
            tbtnKetQuaKT.Visible = true;
            tbtnKetQuaKT.Enabled = true;
            btnDeKiemTra.Visible = true;
            btnNoiDung.Visible = true;
            btnDanhSachKT.Visible = true;
            btnThongTinCaNhan.Visible = true;
            //menu
            mnuHeThong.Enabled = true;
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuThongTinCaNhan.Enabled = true;
            mnuQuanLi.Enabled = true;
            mnuTaiKhoan.Enabled = true;
            mnuGiaoVien.Enabled = true;
            mnuHocSinh.Enabled = true;
            mnuKiemTra.Enabled = true;
            mnuDeKT.Enabled = true;
            mnuNoiDung.Enabled = true;
            mnuLamBai.Enabled = true;
            mnuBaoCaoTK.Enabled = true;
            mnuKetQuaKT.Enabled = true;
            mnuDanhSachKT.Enabled = true;
         

        }
        //Chưa đăng nhập
        public void ChuaDangNhap()
        {
            KhoiTao();
            btnDeKiemTra.Visible = false;
            btnNoiDung.Visible = false;
            btnDanhSachKT.Visible = false;
            mnuQuanLi.Enabled = false;
            mnuKiemTra.Enabled = false;
            mnuBaoCaoTK.Enabled = false;
            tbtnDangXuat.Visible = false;
            tbtnLamBai.Visible = false;
            tbtnKetQuaKT.Visible = false;
            btnThongTinCaNhan.Visible = false;
            txtTrangThai.Text = "Chưa Đăng Nhập";

        }
        //Đăng nhập với quyền Admin(Quản lý) 
        public void QuanLy()
        {
            KhoiTao();
            tbtnDangNhap.Visible = false;
            mnuDangNhap.Enabled = false;
            tbtnLamBai.Visible = false;
            tbtnKetQuaKT.Visible = false;
            mnuKiemTra.Enabled = false;
            mnuKetQuaKT.Enabled = false;
            mnuThongTinCaNhan.Enabled = false;
            btnDeKiemTra.Visible = false;
            btnNoiDung.Visible = false;
            btnThongTinCaNhan.Visible = false;
            txtTrangThai.Text = "Chào, "+hoVaTen;

        }
        //Đăng nhập với quyền giáo viên
        public void GiaoVien()
        {
            KhoiTao();
            tbtnDangNhap.Visible = false;
            mnuDangNhap.Enabled = false;
            tbtnLamBai.Visible = false;
            tbtnKetQuaKT.Visible = false;
            mnuTaiKhoan.Enabled = false;
            mnuGiaoVien.Enabled = false;
            mnuLamBai.Enabled = false;
            mnuKetQuaKT.Enabled = false;
            txtTrangThai.Text = "Chào, " + hoVaTen;
        }
        //Đăng Nhập với quyền học sinh
        public void HocSinh()
        {
            KhoiTao();
            tbtnDangNhap.Visible = false;
            mnuDangNhap.Enabled = false;
            mnuGiaoVien.Enabled = false;
            mnuTaiKhoan.Enabled = false;
            mnuHocSinh.Enabled = false;
            mnuDanhSachKT.Enabled = false;
            mnuDeKT.Enabled = false;
            mnuNoiDung.Enabled = false;
            btnDeKiemTra.Visible = false;
            btnNoiDung.Visible = false;
            btnDanhSachKT.Visible = false;
            txtTrangThai.Text = "Chào, " + hoVaTen;
        }

        public void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                if (dangNhap.txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (dangNhap.txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    MyDataTable dataTable = new MyDataTable();
                    dataTable.OpenConnection();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenDangNhap = @TDN AND MatKhau = @MK");
                    cmd.Parameters.Add("@TDN", SqlDbType.NVarChar, 50).Value = dangNhap.txtTenDangNhap.Text;
                    cmd.Parameters.Add("@MK", SqlDbType.NVarChar, 100).Value = dangNhap.txtMatKhau.Text;
                    dataTable.Fill(cmd); 

                    if(dataTable.Rows.Count >0)
                    {
                        taikhoan = dataTable.Rows[0]["TenDangNhap"].ToString();
                        hoVaTen = dataTable.Rows[0]["HoTen"].ToString();
                        quyenHan = dataTable.Rows[0]["QuyenHan"].ToString();
                        ghiChu = dataTable.Rows[0]["GhiChu"].ToString();
                        if(quyenHan == "Admin")
                        {
                            QuanLy();
                        }
                        else if(quyenHan=="GiaoVien")
                        {
                            GiaoVien();
                        }
                        else if(quyenHan=="HocSinh")
                        {
                            HocSinh();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                }
            }
        }
      
        private void Main_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        #endregion

        #region Thanh Menu
        //Hệ thống
        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }
        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(doiMatKhau==null|| doiMatKhau.IsDisposed)
            {
                doiMatKhau = new DoiMatKhau(taikhoan);
                doiMatKhau.MdiParent = this;
                doiMatKhau.Show();
            }    
        }
        //Quản lí 
        private void mnuTaiKhoan_Click(object sender, EventArgs e) //(Admin)
        {
            if(taiKhoan==null || taiKhoan.IsDisposed)
            {
                taiKhoan = new TaiKhoan();
                taiKhoan.MdiParent = this;
                taiKhoan.Show();
            }
        }
        
        private void mnuGiaoVien_Click(object sender, EventArgs e)//(Admin)
        {
            
            if (giaoVien== null || giaoVien.IsDisposed)
            {
                giaoVien = new GiaoVien();
                giaoVien.MdiParent = this;
                giaoVien.Show();
            }
        }

        private void mnuHocSinh_Click(object sender, EventArgs e)//(Admin, GiaoVien)
        {
            if(hocSinh==null || hocSinh.IsDisposed)
            {
                hocSinh = new HocSinh();
                hocSinh.MdiParent = this;
                hocSinh.Show();
            }
        }
        private void mnuThongTinCaNhan_Click(object sender, EventArgs e)//(GiaoVien, HocSinh)
        {
            if (quyenHan == "HocSinh")
            {
                if (thongTinHS == null || thongTinHS.IsDisposed)
                {
                    thongTinHS = new ThongTinHS(ghiChu);
                    thongTinHS.MdiParent = this;
                    thongTinHS.Show();
                }
            }
            else if (quyenHan == "GiaoVien")
            {
                if (thongTinGV == null || thongTinGV.IsDisposed)
                {
                    thongTinGV = new ThongTinGV(ghiChu);
                    thongTinGV.MdiParent = this;
                    thongTinGV.Show();
                }
            }
        }
        //Đề kiểm tra
        private void mnuDeKT_Click(object sender, EventArgs e)//(GiaoVien)
        {
            if(deKT==null || deKT.IsDisposed)
            {
                deKT = new DeKT(ghiChu);
                deKT.MdiParent = this;
                deKT.Show();
            }    
        }
        private void mnuNoiDung_Click(object sender, EventArgs e)//(GiaoVien)
        {
            //Khởi tạo lại form chọn mã đề 2
            chonMaDe2 = null;
            if (chonMaDe2 == null || chonMaDe2.IsDisposed)
                chonMaDe2 = new ChonMaDe2(ghiChu);
            if (chonMaDe2.ShowDialog() == DialogResult.OK)
            {
                string n="";
                string de = chonMaDe2.cboChonDe2.SelectedValue.ToString();
                //Lấy dữ liệu số câu của mã đề
                MyDataTable dataTable = new MyDataTable();
                dataTable.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DeThi WHERE MaDeThi = @MaDT");
                cmd.Parameters.Add("@MaDT", SqlDbType.NVarChar, 10).Value = de;
                dataTable.Fill(cmd);
                if (dataTable.Rows.Count > 0)
                {
                   n= dataTable.Rows[0]["SoCau"].ToString();
                }

                if (noiDungDe == null || noiDungDe.IsDisposed)
                {
                    int socau = int.Parse(n);
                    noiDungDe = new NoiDungDe(ghiChu,de,socau);
                    noiDungDe.MdiParent = this;
                    noiDungDe.Show();
                }
            }
        }
        public void chonDeKT() //(HocSinh)
        {
        LamLai:
            if (chonMaDe == null || chonMaDe.IsDisposed)
                chonMaDe = new ChonMaDe();
            if (chonMaDe.ShowDialog() == DialogResult.OK)
            {
                bool Kiemtra = true;
                MyDataTable dataTable = new MyDataTable();
                dataTable.OpenConnection();
                // Kiểm tra bài đã làm rồi hay chưa 
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM KetQua WHERE MaHS = @HS AND MaDeThi = @De");
                cmd2.Parameters.Add("@HS", SqlDbType.NVarChar, 10).Value = ghiChu; //ghichu = Mã Học sinh
                cmd2.Parameters.Add("@De", SqlDbType.NVarChar, 10).Value = chonMaDe.cboChonDe.SelectedValue;
                dataTable.Fill(cmd2);
                if (dataTable.Rows.Count > 0)
                {
                    Kiemtra = false;
                    MessageBox.Show("Bạn đá làm bài kiểm tra này rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Bài kiểm tra chưa làm sẽ tiến hành kiểm tra
                if (Kiemtra == true)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM DeThi WHERE MaDeThi = @MaDT AND MatKhauDeThi = @MK");
                    cmd.Parameters.Add("@MaDT", SqlDbType.NVarChar, 10).Value = chonMaDe.cboChonDe.SelectedValue;
                    cmd.Parameters.Add("@MK", SqlDbType.NVarChar, 50).Value = chonMaDe.txtMkDe.Text;
                    dataTable.Fill(cmd);
                    if (dataTable.Rows.Count > 0)
                    {
                        string made = dataTable.Rows[0]["MaDeThi"].ToString();
                        string thoigian = dataTable.Rows[0]["ThoiGian"].ToString();
                        string tende = dataTable.Rows[0]["TenDeThi"].ToString();
                        string n = dataTable.Rows[0]["SoCau"].ToString();
                        if (lamBai == null || lamBai.IsDisposed)
                        {
                            lamBai = new LamBai(made, thoigian, ghiChu, tende, n);
                            lamBai.FormBorderStyle = FormBorderStyle.None;
                            lamBai.Show();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                }


            }
        }
        private void mnuLamBai_Click(object sender, EventArgs e)// (HocSinh)
        {
            chonDeKT();
        }
        //Kết quả kiểm tra
        private void mnuKetQuaKT_Click(object sender, EventArgs e)// (HocSinh)
        {
            if (chonMaDe2 == null || chonMaDe2.IsDisposed)
                chonMaDe2 = new ChonMaDe2();
            if (chonMaDe2.ShowDialog() == DialogResult.OK)
            {
                if (diemKT == null || diemKT.IsDisposed)
                {
                    string de = chonMaDe2.cboChonDe2.SelectedValue.ToString();
                    diemKT = new DiemKT(ghiChu, de);
                    diemKT.MdiParent = this;
                    diemKT.Show();
                }
            }
        }
        private void mnuDanhSachKT_Click(object sender, EventArgs e)// (Admin, GiaoVien)
        {
            //Khởi tạo lại form chọn mã đề 2
            chonMaDe2 = null;
            if (chonMaDe2 == null || chonMaDe2.IsDisposed)
            {
                if(quyenHan=="GiaoVien")
                    chonMaDe2 = new ChonMaDe2(ghiChu);
                else
                    chonMaDe2 = new ChonMaDe2();
            } 
            if (chonMaDe2.ShowDialog() == DialogResult.OK)
            {
                if (danhSachDiem == null || danhSachDiem.IsDisposed)
                {
                    string de = chonMaDe2.cboChonDe2.SelectedValue.ToString();
                    danhSachDiem = new Reports.DanhSachDiem(de);
                    danhSachDiem.MdiParent = this;
                    danhSachDiem.Show();
                }
            }
        }
        //Trợ giúp
        private void mnuThongTinPM_Click(object sender, EventArgs e)
        {
            if (about == null || about.IsDisposed)
            {
                about = new About();
                about.MdiParent = this;
                about.Show();
            }
        }
        #endregion

        #region Các nút chức năng
        private void tbtnDangXuat_Click(object sender, EventArgs e)
        {
            mnuDangXuat_Click(sender, e);
        }
        private void tbtnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void tbtnLamBai_Click(object sender, EventArgs e)
        {
            mnuLamBai_Click(sender, e);
        }

        private void tbtnKetQuaKT_Click(object sender, EventArgs e)
        {
            mnuKetQuaKT_Click(sender, e);
        }
        private void btnDeKiemTra_Click(object sender, EventArgs e)
        {
            mnuDeKT_Click(sender, e);
        }

        private void btnNoiDung_Click(object sender, EventArgs e)
        {
            mnuNoiDung_Click(sender, e);
        }

        private void btnDanhSachKT_Click(object sender, EventArgs e)
        {
            mnuDanhSachKT_Click(sender, e);
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            mnuThongTinCaNhan_Click(sender, e);
        }

        private void tbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #endregion

       
    }
}
