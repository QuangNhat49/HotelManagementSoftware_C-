namespace Do_An_Winform_Quan_Ly_Khach_San
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnTroVeCuaThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroVeCuaThongKe
            // 
            this.btnTroVeCuaThongKe.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaThongKe.Image = global::Do_An_Winform_Quan_Ly_Khach_San.Properties.Resources.iconBack;
            this.btnTroVeCuaThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaThongKe.Location = new System.Drawing.Point(12, 12);
            this.btnTroVeCuaThongKe.Name = "btnTroVeCuaThongKe";
            this.btnTroVeCuaThongKe.Size = new System.Drawing.Size(101, 37);
            this.btnTroVeCuaThongKe.TabIndex = 12;
            this.btnTroVeCuaThongKe.Text = "Trở về";
            this.btnTroVeCuaThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaThongKe.UseVisualStyleBackColor = true;
            this.btnTroVeCuaThongKe.Click += new System.EventHandler(this.btnTroVeCuaThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "DOANH THU NĂM 2019";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.IndianRed;
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(12, 63);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tổng Tiền";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(839, 529);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "Doanh Thu Khách Sạn 2019";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 613);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnTroVeCuaThongKe);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVeCuaThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}