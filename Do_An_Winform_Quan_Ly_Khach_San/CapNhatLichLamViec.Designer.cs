namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class CapNhatLichLamViec
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
            this.btnXemLai = new System.Windows.Forms.Button();
            this.tbXemLai = new System.Windows.Forms.TextBox();
            this.lblLichLamViec = new System.Windows.Forms.Label();
            this.cbxTenNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.cbxCa = new System.Windows.Forms.ComboBox();
            this.dgvCapNhatLichLamViec = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaLichLamViec = new System.Windows.Forms.Button();
            this.btnXoaLichLamViec = new System.Windows.Forms.Button();
            this.btnThemLichLamViec = new System.Windows.Forms.Button();
            this.btnTroVeCuaCapNhatLichLamViec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Xem Lại Lịch Làm Việc Theo Ngày";
            // 
            // btnXemLai
            // 
            this.btnXemLai.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnXemLai.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLai.Location = new System.Drawing.Point(237, 156);
            this.btnXemLai.Name = "btnXemLai";
            this.btnXemLai.Size = new System.Drawing.Size(105, 41);
            this.btnXemLai.TabIndex = 26;
            this.btnXemLai.Text = "Xem Lại";
            this.btnXemLai.UseVisualStyleBackColor = false;
            // 
            // tbXemLai
            // 
            this.tbXemLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXemLai.Location = new System.Drawing.Point(34, 166);
            this.tbXemLai.Multiline = true;
            this.tbXemLai.Name = "tbXemLai";
            this.tbXemLai.Size = new System.Drawing.Size(185, 31);
            this.tbXemLai.TabIndex = 25;
            // 
            // lblLichLamViec
            // 
            this.lblLichLamViec.AutoSize = true;
            this.lblLichLamViec.BackColor = System.Drawing.Color.Transparent;
            this.lblLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichLamViec.Location = new System.Drawing.Point(331, 13);
            this.lblLichLamViec.Name = "lblLichLamViec";
            this.lblLichLamViec.Size = new System.Drawing.Size(525, 44);
            this.lblLichLamViec.TabIndex = 20;
            this.lblLichLamViec.Text = "Lịch Làm Việc Toàn Bộ Nhân Viên";
            // 
            // cbxTenNV
            // 
            this.cbxTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenNV.FormattingEnabled = true;
            this.cbxTenNV.Location = new System.Drawing.Point(932, 234);
            this.cbxTenNV.Name = "cbxTenNV";
            this.cbxTenNV.Size = new System.Drawing.Size(223, 28);
            this.cbxTenNV.TabIndex = 30;
            // 
            // dtpNgayLamViec
            // 
            this.dtpNgayLamViec.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLamViec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLamViec.Location = new System.Drawing.Point(932, 444);
            this.dtpNgayLamViec.Name = "dtpNgayLamViec";
            this.dtpNgayLamViec.Size = new System.Drawing.Size(223, 27);
            this.dtpNgayLamViec.TabIndex = 29;
            // 
            // cbxCa
            // 
            this.cbxCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCa.FormattingEnabled = true;
            this.cbxCa.Location = new System.Drawing.Point(932, 335);
            this.cbxCa.Name = "cbxCa";
            this.cbxCa.Size = new System.Drawing.Size(223, 28);
            this.cbxCa.TabIndex = 28;
            // 
            // dgvCapNhatLichLamViec
            // 
            this.dgvCapNhatLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenNV,
            this.ca,
            this.ngay,
            this.id});
            this.dgvCapNhatLichLamViec.Location = new System.Drawing.Point(34, 234);
            this.dgvCapNhatLichLamViec.Name = "dgvCapNhatLichLamViec";
            this.dgvCapNhatLichLamViec.Size = new System.Drawing.Size(844, 444);
            this.dgvCapNhatLichLamViec.TabIndex = 31;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // tenNV
            // 
            this.tenNV.HeaderText = "Tên Nhân Viên";
            this.tenNV.Name = "tenNV";
            // 
            // ca
            // 
            this.ca.HeaderText = "Ca";
            this.ca.Name = "ca";
            // 
            // ngay
            // 
            this.ngay.HeaderText = "Ngày Làm Việc";
            this.ngay.Name = "ngay";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // btnSuaLichLamViec
            // 
            this.btnSuaLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSuaLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLichLamViec.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconSuaaaaa;
            this.btnSuaLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLichLamViec.Location = new System.Drawing.Point(782, 158);
            this.btnSuaLichLamViec.Name = "btnSuaLichLamViec";
            this.btnSuaLichLamViec.Size = new System.Drawing.Size(96, 41);
            this.btnSuaLichLamViec.TabIndex = 24;
            this.btnSuaLichLamViec.Text = "Sửa ";
            this.btnSuaLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaLichLamViec.UseVisualStyleBackColor = false;
            // 
            // btnXoaLichLamViec
            // 
            this.btnXoaLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnXoaLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLichLamViec.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconDelete;
            this.btnXoaLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLichLamViec.Location = new System.Drawing.Point(609, 156);
            this.btnXoaLichLamViec.Name = "btnXoaLichLamViec";
            this.btnXoaLichLamViec.Size = new System.Drawing.Size(95, 41);
            this.btnXoaLichLamViec.TabIndex = 23;
            this.btnXoaLichLamViec.Text = "Xóa ";
            this.btnXoaLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLichLamViec.UseVisualStyleBackColor = false;
            // 
            // btnThemLichLamViec
            // 
            this.btnThemLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnThemLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLichLamViec.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconThem;
            this.btnThemLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLichLamViec.Location = new System.Drawing.Point(430, 158);
            this.btnThemLichLamViec.Name = "btnThemLichLamViec";
            this.btnThemLichLamViec.Size = new System.Drawing.Size(105, 41);
            this.btnThemLichLamViec.TabIndex = 22;
            this.btnThemLichLamViec.Text = "Thêm ";
            this.btnThemLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLichLamViec.UseVisualStyleBackColor = false;
            this.btnThemLichLamViec.Click += new System.EventHandler(this.btnThemLichLamViec_Click);
            // 
            // btnTroVeCuaCapNhatLichLamViec
            // 
            this.btnTroVeCuaCapNhatLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnTroVeCuaCapNhatLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCapNhatLichLamViec.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconBack;
            this.btnTroVeCuaCapNhatLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCapNhatLichLamViec.Location = new System.Drawing.Point(12, 12);
            this.btnTroVeCuaCapNhatLichLamViec.Name = "btnTroVeCuaCapNhatLichLamViec";
            this.btnTroVeCuaCapNhatLichLamViec.Size = new System.Drawing.Size(101, 45);
            this.btnTroVeCuaCapNhatLichLamViec.TabIndex = 21;
            this.btnTroVeCuaCapNhatLichLamViec.Text = "Trở về";
            this.btnTroVeCuaCapNhatLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCapNhatLichLamViec.UseVisualStyleBackColor = false;
            this.btnTroVeCuaCapNhatLichLamViec.Click += new System.EventHandler(this.btnTroVeCuaCapNhatLichLamViec_Click);
            // 
            // CapNhatLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1218, 725);
            this.Controls.Add(this.dgvCapNhatLichLamViec);
            this.Controls.Add(this.cbxTenNV);
            this.Controls.Add(this.dtpNgayLamViec);
            this.Controls.Add(this.cbxCa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemLai);
            this.Controls.Add(this.tbXemLai);
            this.Controls.Add(this.btnSuaLichLamViec);
            this.Controls.Add(this.btnXoaLichLamViec);
            this.Controls.Add(this.btnThemLichLamViec);
            this.Controls.Add(this.btnTroVeCuaCapNhatLichLamViec);
            this.Controls.Add(this.lblLichLamViec);
            this.Name = "CapNhatLichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatLichLamViec";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemLai;
        private System.Windows.Forms.TextBox tbXemLai;
        private System.Windows.Forms.Button btnSuaLichLamViec;
        private System.Windows.Forms.Button btnXoaLichLamViec;
        private System.Windows.Forms.Button btnThemLichLamViec;
        private System.Windows.Forms.Button btnTroVeCuaCapNhatLichLamViec;
        private System.Windows.Forms.Label lblLichLamViec;
        private System.Windows.Forms.ComboBox cbxTenNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLamViec;
        private System.Windows.Forms.ComboBox cbxCa;
        private System.Windows.Forms.DataGridView dgvCapNhatLichLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}