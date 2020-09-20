namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class ManHinhQuanLyKhachHang
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
            this.dgvQuanLyKhachHang = new System.Windows.Forms.DataGridView();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnHuyCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTroVeCuaQLKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLyKhachHang
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuanLyKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanLyKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKhachHang.Location = new System.Drawing.Point(30, 231);
            this.dgvQuanLyKhachHang.Name = "dgvQuanLyKhachHang";
            this.dgvQuanLyKhachHang.RowHeadersVisible = false;
            this.dgvQuanLyKhachHang.RowTemplate.Height = 24;
            this.dgvQuanLyKhachHang.Size = new System.Drawing.Size(1132, 455);
            this.dgvQuanLyKhachHang.TabIndex = 30;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayDi.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(721, 113);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(95, 24);
            this.lblNgayDi.TabIndex = 27;
            this.lblNgayDi.Text = "Đến Ngày";
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayDen.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.Location = new System.Drawing.Point(405, 113);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(84, 24);
            this.lblNgayDen.TabIndex = 26;
            this.lblNgayDen.Text = "Từ Ngày";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(409, 58);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(536, 31);
            this.txtTimKiem.TabIndex = 23;
            // 
            // btnHuyCapNhatLoaiPhong
            // 
            this.btnHuyCapNhatLoaiPhong.BackColor = System.Drawing.Color.Pink;
            this.btnHuyCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold);
            this.btnHuyCapNhatLoaiPhong.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconHuy;
            this.btnHuyCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatLoaiPhong.Location = new System.Drawing.Point(991, 168);
            this.btnHuyCapNhatLoaiPhong.Name = "btnHuyCapNhatLoaiPhong";
            this.btnHuyCapNhatLoaiPhong.Size = new System.Drawing.Size(91, 40);
            this.btnHuyCapNhatLoaiPhong.TabIndex = 32;
            this.btnHuyCapNhatLoaiPhong.Text = "Hủy";
            this.btnHuyCapNhatLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.b15;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(242, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 146);
            this.panel1.TabIndex = 31;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(822, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 27);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Location = new System.Drawing.Point(495, 110);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(123, 27);
            this.dtpTuNgay.TabIndex = 29;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Pink;
            this.btnLoc.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconLoc;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(991, 110);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(91, 37);
            this.btnLoc.TabIndex = 25;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Pink;
            this.btnTimKiem.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconTimKiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(991, 55);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 37);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTroVeCuaQLKH
            // 
            this.btnTroVeCuaQLKH.BackColor = System.Drawing.Color.Pink;
            this.btnTroVeCuaQLKH.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLKH.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconBack;
            this.btnTroVeCuaQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLKH.Location = new System.Drawing.Point(12, 12);
            this.btnTroVeCuaQLKH.Name = "btnTroVeCuaQLKH";
            this.btnTroVeCuaQLKH.Size = new System.Drawing.Size(110, 37);
            this.btnTroVeCuaQLKH.TabIndex = 22;
            this.btnTroVeCuaQLKH.Text = "Trở về";
            this.btnTroVeCuaQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLKH.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLKH.Click += new System.EventHandler(this.btnTroVeCuaQLKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 47);
            this.label1.TabIndex = 33;
            this.label1.Text = "Quản Lý Khách Hàng";
            // 
            // ManHinhQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQuanLyKhachHang);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.lblNgayDen);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnHuyCapNhatLoaiPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTroVeCuaQLKH);
            this.Name = "ManHinhQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhQuanLyKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManHinhQuanLyKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.ManHinhQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyKhachHang;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnHuyCapNhatLoaiPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTroVeCuaQLKH;
        private System.Windows.Forms.Label label1;
    }
}