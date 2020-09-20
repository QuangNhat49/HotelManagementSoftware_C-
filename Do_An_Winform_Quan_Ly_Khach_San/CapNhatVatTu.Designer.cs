namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class CapNhatVatTu
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
            this.txtCapNhatVatTu = new System.Windows.Forms.TextBox();
            this.dgvCapNhatVatTu = new System.Windows.Forms.DataGridView();
            this.lblVatTuKhachSan = new System.Windows.Forms.Label();
            this.btnXoaDichVuVT = new System.Windows.Forms.Button();
            this.btnThemDichVuVT = new System.Windows.Forms.Button();
            this.btnLuuCapNhatVatTu = new System.Windows.Forms.Button();
            this.btnThoatCapNhatVatTu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCapNhatVatTu
            // 
            this.txtCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapNhatVatTu.Location = new System.Drawing.Point(548, 94);
            this.txtCapNhatVatTu.Multiline = true;
            this.txtCapNhatVatTu.Name = "txtCapNhatVatTu";
            this.txtCapNhatVatTu.Size = new System.Drawing.Size(470, 38);
            this.txtCapNhatVatTu.TabIndex = 23;
            // 
            // dgvCapNhatVatTu
            // 
            this.dgvCapNhatVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatVatTu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.dgvCapNhatVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatVatTu.Location = new System.Drawing.Point(26, 94);
            this.dgvCapNhatVatTu.Name = "dgvCapNhatVatTu";
            this.dgvCapNhatVatTu.ReadOnly = true;
            this.dgvCapNhatVatTu.Size = new System.Drawing.Size(487, 592);
            this.dgvCapNhatVatTu.TabIndex = 22;
            // 
            // lblVatTuKhachSan
            // 
            this.lblVatTuKhachSan.AutoSize = true;
            this.lblVatTuKhachSan.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatTuKhachSan.Location = new System.Drawing.Point(380, 12);
            this.lblVatTuKhachSan.Name = "lblVatTuKhachSan";
            this.lblVatTuKhachSan.Size = new System.Drawing.Size(313, 47);
            this.lblVatTuKhachSan.TabIndex = 16;
            this.lblVatTuKhachSan.Text = "Vật Tư Khách Sạn";
            // 
            // btnXoaDichVuVT
            // 
            this.btnXoaDichVuVT.BackColor = System.Drawing.Color.Pink;
            this.btnXoaDichVuVT.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDichVuVT.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconDelete;
            this.btnXoaDichVuVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDichVuVT.Location = new System.Drawing.Point(743, 160);
            this.btnXoaDichVuVT.Name = "btnXoaDichVuVT";
            this.btnXoaDichVuVT.Size = new System.Drawing.Size(137, 45);
            this.btnXoaDichVuVT.TabIndex = 21;
            this.btnXoaDichVuVT.Text = "Xóa Vật Tư";
            this.btnXoaDichVuVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDichVuVT.UseVisualStyleBackColor = false;
            this.btnXoaDichVuVT.Click += new System.EventHandler(this.btnXoaDichVuVT_Click);
            // 
            // btnThemDichVuVT
            // 
            this.btnThemDichVuVT.BackColor = System.Drawing.Color.Pink;
            this.btnThemDichVuVT.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDichVuVT.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconThem;
            this.btnThemDichVuVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDichVuVT.Location = new System.Drawing.Point(548, 160);
            this.btnThemDichVuVT.Name = "btnThemDichVuVT";
            this.btnThemDichVuVT.Size = new System.Drawing.Size(155, 45);
            this.btnThemDichVuVT.TabIndex = 20;
            this.btnThemDichVuVT.Text = "Thêm Vật Tư";
            this.btnThemDichVuVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDichVuVT.UseVisualStyleBackColor = false;
            this.btnThemDichVuVT.Click += new System.EventHandler(this.btnThemDichVuVT_Click);
            // 
            // btnLuuCapNhatVatTu
            // 
            this.btnLuuCapNhatVatTu.BackColor = System.Drawing.Color.Pink;
            this.btnLuuCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatVatTu.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconLuu;
            this.btnLuuCapNhatVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatVatTu.Location = new System.Drawing.Point(924, 160);
            this.btnLuuCapNhatVatTu.Name = "btnLuuCapNhatVatTu";
            this.btnLuuCapNhatVatTu.Size = new System.Drawing.Size(94, 45);
            this.btnLuuCapNhatVatTu.TabIndex = 19;
            this.btnLuuCapNhatVatTu.Text = "Lưu";
            this.btnLuuCapNhatVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatVatTu.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatVatTu.Click += new System.EventHandler(this.btnLuuCapNhatVatTu_Click);
            // 
            // btnThoatCapNhatVatTu
            // 
            this.btnThoatCapNhatVatTu.BackColor = System.Drawing.Color.Pink;
            this.btnThoatCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCapNhatVatTu.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconBack;
            this.btnThoatCapNhatVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCapNhatVatTu.Location = new System.Drawing.Point(12, 12);
            this.btnThoatCapNhatVatTu.Name = "btnThoatCapNhatVatTu";
            this.btnThoatCapNhatVatTu.Size = new System.Drawing.Size(110, 45);
            this.btnThoatCapNhatVatTu.TabIndex = 18;
            this.btnThoatCapNhatVatTu.Text = "Trở Về";
            this.btnThoatCapNhatVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCapNhatVatTu.UseVisualStyleBackColor = false;
            this.btnThoatCapNhatVatTu.Click += new System.EventHandler(this.btnThoatCapNhatVatTu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 17;
            // 
            // CapNhatVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1048, 718);
            this.Controls.Add(this.txtCapNhatVatTu);
            this.Controls.Add(this.dgvCapNhatVatTu);
            this.Controls.Add(this.lblVatTuKhachSan);
            this.Controls.Add(this.btnXoaDichVuVT);
            this.Controls.Add(this.btnThemDichVuVT);
            this.Controls.Add(this.btnLuuCapNhatVatTu);
            this.Controls.Add(this.btnThoatCapNhatVatTu);
            this.Controls.Add(this.label2);
            this.Name = "CapNhatVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Trang Thiết Bị";
            this.Load += new System.EventHandler(this.CapNhatVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapNhatVatTu;
        private System.Windows.Forms.DataGridView dgvCapNhatVatTu;
        private System.Windows.Forms.Label lblVatTuKhachSan;
        private System.Windows.Forms.Button btnXoaDichVuVT;
        private System.Windows.Forms.Button btnThemDichVuVT;
        private System.Windows.Forms.Button btnLuuCapNhatVatTu;
        private System.Windows.Forms.Button btnThoatCapNhatVatTu;
        private System.Windows.Forms.Label label2;
    }
}