namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class CapNhatDichVu
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
            this.dgvCapNhatDichVu = new System.Windows.Forms.DataGridView();
            this.btnXoaDichVu = new System.Windows.Forms.Button();
            this.btnThemDichVu = new System.Windows.Forms.Button();
            this.btnLuuCapNhatDichVu = new System.Windows.Forms.Button();
            this.btnThoatCapNhatDichVu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDichVuKhachSan = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtCapNhatDichVu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCapNhatDichVu
            // 
            this.dgvCapNhatDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatDichVu.Location = new System.Drawing.Point(26, 109);
            this.dgvCapNhatDichVu.Name = "dgvCapNhatDichVu";
            this.dgvCapNhatDichVu.ReadOnly = true;
            this.dgvCapNhatDichVu.Size = new System.Drawing.Size(542, 556);
            this.dgvCapNhatDichVu.TabIndex = 14;
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnXoaDichVu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDichVu.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconDelete;
            this.btnXoaDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDichVu.Location = new System.Drawing.Point(771, 219);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(166, 45);
            this.btnXoaDichVu.TabIndex = 13;
            this.btnXoaDichVu.Text = "Xóa Dịch Vụ";
            this.btnXoaDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDichVu.UseVisualStyleBackColor = false;
            this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnThemDichVu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDichVu.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconThem;
            this.btnThemDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDichVu.Location = new System.Drawing.Point(586, 219);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(175, 45);
            this.btnThemDichVu.TabIndex = 12;
            this.btnThemDichVu.Text = "Thêm Dịch Vụ";
            this.btnThemDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // btnLuuCapNhatDichVu
            // 
            this.btnLuuCapNhatDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnLuuCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatDichVu.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconLuu;
            this.btnLuuCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatDichVu.Location = new System.Drawing.Point(942, 219);
            this.btnLuuCapNhatDichVu.Name = "btnLuuCapNhatDichVu";
            this.btnLuuCapNhatDichVu.Size = new System.Drawing.Size(107, 45);
            this.btnLuuCapNhatDichVu.TabIndex = 11;
            this.btnLuuCapNhatDichVu.Text = "Lưu";
            this.btnLuuCapNhatDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatDichVu.UseVisualStyleBackColor = false;
            // 
            // btnThoatCapNhatDichVu
            // 
            this.btnThoatCapNhatDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnThoatCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCapNhatDichVu.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconBack;
            this.btnThoatCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCapNhatDichVu.Location = new System.Drawing.Point(12, 12);
            this.btnThoatCapNhatDichVu.Name = "btnThoatCapNhatDichVu";
            this.btnThoatCapNhatDichVu.Size = new System.Drawing.Size(111, 45);
            this.btnThoatCapNhatDichVu.TabIndex = 10;
            this.btnThoatCapNhatDichVu.Text = "Trở Về";
            this.btnThoatCapNhatDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCapNhatDichVu.UseVisualStyleBackColor = false;
            this.btnThoatCapNhatDichVu.Click += new System.EventHandler(this.btnThoatCapNhatDichVu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // lblDichVuKhachSan
            // 
            this.lblDichVuKhachSan.AutoSize = true;
            this.lblDichVuKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVuKhachSan.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVuKhachSan.Location = new System.Drawing.Point(323, 10);
            this.lblDichVuKhachSan.Name = "lblDichVuKhachSan";
            this.lblDichVuKhachSan.Size = new System.Drawing.Size(334, 47);
            this.lblDichVuKhachSan.TabIndex = 8;
            this.lblDichVuKhachSan.Text = "Dịch Vụ Khách Sạn";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(719, 156);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(330, 31);
            this.txtGia.TabIndex = 15;
            // 
            // txtCapNhatDichVu
            // 
            this.txtCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapNhatDichVu.Location = new System.Drawing.Point(719, 109);
            this.txtCapNhatDichVu.Multiline = true;
            this.txtCapNhatDichVu.Name = "txtCapNhatDichVu";
            this.txtCapNhatDichVu.Size = new System.Drawing.Size(330, 31);
            this.txtCapNhatDichVu.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá Dịch Vụ";
            // 
            // CapNhatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1087, 716);
            this.Controls.Add(this.dgvCapNhatDichVu);
            this.Controls.Add(this.btnXoaDichVu);
            this.Controls.Add(this.btnThemDichVu);
            this.Controls.Add(this.btnLuuCapNhatDichVu);
            this.Controls.Add(this.btnThoatCapNhatDichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDichVuKhachSan);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtCapNhatDichVu);
            this.Name = "CapNhatDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatDichVu";
            this.Load += new System.EventHandler(this.CapNhatDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapNhatDichVu;
        private System.Windows.Forms.Button btnXoaDichVu;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.Button btnLuuCapNhatDichVu;
        private System.Windows.Forms.Button btnThoatCapNhatDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDichVuKhachSan;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtCapNhatDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}