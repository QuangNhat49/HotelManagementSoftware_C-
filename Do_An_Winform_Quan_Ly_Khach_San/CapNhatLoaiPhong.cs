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
    public partial class CapNhatLoaiPhong : Form
    {
        SqlConnection SqlCn;
        public CapNhatLoaiPhong()
        {
            InitializeComponent();
            //Đường dẫn tới SQL
            SqlCn = new SqlConnection(@"Data Source=DESKTOP-5FAI3IM;Initial Catalog=SQL_PMQLKS;Integrated Security=True");
        }

        private void btnTroVeCuaQLNV_Click(object sender, EventArgs e)
        {
            ManHinhQuanLyPhong m = new ManHinhQuanLyPhong();
            m.Show();
            Visible = false;
        }

        private void CapNhatLoaiPhong_Load(object sender, EventArgs e)
        {
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            string loadTenPhong = "select MaPhong from Phong";
            SqlDataAdapter sqladt = new SqlDataAdapter(loadTenPhong, SqlCn);
            DataSet ds = new DataSet();
            sqladt.Fill(ds);

            cmbChonSoPhong.DisplayMember = "MaPhong";
            cmbChonSoPhong.ValueMember = "MaPhong";
            cmbChonSoPhong.DataSource = ds.Tables[0];

            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        private void btnLuuCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
