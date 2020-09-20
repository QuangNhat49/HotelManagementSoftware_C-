namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class ManHinhQuanLyPhong
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
            this.dgvQuanLyPhong = new System.Windows.Forms.DataGridView();
            this.lblQuanLyPhong = new System.Windows.Forms.Label();
            this.btnCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.btnCapNhatDVPhong = new System.Windows.Forms.Button();
            this.btnCapNhatVatTu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btTroVeCTPP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLyPhong
            // 
            this.dgvQuanLyPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQuanLyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhong.Location = new System.Drawing.Point(287, 126);
            this.dgvQuanLyPhong.Name = "dgvQuanLyPhong";
            this.dgvQuanLyPhong.ReadOnly = true;
            this.dgvQuanLyPhong.Size = new System.Drawing.Size(657, 368);
            this.dgvQuanLyPhong.TabIndex = 11;
            // 
            // lblQuanLyPhong
            // 
            this.lblQuanLyPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyPhong.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyPhong.Location = new System.Drawing.Point(480, 9);
            this.lblQuanLyPhong.Name = "lblQuanLyPhong";
            this.lblQuanLyPhong.Size = new System.Drawing.Size(338, 42);
            this.lblQuanLyPhong.TabIndex = 10;
            this.lblQuanLyPhong.Text = "Quản Lý Phòng";
            this.lblQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapNhatLoaiPhong
            // 
            this.btnCapNhatLoaiPhong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiPhong.Location = new System.Drawing.Point(20, 316);
            this.btnCapNhatLoaiPhong.Name = "btnCapNhatLoaiPhong";
            this.btnCapNhatLoaiPhong.Size = new System.Drawing.Size(217, 49);
            this.btnCapNhatLoaiPhong.TabIndex = 9;
            this.btnCapNhatLoaiPhong.Text = "Cập nhật loại phòng";
            this.btnCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            this.btnCapNhatLoaiPhong.Click += new System.EventHandler(this.btnCapNhatLoaiPhong_Click);
            // 
            // btnCapNhatDVPhong
            // 
            this.btnCapNhatDVPhong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatDVPhong.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDVPhong.Location = new System.Drawing.Point(20, 219);
            this.btnCapNhatDVPhong.Name = "btnCapNhatDVPhong";
            this.btnCapNhatDVPhong.Size = new System.Drawing.Size(217, 51);
            this.btnCapNhatDVPhong.TabIndex = 8;
            this.btnCapNhatDVPhong.Text = "Cập nhật dịch vụ";
            this.btnCapNhatDVPhong.UseVisualStyleBackColor = false;
            this.btnCapNhatDVPhong.Click += new System.EventHandler(this.btnCapNhatDVPhong_Click);
            // 
            // btnCapNhatVatTu
            // 
            this.btnCapNhatVatTu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatVatTu.Location = new System.Drawing.Point(20, 126);
            this.btnCapNhatVatTu.Name = "btnCapNhatVatTu";
            this.btnCapNhatVatTu.Size = new System.Drawing.Size(217, 50);
            this.btnCapNhatVatTu.TabIndex = 7;
            this.btnCapNhatVatTu.Text = "Cập nhật vật tư";
            this.btnCapNhatVatTu.UseVisualStyleBackColor = false;
            this.btnCapNhatVatTu.Click += new System.EventHandler(this.btnCapNhatVatTu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Khách Sạn Hiện Tại Đang Có 8 Phòng";
            // 
            // btTroVeCTPP
            // 
            this.btTroVeCTPP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btTroVeCTPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTroVeCTPP.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconBack;
            this.btTroVeCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTroVeCTPP.Location = new System.Drawing.Point(12, 12);
            this.btTroVeCTPP.Name = "btTroVeCTPP";
            this.btTroVeCTPP.Size = new System.Drawing.Size(109, 50);
            this.btTroVeCTPP.TabIndex = 14;
            this.btTroVeCTPP.Text = "Trở về";
            this.btTroVeCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTroVeCTPP.UseVisualStyleBackColor = false;
            this.btTroVeCTPP.Click += new System.EventHandler(this.btTroVeCTPP_Click);
            // 
            // ManHinhQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(994, 526);
            this.Controls.Add(this.btTroVeCTPP);
            this.Controls.Add(this.dgvQuanLyPhong);
            this.Controls.Add(this.lblQuanLyPhong);
            this.Controls.Add(this.btnCapNhatLoaiPhong);
            this.Controls.Add(this.btnCapNhatDVPhong);
            this.Controls.Add(this.btnCapNhatVatTu);
            this.Controls.Add(this.label1);
            this.Name = "ManHinhQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhQuanLyPhong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManHinhQuanLyPhong_FormClosing);
            this.Load += new System.EventHandler(this.ManHinhQuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyPhong;
        private System.Windows.Forms.Label lblQuanLyPhong;
        private System.Windows.Forms.Button btnCapNhatLoaiPhong;
        private System.Windows.Forms.Button btnCapNhatDVPhong;
        private System.Windows.Forms.Button btnCapNhatVatTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTroVeCTPP;
    }
}