
namespace WindowsFormsApp1
{
    partial class LamBai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LamBai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDeThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAnDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAnDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThoiGian = new System.Windows.Forms.Label();
            this.txtMaDe = new System.Windows.Forms.Label();
            this.txtCau = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDapAn4 = new System.Windows.Forms.TextBox();
            this.txtDapAn3 = new System.Windows.Forms.TextBox();
            this.txtDapAn2 = new System.Windows.Forms.TextBox();
            this.txtDapAn1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDapAn4 = new System.Windows.Forms.CheckBox();
            this.chkDapAn3 = new System.Windows.Forms.CheckBox();
            this.chkDapAn2 = new System.Windows.Forms.CheckBox();
            this.chkDapAn1 = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.txtTimer = new System.Windows.Forms.Label();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.txtTenDe = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTimer2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 465);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaDeThi,
            this.CauSo,
            this.CauHoi,
            this.DapAn1,
            this.DapAn2,
            this.DapAn3,
            this.DapAn4,
            this.DapAnDung,
            this.DapAnDaChon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(229, 432);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // MaDeThi
            // 
            this.MaDeThi.DataPropertyName = "MaDeThi";
            this.MaDeThi.HeaderText = "Mã Đề Thi";
            this.MaDeThi.MinimumWidth = 8;
            this.MaDeThi.Name = "MaDeThi";
            this.MaDeThi.Visible = false;
            // 
            // CauSo
            // 
            this.CauSo.DataPropertyName = "CauSo";
            this.CauSo.HeaderText = "Câu";
            this.CauSo.MinimumWidth = 8;
            this.CauSo.Name = "CauSo";
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "CauHoi";
            this.CauHoi.HeaderText = "Câu Hỏi";
            this.CauHoi.MinimumWidth = 8;
            this.CauHoi.Name = "CauHoi";
            this.CauHoi.Visible = false;
            // 
            // DapAn1
            // 
            this.DapAn1.DataPropertyName = "DapAn1";
            this.DapAn1.HeaderText = "Đáp án 1";
            this.DapAn1.MinimumWidth = 8;
            this.DapAn1.Name = "DapAn1";
            this.DapAn1.Visible = false;
            // 
            // DapAn2
            // 
            this.DapAn2.DataPropertyName = "DapAn2";
            this.DapAn2.HeaderText = "Đáp án 2";
            this.DapAn2.MinimumWidth = 8;
            this.DapAn2.Name = "DapAn2";
            this.DapAn2.Visible = false;
            // 
            // DapAn3
            // 
            this.DapAn3.DataPropertyName = "DapAn3";
            this.DapAn3.HeaderText = "Đáp án 3";
            this.DapAn3.MinimumWidth = 8;
            this.DapAn3.Name = "DapAn3";
            this.DapAn3.Visible = false;
            // 
            // DapAn4
            // 
            this.DapAn4.DataPropertyName = "DapAn4";
            this.DapAn4.HeaderText = "Đáp án 4";
            this.DapAn4.MinimumWidth = 8;
            this.DapAn4.Name = "DapAn4";
            this.DapAn4.Visible = false;
            // 
            // DapAnDung
            // 
            this.DapAnDung.DataPropertyName = "DapAnDung";
            this.DapAnDung.HeaderText = "Đáp Án đúng";
            this.DapAnDung.MinimumWidth = 8;
            this.DapAnDung.Name = "DapAnDung";
            this.DapAnDung.Visible = false;
            // 
            // DapAnDaChon
            // 
            this.DapAnDaChon.DataPropertyName = "DapAnDaChon";
            this.DapAnDaChon.HeaderText = "Chọn";
            this.DapAnDaChon.MinimumWidth = 8;
            this.DapAnDaChon.Name = "DapAnDaChon";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(229, 33);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCauHoi);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtCau);
            this.panel2.Location = new System.Drawing.Point(247, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 230);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Câu";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCauHoi.BackColor = System.Drawing.Color.White;
            this.txtCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoi.Location = new System.Drawing.Point(117, 114);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(443, 113);
            this.txtCauHoi.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.txtThoiGian);
            this.groupBox1.Controls.Add(this.txtMaDe);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThoiGian.AutoSize = true;
            this.txtThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Location = new System.Drawing.Point(240, 62);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(127, 29);
            this.txtThoiGian.TabIndex = 1;
            this.txtThoiGian.Text = "Thời Gian";
            this.txtThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDe
            // 
            this.txtMaDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaDe.AutoSize = true;
            this.txtMaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDe.Location = new System.Drawing.Point(240, 22);
            this.txtMaDe.Name = "txtMaDe";
            this.txtMaDe.Size = new System.Drawing.Size(81, 29);
            this.txtMaDe.TabIndex = 0;
            this.txtMaDe.Text = "MaDe";
            this.txtMaDe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCau
            // 
            this.txtCau.AutoSize = true;
            this.txtCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCau.Location = new System.Drawing.Point(56, 114);
            this.txtCau.Name = "txtCau";
            this.txtCau.Size = new System.Drawing.Size(55, 26);
            this.txtCau.TabIndex = 0;
            this.txtCau.Text = "Câu";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(249, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 92);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtDapAn4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDapAn3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDapAn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDapAn1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 92);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDapAn4
            // 
            this.txtDapAn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDapAn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDapAn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDapAn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn4.Location = new System.Drawing.Point(392, 49);
            this.txtDapAn4.Multiline = true;
            this.txtDapAn4.Name = "txtDapAn4";
            this.txtDapAn4.Size = new System.Drawing.Size(384, 40);
            this.txtDapAn4.TabIndex = 3;
            this.txtDapAn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDapAn4.Click += new System.EventHandler(this.txtDapAn4_Click);
            // 
            // txtDapAn3
            // 
            this.txtDapAn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDapAn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDapAn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDapAn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn3.Location = new System.Drawing.Point(3, 49);
            this.txtDapAn3.Multiline = true;
            this.txtDapAn3.Name = "txtDapAn3";
            this.txtDapAn3.Size = new System.Drawing.Size(383, 40);
            this.txtDapAn3.TabIndex = 2;
            this.txtDapAn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDapAn3.Click += new System.EventHandler(this.txtDapAn3_Click);
            // 
            // txtDapAn2
            // 
            this.txtDapAn2.BackColor = System.Drawing.Color.LightGreen;
            this.txtDapAn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDapAn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDapAn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn2.Location = new System.Drawing.Point(392, 3);
            this.txtDapAn2.Multiline = true;
            this.txtDapAn2.Name = "txtDapAn2";
            this.txtDapAn2.Size = new System.Drawing.Size(384, 40);
            this.txtDapAn2.TabIndex = 1;
            this.txtDapAn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDapAn2.Click += new System.EventHandler(this.txtDapAn2_Click);
            // 
            // txtDapAn1
            // 
            this.txtDapAn1.BackColor = System.Drawing.Color.SkyBlue;
            this.txtDapAn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDapAn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDapAn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn1.Location = new System.Drawing.Point(3, 3);
            this.txtDapAn1.Multiline = true;
            this.txtDapAn1.Name = "txtDapAn1";
            this.txtDapAn1.Size = new System.Drawing.Size(383, 40);
            this.txtDapAn1.TabIndex = 0;
            this.txtDapAn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDapAn1.Click += new System.EventHandler(this.txtDapAn1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(813, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 169);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.DongHo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.chkDapAn4);
            this.panel5.Controls.Add(this.chkDapAn3);
            this.panel5.Controls.Add(this.chkDapAn2);
            this.panel5.Controls.Add(this.chkDapAn1);
            this.panel5.Location = new System.Drawing.Point(249, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(779, 76);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn đáp án";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkDapAn4
            // 
            this.chkDapAn4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkDapAn4.AutoSize = true;
            this.chkDapAn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkDapAn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDapAn4.Location = new System.Drawing.Point(515, 3);
            this.chkDapAn4.Name = "chkDapAn4";
            this.chkDapAn4.Size = new System.Drawing.Size(85, 36);
            this.chkDapAn4.TabIndex = 3;
            this.chkDapAn4.Text = "    4";
            this.chkDapAn4.UseVisualStyleBackColor = false;
            this.chkDapAn4.Click += new System.EventHandler(this.chkDapAn4_Click);
            // 
            // chkDapAn3
            // 
            this.chkDapAn3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkDapAn3.AutoSize = true;
            this.chkDapAn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chkDapAn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDapAn3.Location = new System.Drawing.Point(411, 3);
            this.chkDapAn3.Name = "chkDapAn3";
            this.chkDapAn3.Size = new System.Drawing.Size(85, 36);
            this.chkDapAn3.TabIndex = 2;
            this.chkDapAn3.Text = "    3";
            this.chkDapAn3.UseVisualStyleBackColor = false;
            this.chkDapAn3.Click += new System.EventHandler(this.chkDapAn3_Click);
            // 
            // chkDapAn2
            // 
            this.chkDapAn2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkDapAn2.AutoSize = true;
            this.chkDapAn2.BackColor = System.Drawing.Color.LightGreen;
            this.chkDapAn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDapAn2.Location = new System.Drawing.Point(307, 3);
            this.chkDapAn2.Name = "chkDapAn2";
            this.chkDapAn2.Size = new System.Drawing.Size(85, 36);
            this.chkDapAn2.TabIndex = 1;
            this.chkDapAn2.Text = "    2";
            this.chkDapAn2.UseVisualStyleBackColor = false;
            this.chkDapAn2.Click += new System.EventHandler(this.chkDapAn2_Click);
            // 
            // chkDapAn1
            // 
            this.chkDapAn1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkDapAn1.AutoSize = true;
            this.chkDapAn1.BackColor = System.Drawing.Color.SkyBlue;
            this.chkDapAn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDapAn1.Location = new System.Drawing.Point(203, 3);
            this.chkDapAn1.Name = "chkDapAn1";
            this.chkDapAn1.Size = new System.Drawing.Size(85, 36);
            this.chkDapAn1.TabIndex = 0;
            this.chkDapAn1.Text = "   1 ";
            this.chkDapAn1.UseVisualStyleBackColor = false;
            this.chkDapAn1.Click += new System.EventHandler(this.chkDapAn1_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.txtTimer);
            this.panel.Location = new System.Drawing.Point(816, 54);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(210, 67);
            this.panel.TabIndex = 5;
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.Red;
            this.txtTimer.Location = new System.Drawing.Point(57, 10);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(108, 46);
            this.txtTimer.TabIndex = 0;
            this.txtTimer.Text = "Time";
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNopBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.Location = new System.Drawing.Point(239, 12);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(188, 51);
            this.btnNopBai.TabIndex = 6;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // txtTenDe
            // 
            this.txtTenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDe.AutoSize = true;
            this.txtTenDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDe.Location = new System.Drawing.Point(464, 22);
            this.txtTenDe.Name = "txtTenDe";
            this.txtTenDe.Size = new System.Drawing.Size(92, 29);
            this.txtTenDe.TabIndex = 2;
            this.txtTenDe.Text = "TenDe";
            this.txtTenDe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.txtTimer2);
            this.panel7.Location = new System.Drawing.Point(815, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(210, 46);
            this.panel7.TabIndex = 6;
            this.panel7.Visible = false;
            // 
            // txtTimer2
            // 
            this.txtTimer2.AutoSize = true;
            this.txtTimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer2.ForeColor = System.Drawing.Color.Red;
            this.txtTimer2.Location = new System.Drawing.Point(80, 4);
            this.txtTimer2.Name = "txtTimer2";
            this.txtTimer2.Size = new System.Drawing.Size(56, 25);
            this.txtTimer2.TabIndex = 0;
            this.txtTimer2.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1037, 489);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtTenDe);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LamBai";
            this.Text = "Kiểm Tra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LamBai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtCau;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtThoiGian;
        private System.Windows.Forms.Label txtMaDe;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDapAn4;
        private System.Windows.Forms.TextBox txtDapAn3;
        private System.Windows.Forms.TextBox txtDapAn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.CheckBox chkDapAn4;
        private System.Windows.Forms.CheckBox chkDapAn3;
        private System.Windows.Forms.CheckBox chkDapAn2;
        private System.Windows.Forms.CheckBox chkDapAn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Label txtTenDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label txtTimer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDeThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAnDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAnDaChon;
        private System.Windows.Forms.TextBox txtDapAn1;
    }
}