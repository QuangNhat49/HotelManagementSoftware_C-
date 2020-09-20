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
    public partial class ManHinhQuanLyKhachHang : Form
    {
        SqlConnection SqlCn;
        SqlDataAdapter sda;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public ManHinhQuanLyKhachHang()
        {
            InitializeComponent();
            //Đường dẫn tới SQL
            SqlCn = new SqlConnection(@"Data Source=DESKTOP-5FAI3IM;Initial Catalog=SQL_PMQLKS;Integrated Security=True");

            /*load Data*/
            string sql = "select TenKH, QuocTich from KhachHang";
            sda = new SqlDataAdapter(sql, SqlCn);
            ds = new DataSet();
            sda.Fill(ds, "KhachHang");
            /*Thêm khóa chính*/
            //key[0] = ds.Tables["ThietBi"].Columns[0];
            //ds.Tables["ThietBi"].PrimaryKey = key;
        }

        public void SetGridViewStyle(DataGridView dgview)
        {
            //dgview.BorderStyle = BorderStyle.None;
            //dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dgview.BackgroundColor = Color.White;
            //dgview.EnableHeadersVisualStyles = false;
            //dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dgview.AllowUserToDeleteRows = false;
            //dgview.AllowUserToAddRows = false;
            //dgview.AllowUserToOrderColumns = true;
            //dgview.MultiSelect = false;
            //dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void loadGrid()
        {
            dgvQuanLyKhachHang.DataSource = ds.Tables[0];
        }

        private void ManHinhQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            SetGridViewStyle(dgvQuanLyKhachHang);
            loadGrid();
            dgvQuanLyKhachHang.ReadOnly = true;

            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        private void btnTroVeCuaQLKH_Click(object sender, EventArgs e)
        {
            ManHinhChinh mhc = new ManHinhChinh();
            mhc.Show();
            Visible = false;
        }

        private void ManHinhQuanLyKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCn.Open();
            sda = new SqlDataAdapter("SELECT TenNV FROM NhanVien WHERE TenNV LIKE N'%" + txtTimKiem.Text + "%'", SqlCn);
            ds = new DataSet();
            sda.Fill(ds, "NhanVien");
            if (ds.Tables["NhanVien"].Rows.Count > 0)
            {
                dgvQuanLyKhachHang.DataSource = ds.Tables["NhanVien"];
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên này!");
                txtTimKiem.Text = "";
            }
            SqlCn.Close();
        }
    }
}
