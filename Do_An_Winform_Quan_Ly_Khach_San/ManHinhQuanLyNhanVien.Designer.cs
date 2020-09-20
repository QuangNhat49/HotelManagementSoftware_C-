namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class ManHinhQuanLyNhanVien
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
            this.pnlQuanLyNhanVien = new System.Windows.Forms.Panel();
            this.btnCapNhatLichLamViecNV = new System.Windows.Forms.Button();
            this.btnCapNhatThongTinNV = new System.Windows.Forms.Button();
            this.pnlQLNV = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.cdrQLNV = new System.Windows.Forms.MonthCalendar();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.btnTroVeCuaQLNV = new System.Windows.Forms.Button();
            this.pnlQuanLyNhanVien.SuspendLayout();
            this.pnlQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuanLyNhanVien
            // 
            this.pnlQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.pnlQuanLyNhanVien.Controls.Add(this.btnCapNhatLichLamViecNV);
            this.pnlQuanLyNhanVien.Controls.Add(this.btnCapNhatThongTinNV);
            this.pnlQuanLyNhanVien.Location = new System.Drawing.Point(54, 117);
            this.pnlQuanLyNhanVien.Name = "pnlQuanLyNhanVien";
            this.pnlQuanLyNhanVien.Size = new System.Drawing.Size(225, 161);
            this.pnlQuanLyNhanVien.TabIndex = 6;
            // 
            // btnCapNhatLichLamViecNV
            // 
            this.btnCapNhatLichLamViecNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatLichLamViecNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLichLamViecNV.Location = new System.Drawing.Point(3, 89);
            this.btnCapNhatLichLamViecNV.Name = "btnCapNhatLichLamViecNV";
            this.btnCapNhatLichLamViecNV.Size = new System.Drawing.Size(219, 46);
            this.btnCapNhatLichLamViecNV.TabIndex = 2;
            this.btnCapNhatLichLamViecNV.Text = "Cập nhật lịch làm việc";
            this.btnCapNhatLichLamViecNV.UseVisualStyleBackColor = false;
            this.btnCapNhatLichLamViecNV.Click += new System.EventHandler(this.btnCapNhatLichLamViecNV_Click);
            // 
            // btnCapNhatThongTinNV
            // 
            this.btnCapNhatThongTinNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatThongTinNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThongTinNV.Location = new System.Drawing.Point(3, 15);
            this.btnCapNhatThongTinNV.Name = "btnCapNhatThongTinNV";
            this.btnCapNhatThongTinNV.Size = new System.Drawing.Size(219, 46);
            this.btnCapNhatThongTinNV.TabIndex = 0;
            this.btnCapNhatThongTinNV.Text = "Cập nhật thông tin nhân viên";
            this.btnCapNhatThongTinNV.UseVisualStyleBackColor = false;
            this.btnCapNhatThongTinNV.Click += new System.EventHandler(this.btnCapNhatThongTinNV_Click);
            // 
            // pnlQLNV
            // 
            this.pnlQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.pnlQLNV.Controls.Add(this.label2);
            this.pnlQLNV.Controls.Add(this.dgvLichLamViec);
            this.pnlQLNV.Location = new System.Drawing.Point(307, 117);
            this.pnlQLNV.Name = "pnlQLNV";
            this.pnlQLNV.Size = new System.Drawing.Size(898, 557);
            this.pnlQLNV.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lịch Làm Việc Toàn Bộ Nhân Viên";
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Location = new System.Drawing.Point(15, 55);
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            this.dgvLichLamViec.RowHeadersWidth = 51;
            this.dgvLichLamViec.RowTemplate.Height = 24;
            this.dgvLichLamViec.Size = new System.Drawing.Size(860, 384);
            this.dgvLichLamViec.TabIndex = 0;
            this.dgvLichLamViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichLamViec_CellContentClick);
            // 
            // cdrQLNV
            // 
            this.cdrQLNV.Location = new System.Drawing.Point(78, 301);
            this.cdrQLNV.Name = "cdrQLNV";
            this.cdrQLNV.TabIndex = 8;
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(454, 12);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(340, 39);
            this.lblQuanLyNhanVien.TabIndex = 7;
            this.lblQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnTroVeCuaQLNV
            // 
            this.btnTroVeCuaQLNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnTroVeCuaQLNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLNV.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconBack;
            this.btnTroVeCuaQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLNV.Location = new System.Drawing.Point(12, 12);
            this.btnTroVeCuaQLNV.Name = "btnTroVeCuaQLNV";
            this.btnTroVeCuaQLNV.Size = new System.Drawing.Size(94, 46);
            this.btnTroVeCuaQLNV.TabIndex = 10;
            this.btnTroVeCuaQLNV.Text = "Trở về";
            this.btnTroVeCuaQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLNV.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLNV.Click += new System.EventHandler(this.btnTroVeCuaQLNV_Click);
            // 
            // ManHinhQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1229, 705);
            this.Controls.Add(this.pnlQuanLyNhanVien);
            this.Controls.Add(this.btnTroVeCuaQLNV);
            this.Controls.Add(this.pnlQLNV);
            this.Controls.Add(this.cdrQLNV);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Name = "ManHinhQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhQuanLyNhanVien";
            this.Load += new System.EventHandler(this.ManHinhQuanLyNhanVien_Load);
            this.pnlQuanLyNhanVien.ResumeLayout(false);
            this.pnlQLNV.ResumeLayout(false);
            this.pnlQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyNhanVien;
        private System.Windows.Forms.Button btnCapNhatLichLamViecNV;
        private System.Windows.Forms.Button btnCapNhatThongTinNV;
        private System.Windows.Forms.Panel pnlQLNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.MonthCalendar cdrQLNV;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.Button btnTroVeCuaQLNV;
    }
}