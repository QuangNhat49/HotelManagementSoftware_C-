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
    public partial class CapNhatDichVu : Form
    {
        SqlConnection SqlCn;
        SqlDataAdapter sda;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public CapNhatDichVu()
        {
            InitializeComponent();
            //Đường dẫn tới SQL
            SqlCn = new SqlConnection(@"Data Source=DESKTOP-5FAI3IM;Initial Catalog=SQL_PMQLKS;Integrated Security=True");

            /*load Data*/
            string sql = "select TenDV, GiaDV from DichVu";
            sda = new SqlDataAdapter(sql, SqlCn);
            ds = new DataSet();
            sda.Fill(ds, "DichVu");
            /*Thêm khóa chính*/
            key[0] = ds.Tables["DichVu"].Columns[0];
            ds.Tables["DichVu"].PrimaryKey = key;
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
            dgvCapNhatDichVu.DataSource = ds.Tables[0];
        }

        private void CapNhatDichVu_Load(object sender, EventArgs e)
        {
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            SetGridViewStyle(dgvCapNhatDichVu);
            loadGrid();
            dgvCapNhatDichVu.ReadOnly = true;

            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        private void btnThoatCapNhatDichVu_Click(object sender, EventArgs e)
        {
            ManHinhQuanLyPhong m = new ManHinhQuanLyPhong();
            m.Show();
            Visible = false;
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            //Tạo 1 dòng dữ liệu mới 
            DataRow newrow = ds.Tables[0].NewRow();
            newrow["TenDV"] = txtCapNhatDichVu.Text;
            newrow["GiaDV"] = txtGia.Text;
            //Thêm dòng dữ liệu vào dataset
            ds.Tables[0].Rows.Add(newrow);
            //Cập nhật trong csdl
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            //Xóa các trường sau khi nhập xong
            txtCapNhatDichVu.Clear();
            txtGia.Clear();
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvCapNhatDichVu.SelectedRows)
                dgvCapNhatDichVu.Rows.RemoveAt(item.Index);
        }
    }
}
