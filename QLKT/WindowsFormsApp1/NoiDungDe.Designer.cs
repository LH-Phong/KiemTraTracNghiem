
namespace WindowsFormsApp1
{
    partial class NoiDungDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoiDungDe));
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
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCau = new System.Windows.Forms.TextBox();
            this.txtSoCau = new System.Windows.Forms.Label();
            this.cboDapAn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDapAn4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDapAn3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDapAn2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDapAn1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMaDe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDapAnChon = new System.Windows.Forms.TextBox();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 335);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(434, 301);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // MaDeThi
            // 
            this.MaDeThi.DataPropertyName = "MaDeThi";
            this.MaDeThi.HeaderText = "Mã Đề";
            this.MaDeThi.MinimumWidth = 8;
            this.MaDeThi.Name = "MaDeThi";
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
            // 
            // DapAn1
            // 
            this.DapAn1.DataPropertyName = "DapAn1";
            this.DapAn1.HeaderText = "Đáp Án 1";
            this.DapAn1.MinimumWidth = 8;
            this.DapAn1.Name = "DapAn1";
            // 
            // DapAn2
            // 
            this.DapAn2.DataPropertyName = "DapAn2";
            this.DapAn2.HeaderText = "Đáp Án 2";
            this.DapAn2.MinimumWidth = 8;
            this.DapAn2.Name = "DapAn2";
            // 
            // DapAn3
            // 
            this.DapAn3.DataPropertyName = "DapAn3";
            this.DapAn3.HeaderText = "Đáp Án 3";
            this.DapAn3.MinimumWidth = 8;
            this.DapAn3.Name = "DapAn3";
            // 
            // DapAn4
            // 
            this.DapAn4.DataPropertyName = "DapAn4";
            this.DapAn4.HeaderText = "Đáp Án 4";
            this.DapAn4.MinimumWidth = 8;
            this.DapAn4.Name = "DapAn4";
            // 
            // DapAnDung
            // 
            this.DapAnDung.DataPropertyName = "DapAnDung";
            this.DapAnDung.HeaderText = "Đáp Án Đúng";
            this.DapAnDung.MinimumWidth = 8;
            this.DapAnDung.Name = "DapAnDung";
            // 
            // DapAnDaChon
            // 
            this.DapAnDaChon.DataPropertyName = "DapAnDaChon";
            this.DapAnDaChon.HeaderText = "Đáp Án Đã Chọn";
            this.DapAnDaChon.MinimumWidth = 8;
            this.DapAnDaChon.Name = "DapAnDaChon";
            this.DapAnDaChon.Visible = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnDelete,
            this.btnUpdate,
            this.btnSave,
            this.btnExit});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(434, 34);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 29);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 29);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 29);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 29);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 29);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::WindowsFormsApp1.Properties.Resources.add16;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 29);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WindowsFormsApp1.Properties.Resources.delete16;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 29);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::WindowsFormsApp1.Properties.Resources.refresh16;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 29);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsApp1.Properties.Resources.save16;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 29);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WindowsFormsApp1.Properties.Resources.exit16;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 29);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.txtCau);
            this.panel2.Controls.Add(this.txtSoCau);
            this.panel2.Controls.Add(this.cboDapAn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDapAn4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDapAn3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDapAn2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDapAn1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtMaDe);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaGV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(452, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 533);
            this.panel2.TabIndex = 2;
            // 
            // txtCau
            // 
            this.txtCau.Location = new System.Drawing.Point(332, 11);
            this.txtCau.Name = "txtCau";
            this.txtCau.Size = new System.Drawing.Size(76, 26);
            this.txtCau.TabIndex = 33;
            // 
            // txtSoCau
            // 
            this.txtSoCau.AutoSize = true;
            this.txtSoCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCau.Location = new System.Drawing.Point(422, 13);
            this.txtSoCau.Name = "txtSoCau";
            this.txtSoCau.Size = new System.Drawing.Size(65, 22);
            this.txtSoCau.TabIndex = 32;
            this.txtSoCau.Text = "SoCau";
            // 
            // cboDapAn
            // 
            this.cboDapAn.FormattingEnabled = true;
            this.cboDapAn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboDapAn.Location = new System.Drawing.Point(359, 81);
            this.cboDapAn.Name = "cboDapAn";
            this.cboDapAn.Size = new System.Drawing.Size(102, 28);
            this.cboDapAn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Đáp Án:";
            // 
            // txtDapAn4
            // 
            this.txtDapAn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn4.Location = new System.Drawing.Point(7, 447);
            this.txtDapAn4.Multiline = true;
            this.txtDapAn4.Name = "txtDapAn4";
            this.txtDapAn4.Size = new System.Drawing.Size(515, 79);
            this.txtDapAn4.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Đáp Án 4:";
            // 
            // txtDapAn3
            // 
            this.txtDapAn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn3.Location = new System.Drawing.Point(7, 340);
            this.txtDapAn3.Multiline = true;
            this.txtDapAn3.Name = "txtDapAn3";
            this.txtDapAn3.Size = new System.Drawing.Size(515, 79);
            this.txtDapAn3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Đáp Án 3:";
            // 
            // txtDapAn2
            // 
            this.txtDapAn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn2.Location = new System.Drawing.Point(8, 233);
            this.txtDapAn2.Multiline = true;
            this.txtDapAn2.Name = "txtDapAn2";
            this.txtDapAn2.Size = new System.Drawing.Size(515, 79);
            this.txtDapAn2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Đáp Án 2:";
            // 
            // txtDapAn1
            // 
            this.txtDapAn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn1.Location = new System.Drawing.Point(7, 122);
            this.txtDapAn1.Multiline = true;
            this.txtDapAn1.Name = "txtDapAn1";
            this.txtDapAn1.Size = new System.Drawing.Size(515, 79);
            this.txtDapAn1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Đáp Án 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(41, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 1;
            // 
            // txtMaDe
            // 
            this.txtMaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDe.Enabled = false;
            this.txtMaDe.Location = new System.Drawing.Point(359, 47);
            this.txtMaDe.Name = "txtMaDe";
            this.txtMaDe.Size = new System.Drawing.Size(155, 26);
            this.txtMaDe.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã Đề:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Câu:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.AutoSize = true;
            this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaGV.Location = new System.Drawing.Point(132, 12);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(69, 25);
            this.txtMaGV.TabIndex = 2;
            this.txtMaGV.Text = "MaGV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Giáo Viên:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.txtDapAnChon);
            this.panel3.Controls.Add(this.txtCauHoi);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(8, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 225);
            this.panel3.TabIndex = 1;
            // 
            // txtDapAnChon
            // 
            this.txtDapAnChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDapAnChon.Location = new System.Drawing.Point(335, 4);
            this.txtDapAnChon.Name = "txtDapAnChon";
            this.txtDapAnChon.Size = new System.Drawing.Size(100, 26);
            this.txtDapAnChon.TabIndex = 18;
            this.txtDapAnChon.Visible = false;
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoi.Location = new System.Drawing.Point(4, 33);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(431, 189);
            this.txtCauHoi.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Câu Hỏi:";
            // 
            // NoiDungDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NoiDungDe";
            this.Text = "Nội dung đề kiểm tra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NoiDungDe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMaDe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDapAn4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDapAn3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDapAn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDapAn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDapAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDapAnChon;
        private System.Windows.Forms.Label txtSoCau;
        private System.Windows.Forms.TextBox txtCau;
    }
}