namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class CapNhatThongTinNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panThongTinNhanVien = new System.Windows.Forms.Panel();
            this.dgvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTNV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.btnXoaTTNV = new System.Windows.Forms.Button();
            this.btnThemTTNV = new System.Windows.Forms.Button();
            this.btnBackTTNV = new System.Windows.Forms.Button();
            this.btnLuuTTNV = new System.Windows.Forms.Button();
            this.picThongTinNhanVien = new System.Windows.Forms.PictureBox();
            this.btnTimKiemTTNV = new System.Windows.Forms.Button();
            this.panThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panThongTinNhanVien
            // 
            this.panThongTinNhanVien.BackColor = System.Drawing.Color.Turquoise;
            this.panThongTinNhanVien.Controls.Add(this.dgvThongTinNhanVien);
            this.panThongTinNhanVien.Location = new System.Drawing.Point(64, 198);
            this.panThongTinNhanVien.Name = "panThongTinNhanVien";
            this.panThongTinNhanVien.Size = new System.Drawing.Size(1125, 518);
            this.panThongTinNhanVien.TabIndex = 28;
            // 
            // dgvThongTinNhanVien
            // 
            this.dgvThongTinNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinNhanVien.ColumnHeadersHeight = 40;
            this.dgvThongTinNhanVien.Location = new System.Drawing.Point(23, 17);
            this.dgvThongTinNhanVien.Name = "dgvThongTinNhanVien";
            this.dgvThongTinNhanVien.ReadOnly = true;
            this.dgvThongTinNhanVien.RowHeadersVisible = false;
            this.dgvThongTinNhanVien.Size = new System.Drawing.Size(1082, 486);
            this.dgvThongTinNhanVien.TabIndex = 0;
            // 
            // txtTimKiemTTNV
            // 
            this.txtTimKiemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTTNV.Location = new System.Drawing.Point(355, 22);
            this.txtTimKiemTTNV.Multiline = true;
            this.txtTimKiemTTNV.Name = "txtTimKiemTTNV";
            this.txtTimKiemTTNV.Size = new System.Drawing.Size(421, 37);
            this.txtTimKiemTTNV.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.b11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(151, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 153);
            this.panel1.TabIndex = 30;
            // 
            // btnHuyCapNhatLoaiPhong
            // 
            this.btnHuyCapNhatLoaiPhong.BackColor = System.Drawing.Color.Pink;
            this.btnHuyCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCapNhatLoaiPhong.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconHuy;
            this.btnHuyCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatLoaiPhong.Location = new System.Drawing.Point(813, 115);
            this.btnHuyCapNhatLoaiPhong.Name = "btnHuyCapNhatLoaiPhong";
            this.btnHuyCapNhatLoaiPhong.Size = new System.Drawing.Size(96, 40);
            this.btnHuyCapNhatLoaiPhong.TabIndex = 29;
            this.btnHuyCapNhatLoaiPhong.Text = "Hủy";
            this.btnHuyCapNhatLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            // 
            // btnXoaTTNV
            // 
            this.btnXoaTTNV.BackColor = System.Drawing.Color.Pink;
            this.btnXoaTTNV.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTTNV.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconDelete;
            this.btnXoaTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTTNV.Location = new System.Drawing.Point(514, 116);
            this.btnXoaTTNV.Name = "btnXoaTTNV";
            this.btnXoaTTNV.Size = new System.Drawing.Size(102, 39);
            this.btnXoaTTNV.TabIndex = 27;
            this.btnXoaTTNV.Text = "Xóa";
            this.btnXoaTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTTNV.UseVisualStyleBackColor = false;
            // 
            // btnThemTTNV
            // 
            this.btnThemTTNV.BackColor = System.Drawing.Color.Pink;
            this.btnThemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTTNV.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconThem;
            this.btnThemTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTTNV.Location = new System.Drawing.Point(355, 116);
            this.btnThemTTNV.Name = "btnThemTTNV";
            this.btnThemTTNV.Size = new System.Drawing.Size(98, 39);
            this.btnThemTTNV.TabIndex = 26;
            this.btnThemTTNV.Text = "Thêm";
            this.btnThemTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTTNV.UseVisualStyleBackColor = false;
            this.btnThemTTNV.Click += new System.EventHandler(this.btnThemTTNV_Click);
            // 
            // btnBackTTNV
            // 
            this.btnBackTTNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnBackTTNV.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTTNV.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconBack;
            this.btnBackTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackTTNV.Location = new System.Drawing.Point(12, 12);
            this.btnBackTTNV.Name = "btnBackTTNV";
            this.btnBackTTNV.Size = new System.Drawing.Size(84, 39);
            this.btnBackTTNV.TabIndex = 25;
            this.btnBackTTNV.Text = "Back";
            this.btnBackTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackTTNV.UseVisualStyleBackColor = false;
            this.btnBackTTNV.Click += new System.EventHandler(this.btnBackTTNV_Click);
            // 
            // btnLuuTTNV
            // 
            this.btnLuuTTNV.BackColor = System.Drawing.Color.Pink;
            this.btnLuuTTNV.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTTNV.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconLuu;
            this.btnLuuTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuTTNV.Location = new System.Drawing.Point(668, 116);
            this.btnLuuTTNV.Name = "btnLuuTTNV";
            this.btnLuuTTNV.Size = new System.Drawing.Size(101, 39);
            this.btnLuuTTNV.TabIndex = 24;
            this.btnLuuTTNV.Text = "Lưu";
            this.btnLuuTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuTTNV.UseVisualStyleBackColor = false;
            // 
            // picThongTinNhanVien
            // 
            this.picThongTinNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.picThongTinNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThongTinNhanVien.Location = new System.Drawing.Point(958, 12);
            this.picThongTinNhanVien.Name = "picThongTinNhanVien";
            this.picThongTinNhanVien.Size = new System.Drawing.Size(166, 150);
            this.picThongTinNhanVien.TabIndex = 23;
            this.picThongTinNhanVien.TabStop = false;
            // 
            // btnTimKiemTTNV
            // 
            this.btnTimKiemTTNV.BackColor = System.Drawing.Color.Pink;
            this.btnTimKiemTTNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTTNV.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconTimKiem;
            this.btnTimKiemTTNV.Location = new System.Drawing.Point(782, 22);
            this.btnTimKiemTTNV.Name = "btnTimKiemTTNV";
            this.btnTimKiemTTNV.Size = new System.Drawing.Size(143, 37);
            this.btnTimKiemTTNV.TabIndex = 21;
            this.btnTimKiemTTNV.Text = "Tìm Kiếm";
            this.btnTimKiemTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemTTNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiemTTNV.UseVisualStyleBackColor = false;
            // 
            // CapNhatThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1214, 748);
            this.Controls.Add(this.panThongTinNhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuyCapNhatLoaiPhong);
            this.Controls.Add(this.btnXoaTTNV);
            this.Controls.Add(this.btnThemTTNV);
            this.Controls.Add(this.btnBackTTNV);
            this.Controls.Add(this.btnLuuTTNV);
            this.Controls.Add(this.picThongTinNhanVien);
            this.Controls.Add(this.txtTimKiemTTNV);
            this.Controls.Add(this.btnTimKiemTTNV);
            this.Name = "CapNhatThongTinNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatThongTinNhanVien";
            this.Load += new System.EventHandler(this.CapNhatThongTinNhanVien_Load);
            this.panThongTinNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panThongTinNhanVien;
        private System.Windows.Forms.DataGridView dgvThongTinNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyCapNhatLoaiPhong;
        private System.Windows.Forms.Button btnXoaTTNV;
        private System.Windows.Forms.Button btnThemTTNV;
        private System.Windows.Forms.Button btnBackTTNV;
        private System.Windows.Forms.Button btnLuuTTNV;
        private System.Windows.Forms.PictureBox picThongTinNhanVien;
        private System.Windows.Forms.TextBox txtTimKiemTTNV;
        private System.Windows.Forms.Button btnTimKiemTTNV;
    }
}