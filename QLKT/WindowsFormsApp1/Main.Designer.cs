
namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKiemTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeKT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLamBai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetQuaKT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhSachKT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinPM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnLamBai = new System.Windows.Forms.ToolStripButton();
            this.tbtnKetQuaKT = new System.Windows.Forms.ToolStripButton();
            this.btnDeKiemTra = new System.Windows.Forms.ToolStripButton();
            this.btnNoiDung = new System.Windows.Forms.ToolStripButton();
            this.btnDanhSachKT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnDangNhap = new System.Windows.Forms.ToolStripButton();
            this.tbtnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtTrangThai = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnThongTinCaNhan = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLi,
            this.mnuKiemTra,
            this.mnuBaoCaoTK,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuDoiMatKhau});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(106, 29);
            this.mnuHeThong.Text = "&Hệ Thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Image = global::WindowsFormsApp1.Properties.Resources.login16;
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(221, 34);
            this.mnuDangNhap.Text = "Đăng &NHập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = global::WindowsFormsApp1.Properties.Resources.logout16;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(221, 34);
            this.mnuDangXuat.Text = "Đăng &Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Image = global::WindowsFormsApp1.Properties.Resources.refresh16;
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(221, 34);
            this.mnuDoiMatKhau.Text = "Đổi &Mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuQuanLi
            // 
            this.mnuQuanLi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuGiaoVien,
            this.mnuHocSinh,
            this.mnuThongTinCaNhan});
            this.mnuQuanLi.Name = "mnuQuanLi";
            this.mnuQuanLi.Size = new System.Drawing.Size(84, 29);
            this.mnuQuanLi.Text = "&Quản lí";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Image = global::WindowsFormsApp1.Properties.Resources.key16;
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(270, 34);
            this.mnuTaiKhoan.Text = "&Tài Khoản";
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // mnuGiaoVien
            // 
            this.mnuGiaoVien.Image = global::WindowsFormsApp1.Properties.Resources.users32_2;
            this.mnuGiaoVien.Name = "mnuGiaoVien";
            this.mnuGiaoVien.Size = new System.Drawing.Size(270, 34);
            this.mnuGiaoVien.Text = "&Giáo Viên";
            this.mnuGiaoVien.Click += new System.EventHandler(this.mnuGiaoVien_Click);
            // 
            // mnuHocSinh
            // 
            this.mnuHocSinh.Image = global::WindowsFormsApp1.Properties.Resources.users32;
            this.mnuHocSinh.Name = "mnuHocSinh";
            this.mnuHocSinh.Size = new System.Drawing.Size(270, 34);
            this.mnuHocSinh.Text = "&Học Sinh";
            this.mnuHocSinh.Click += new System.EventHandler(this.mnuHocSinh_Click);
            // 
            // mnuThongTinCaNhan
            // 
            this.mnuThongTinCaNhan.Image = global::WindowsFormsApp1.Properties.Resources.user32_2;
            this.mnuThongTinCaNhan.Name = "mnuThongTinCaNhan";
            this.mnuThongTinCaNhan.Size = new System.Drawing.Size(270, 34);
            this.mnuThongTinCaNhan.Text = "Thông Tin &Cá Nhân";
            this.mnuThongTinCaNhan.Click += new System.EventHandler(this.mnuThongTinCaNhan_Click);
            // 
            // mnuKiemTra
            // 
            this.mnuKiemTra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeKT,
            this.mnuNoiDung,
            this.mnuLamBai});
            this.mnuKiemTra.Name = "mnuKiemTra";
            this.mnuKiemTra.Size = new System.Drawing.Size(93, 29);
            this.mnuKiemTra.Text = "&Kiểm tra";
            // 
            // mnuDeKT
            // 
            this.mnuDeKT.Image = global::WindowsFormsApp1.Properties.Resources.folder32_2;
            this.mnuDeKT.Name = "mnuDeKT";
            this.mnuDeKT.Size = new System.Drawing.Size(245, 34);
            this.mnuDeKT.Text = "Đề &Kiểm tra";
            this.mnuDeKT.Click += new System.EventHandler(this.mnuDeKT_Click);
            // 
            // mnuNoiDung
            // 
            this.mnuNoiDung.Image = global::WindowsFormsApp1.Properties.Resources.book32;
            this.mnuNoiDung.Name = "mnuNoiDung";
            this.mnuNoiDung.Size = new System.Drawing.Size(245, 34);
            this.mnuNoiDung.Text = "&Nội dung";
            this.mnuNoiDung.Click += new System.EventHandler(this.mnuNoiDung_Click);
            // 
            // mnuLamBai
            // 
            this.mnuLamBai.Image = global::WindowsFormsApp1.Properties.Resources.result32;
            this.mnuLamBai.Name = "mnuLamBai";
            this.mnuLamBai.Size = new System.Drawing.Size(245, 34);
            this.mnuLamBai.Text = "&Làm bài kiểm tra";
            this.mnuLamBai.Click += new System.EventHandler(this.mnuLamBai_Click);
            // 
            // mnuBaoCaoTK
            // 
            this.mnuBaoCaoTK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKetQuaKT,
            this.mnuDanhSachKT});
            this.mnuBaoCaoTK.Name = "mnuBaoCaoTK";
            this.mnuBaoCaoTK.Size = new System.Drawing.Size(88, 29);
            this.mnuBaoCaoTK.Text = "Kết &quả";
            // 
            // mnuKetQuaKT
            // 
            this.mnuKetQuaKT.Image = global::WindowsFormsApp1.Properties.Resources.pxnoitru;
            this.mnuKetQuaKT.Name = "mnuKetQuaKT";
            this.mnuKetQuaKT.Size = new System.Drawing.Size(265, 34);
            this.mnuKetQuaKT.Text = "&Kết Quả kiểm tra";
            this.mnuKetQuaKT.Click += new System.EventHandler(this.mnuKetQuaKT_Click);
            // 
            // mnuDanhSachKT
            // 
            this.mnuDanhSachKT.Image = global::WindowsFormsApp1.Properties.Resources.folderred32;
            this.mnuDanhSachKT.Name = "mnuDanhSachKT";
            this.mnuDanhSachKT.Size = new System.Drawing.Size(265, 34);
            this.mnuDanhSachKT.Text = "&Danh sách kiểm tra";
            this.mnuDanhSachKT.Click += new System.EventHandler(this.mnuDanhSachKT_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinPM});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(93, 29);
            this.mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuThongTinPM
            // 
            this.mnuThongTinPM.Image = global::WindowsFormsApp1.Properties.Resources.help16;
            this.mnuThongTinPM.Name = "mnuThongTinPM";
            this.mnuThongTinPM.Size = new System.Drawing.Size(281, 34);
            this.mnuThongTinPM.Text = "&Thông tin phần mềm";
            this.mnuThongTinPM.Click += new System.EventHandler(this.mnuThongTinPM_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThongTinCaNhan,
            this.tbtnLamBai,
            this.tbtnKetQuaKT,
            this.btnDeKiemTra,
            this.btnNoiDung,
            this.btnDanhSachKT,
            this.toolStripSeparator1,
            this.tbtnDangNhap,
            this.tbtnDangXuat,
            this.toolStripSeparator2,
            this.tbtnThoat,
            this.toolStripSeparator3,
            this.txtTrangThai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1188, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnLamBai
            // 
            this.tbtnLamBai.Image = global::WindowsFormsApp1.Properties.Resources.result32;
            this.tbtnLamBai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnLamBai.Name = "tbtnLamBai";
            this.tbtnLamBai.Size = new System.Drawing.Size(170, 29);
            this.tbtnLamBai.Text = "Làm Bài kiểm tra";
            this.tbtnLamBai.Click += new System.EventHandler(this.tbtnLamBai_Click);
            // 
            // tbtnKetQuaKT
            // 
            this.tbtnKetQuaKT.Image = global::WindowsFormsApp1.Properties.Resources.pxnoitru;
            this.tbtnKetQuaKT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnKetQuaKT.Name = "tbtnKetQuaKT";
            this.tbtnKetQuaKT.Size = new System.Drawing.Size(169, 29);
            this.tbtnKetQuaKT.Text = "Kết quả kiểm tra";
            this.tbtnKetQuaKT.Click += new System.EventHandler(this.tbtnKetQuaKT_Click);
            // 
            // btnDeKiemTra
            // 
            this.btnDeKiemTra.Image = global::WindowsFormsApp1.Properties.Resources.folder32_2;
            this.btnDeKiemTra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeKiemTra.Name = "btnDeKiemTra";
            this.btnDeKiemTra.Size = new System.Drawing.Size(133, 29);
            this.btnDeKiemTra.Text = "Đề Kiểm Tra";
            this.btnDeKiemTra.Click += new System.EventHandler(this.btnDeKiemTra_Click);
            // 
            // btnNoiDung
            // 
            this.btnNoiDung.Image = global::WindowsFormsApp1.Properties.Resources.book32;
            this.btnNoiDung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNoiDung.Name = "btnNoiDung";
            this.btnNoiDung.Size = new System.Drawing.Size(117, 29);
            this.btnNoiDung.Text = "Nội Dung";
            this.btnNoiDung.Click += new System.EventHandler(this.btnNoiDung_Click);
            // 
            // btnDanhSachKT
            // 
            this.btnDanhSachKT.Image = global::WindowsFormsApp1.Properties.Resources.folderred32;
            this.btnDanhSachKT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDanhSachKT.Name = "btnDanhSachKT";
            this.btnDanhSachKT.Size = new System.Drawing.Size(193, 29);
            this.btnDanhSachKT.Text = "Danh Sách kiểm tra";
            this.btnDanhSachKT.Click += new System.EventHandler(this.btnDanhSachKT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tbtnDangNhap
            // 
            this.tbtnDangNhap.Image = global::WindowsFormsApp1.Properties.Resources.login16;
            this.tbtnDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDangNhap.Name = "tbtnDangNhap";
            this.tbtnDangNhap.Size = new System.Drawing.Size(131, 29);
            this.tbtnDangNhap.Text = "Đăng Nhập";
            this.tbtnDangNhap.Click += new System.EventHandler(this.tbtnDangNhap_Click);
            // 
            // tbtnDangXuat
            // 
            this.tbtnDangXuat.Image = global::WindowsFormsApp1.Properties.Resources.logout16;
            this.tbtnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDangXuat.Name = "tbtnDangXuat";
            this.tbtnDangXuat.Size = new System.Drawing.Size(124, 29);
            this.tbtnDangXuat.Text = "Đăng Xuất";
            this.tbtnDangXuat.Click += new System.EventHandler(this.tbtnDangXuat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // tbtnThoat
            // 
            this.tbtnThoat.Image = global::WindowsFormsApp1.Properties.Resources.exit16;
            this.tbtnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnThoat.Name = "tbtnThoat";
            this.tbtnThoat.Size = new System.Drawing.Size(85, 29);
            this.tbtnThoat.Text = "Thoát";
            this.tbtnThoat.Click += new System.EventHandler(this.tbtnThoat_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(121, 28);
            this.txtTrangThai.Text = "Người Dùng";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 32);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 25);
            this.toolStripStatusLabel1.Text = "DPM195235";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(301, 25);
            this.toolStripStatusLabel2.Text = "lhphong_20pm@student.agu.edu.vn";
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Image = global::WindowsFormsApp1.Properties.Resources.user32_2;
            this.btnThongTinCaNhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(185, 29);
            this.btnThongTinCaNhan.Text = "Thông Tin cá nhân";
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1188, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống kiểm tra trắc nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLi;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mnuHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuKiemTra;
        private System.Windows.Forms.ToolStripMenuItem mnuDeKT;
        private System.Windows.Forms.ToolStripMenuItem mnuNoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuLamBai;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoTK;
        private System.Windows.Forms.ToolStripMenuItem mnuKetQuaKT;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhSachKT;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinPM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnLamBai;
        private System.Windows.Forms.ToolStripButton tbtnKetQuaKT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnDangXuat;
        private System.Windows.Forms.ToolStripButton tbtnDangNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel txtTrangThai;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripButton btnDeKiemTra;
        private System.Windows.Forms.ToolStripButton btnNoiDung;
        private System.Windows.Forms.ToolStripButton btnDanhSachKT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton btnThongTinCaNhan;
    }
}