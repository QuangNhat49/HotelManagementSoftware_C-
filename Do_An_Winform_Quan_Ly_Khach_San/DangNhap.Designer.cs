namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class DangNhap
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
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.lblChuaCoTaiKhoan = new System.Windows.Forms.Label();
            this.btnQuenMatKhau = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.picMatKhau = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.picTenDangNhap = new System.Windows.Forms.PictureBox();
            this.pnlTenDangNhap = new System.Windows.Forms.Panel();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblDangNhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMatKhau.ForeColor = System.Drawing.Color.Peru;
            this.pnlMatKhau.Location = new System.Drawing.Point(69, 176);
            this.pnlMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(281, 2);
            this.pnlMatKhau.TabIndex = 24;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.IndianRed;
            this.btnDangKy.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(100, 423);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(166, 37);
            this.btnDangKy.TabIndex = 23;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lblChuaCoTaiKhoan
            // 
            this.lblChuaCoTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(237)))));
            this.lblChuaCoTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuaCoTaiKhoan.Location = new System.Drawing.Point(100, 394);
            this.lblChuaCoTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            this.lblChuaCoTaiKhoan.Size = new System.Drawing.Size(166, 27);
            this.lblChuaCoTaiKhoan.TabIndex = 22;
            this.lblChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            this.lblChuaCoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuenMatKhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMatKhau.Location = new System.Drawing.Point(100, 305);
            this.btnQuenMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(166, 37);
            this.btnQuenMatKhau.TabIndex = 21;
            this.btnQuenMatKhau.Text = "Quên mật khẩu";
            this.btnQuenMatKhau.UseVisualStyleBackColor = false;
            this.btnQuenMatKhau.Click += new System.EventHandler(this.btnQuenMatKhau_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(100, 263);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(166, 37);
            this.btnDangNhap.TabIndex = 20;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.BackgroundImage = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconShow;
            this.btnHienMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienMatKhau.FlatAppearance.BorderSize = 0;
            this.btnHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienMatKhau.Location = new System.Drawing.Point(325, 158);
            this.btnHienMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(26, 17);
            this.btnHienMatKhau.TabIndex = 19;
            this.btnHienMatKhau.UseVisualStyleBackColor = true;
            this.btnHienMatKhau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHienMatKhau_MouseDown);
            this.btnHienMatKhau.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHienMatKhau_MouseUp);
            // 
            // picMatKhau
            // 
            this.picMatKhau.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconPassword;
            this.picMatKhau.Location = new System.Drawing.Point(22, 147);
            this.picMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.picMatKhau.Name = "picMatKhau";
            this.picMatKhau.Size = new System.Drawing.Size(30, 31);
            this.picMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMatKhau.TabIndex = 18;
            this.picMatKhau.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(237)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(69, 147);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(251, 24);
            this.txtMatKhau.TabIndex = 17;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // picTenDangNhap
            // 
            this.picTenDangNhap.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconUser;
            this.picTenDangNhap.Location = new System.Drawing.Point(22, 92);
            this.picTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.picTenDangNhap.Name = "picTenDangNhap";
            this.picTenDangNhap.Size = new System.Drawing.Size(30, 31);
            this.picTenDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTenDangNhap.TabIndex = 16;
            this.picTenDangNhap.TabStop = false;
            // 
            // pnlTenDangNhap
            // 
            this.pnlTenDangNhap.BackColor = System.Drawing.Color.DarkRed;
            this.pnlTenDangNhap.ForeColor = System.Drawing.Color.Peru;
            this.pnlTenDangNhap.Location = new System.Drawing.Point(69, 115);
            this.pnlTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTenDangNhap.Name = "pnlTenDangNhap";
            this.pnlTenDangNhap.Size = new System.Drawing.Size(281, 2);
            this.pnlTenDangNhap.TabIndex = 15;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(237)))));
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.Location = new System.Drawing.Point(69, 92);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(281, 24);
            this.txtTenDangNhap.TabIndex = 14;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDangNhap.Location = new System.Drawing.Point(0, 0);
            this.lblDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(386, 58);
            this.lblDangNhap.TabIndex = 13;
            this.lblDangNhap.Text = "Đăng nhập";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(386, 631);
            this.Controls.Add(this.pnlMatKhau);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblChuaCoTaiKhoan);
            this.Controls.Add(this.btnQuenMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnHienMatKhau);
            this.Controls.Add(this.picMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.picTenDangNhap);
            this.Controls.Add(this.pnlTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblDangNhap);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMatKhau;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label lblChuaCoTaiKhoan;
        private System.Windows.Forms.Button btnQuenMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.PictureBox picMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.PictureBox picTenDangNhap;
        private System.Windows.Forms.Panel pnlTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblDangNhap;
    }
}

