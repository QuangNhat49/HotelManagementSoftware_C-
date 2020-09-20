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
    public partial class ManHinhQuanLyNhanVien : Form
    {
        SqlConnection SqlCn;
        SqlDataAdapter sda;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public ManHinhQuanLyNhanVien()
        {
            InitializeComponent();
            //Đường dẫn tới SQL
            SqlCn = new SqlConnection(@"Data Source=DESKTOP-5FAI3IM;Initial Catalog=SQL_PMQLKS;Integrated Security=True");

            /*load Data*/
            string sql = "select * from LichLamViec l, NhanVien n where l.MaNV=n.MaNV";
            sda = new SqlDataAdapter(sql, SqlCn);
            ds = new DataSet();
            sda.Fill(ds, "LichLamViec");
            /*Thêm khóa chính*/
            key[0] = ds.Tables["LichLamViec"].Columns[0];
            ds.Tables["LichLamViec"].PrimaryKey = key;
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
            dgvLichLamViec.DataSource = ds.Tables[0];
        }

        private void btnTroVeCuaQLNV_Click(object sender, EventArgs e)
        {
            ManHinhChinh mhc = new ManHinhChinh();
            mhc.Show();
            Visible = false;
        }

        private void btnCapNhatThongTinNV_Click(object sender, EventArgs e)
        {
            CapNhatThongTinNhanVien c = new CapNhatThongTinNhanVien();
            c.Show();
            Visible = false;
        }

        private void btnCapNhatLichLamViecNV_Click(object sender, EventArgs e)
        {
            CapNhatLichLamViec c = new CapNhatLichLamViec();
            c.Show();
            Visible = false;
        }

        private void ManHinhQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            SetGridViewStyle(dgvLichLamViec);
            loadGrid();
            dgvLichLamViec.ReadOnly = true;

            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        private void dgvLichLamViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
