
namespace WindowsFormsApp1
{
    partial class ChonMaDe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamBai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMkDe = new System.Windows.Forms.TextBox();
            this.cboChonDe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.image;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn đề kiểm tra";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::WindowsFormsApp1.Properties.Resources.image;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn đề:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::WindowsFormsApp1.Properties.Resources.image;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(56, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu đề:";
            // 
            // btnLamBai
            // 
            this.btnLamBai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLamBai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamBai.ForeColor = System.Drawing.Color.Brown;
            this.btnLamBai.Location = new System.Drawing.Point(128, 355);
            this.btnLamBai.Name = "btnLamBai";
            this.btnLamBai.Size = new System.Drawing.Size(199, 57);
            this.btnLamBai.TabIndex = 5;
            this.btnLamBai.Text = "Làm Bài";
            this.btnLamBai.UseVisualStyleBackColor = false;
            this.btnLamBai.Click += new System.EventHandler(this.btnLamBai_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(467, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hủy Bỏ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMkDe
            // 
            this.txtMkDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMkDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMkDe.Location = new System.Drawing.Point(87, 271);
            this.txtMkDe.Name = "txtMkDe";
            this.txtMkDe.Size = new System.Drawing.Size(624, 44);
            this.txtMkDe.TabIndex = 10;
            // 
            // cboChonDe
            // 
            this.cboChonDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboChonDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonDe.FormattingEnabled = true;
            this.cboChonDe.Location = new System.Drawing.Point(87, 169);
            this.cboChonDe.Name = "cboChonDe";
            this.cboChonDe.Size = new System.Drawing.Size(624, 45);
            this.cboChonDe.TabIndex = 11;
            // 
            // ChonMaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboChonDe);
            this.Controls.Add(this.txtMkDe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLamBai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChonMaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChonMaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamBai;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtMkDe;
        public System.Windows.Forms.ComboBox cboChonDe;
    }
}