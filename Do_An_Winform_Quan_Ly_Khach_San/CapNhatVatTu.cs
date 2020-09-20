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
    public partial class CapNhatVatTu : Form
    {
        SqlConnection SqlCn;
        SqlDataAdapter sda;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public CapNhatVatTu()
        {
            InitializeComponent();

            //Đường dẫn tới SQL
            SqlCn = new SqlConnection(@"Data Source=DESKTOP-5FAI3IM;Initial Catalog=SQL_PMQLKS;Integrated Security=True");

            /*load Data*/
            string sql = "select TenThietBi from ThietBi";
            sda = new SqlDataAdapter(sql, SqlCn);
            ds = new DataSet();
            sda.Fill(ds, "ThietBi");
            /*Thêm khóa chính*/
            //key[0] = ds.Tables["ThietBi"].Columns[0];
            //ds.Tables["ThietBi"].PrimaryKey = key;
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
            dgvCapNhatVatTu.DataSource = ds.Tables[0];
        }


        private void CapNhatVatTu_Load(object sender, EventArgs e)
        {
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            SetGridViewStyle(dgvCapNhatVatTu);
            loadGrid();
            dgvCapNhatVatTu.ReadOnly = true;

            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        private void btnThoatCapNhatVatTu_Click(object sender, EventArgs e)
        {
            ManHinhQuanLyPhong m = new ManHinhQuanLyPhong();
            m.Show();
            Visible = false;
        }

        private void btnThemDichVuVT_Click(object sender, EventArgs e)
        {
            //Tạo 1 dòng dữ liệu mới 
            DataRow newrow = ds.Tables[0].NewRow();
            newrow["TenThietBi"] = txtCapNhatVatTu.Text;
            //Thêm dòng dữ liệu vào dataset
            ds.Tables[0].Rows.Add(newrow);
            //Cập nhật trong csdl
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            //Xóa các trường sau khi nhập xong
            txtCapNhatVatTu.Clear();
        }

        private void btnXoaDichVuVT_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvCapNhatVatTu.SelectedRows)
                dgvCapNhatVatTu.Rows.RemoveAt(item.Index);
        }

        private void btnLuuCapNhatVatTu_Click(object sender, EventArgs e)
        {

        }
    }
}
