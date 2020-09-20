using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Winform_Quan_Ly_Khach_San
{
    public partial class ManHinhQuanLyPhong : Form
    {
        SqlConnection SqlCn;
        SqlDataAdapter sda;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public ManHinhQuanLyPhong()
        {
            InitializeComponent();
            //Đường dẫn tới SQL
            SqlCn = new SqlConnection(@"Data Source=DESKTOP-5FAI3IM;Initial Catalog=SQL_PMQLKS;Integrated Security=True");

            /*load Data*/
            string sql = "select * from Phong";
            sda = new SqlDataAdapter(sql, SqlCn);
            ds = new DataSet();
            sda.Fill(ds, "Phong");
            /*Thêm khóa chính*/
            key[0] = ds.Tables["Phong"].Columns[0];
            ds.Tables["Phong"].PrimaryKey = key;
        }

        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void loadGrid()
        {
            dgvQuanLyPhong.DataSource = ds.Tables[0];
        }

        private void btTroVeCTPP_Click(object sender, EventArgs e)
        {
            ManHinhChinh mhc1 = new ManHinhChinh();
            mhc1.Show();
            Visible = false;
        }

        private void ManHinhQuanLyPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManHinhQuanLyPhong_Load(object sender, EventArgs e)
        {
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            SetGridViewStyle(dgvQuanLyPhong);
            loadGrid();
            dgvQuanLyPhong.ReadOnly = true;

            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        private void btnCapNhatVatTu_Click(object sender, EventArgs e)
        {
            CapNhatVatTu c = new CapNhatVatTu();
            c.Show();
            Visible = false;
        }

        private void btnCapNhatDVPhong_Click(object sender, EventArgs e)
        {
            CapNhatDichVu c = new CapNhatDichVu();
            c.Show();
            Visible = false;
        }

        private void btnCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {
            CapNhatLoaiPhong c = new CapNhatLoaiPhong();
            c.Show();
            Visible = false;
        }
    }
}
