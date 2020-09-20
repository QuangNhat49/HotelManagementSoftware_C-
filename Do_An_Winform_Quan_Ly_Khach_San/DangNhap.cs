using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Để sử dụng SQL

namespace Do_An_Winform_Quan_Ly_Khach_San
{
    public partial class DangNhap : Form
    {
        //Tạo đường kết nối tới SQL
        SqlConnection SqlCn;
        public DangNhap()
        {
            InitializeComponent();
            //Đường dẫn tới SQL
            SqlCn = new SqlConnection(@"Data Source=DESKTOP-5FAI3IM;Initial Catalog=SQL_PMQLKS;Integrated Security=True");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                //txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
                //txtMatKhau.ForeColor = Color.Silver;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra kết nối trước khi mở
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            string KtTK = "select count(*) from TaiKhoan where Username = '" + txtTenDangNhap.Text + "' and Password = '" + txtMatKhau.Text + "'";
            //SqlCommand(câu truy vấn, cổng kết nối)
            SqlCommand CauTruyVan = new SqlCommand(KtTK, SqlCn);
            //Trả về object
            object ok = CauTruyVan.ExecuteScalar();
            //Ép kiểu ok về số
            int kt = int.Parse(ok.ToString());
            if (kt == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai. Vui lòng nhập lại!!!");

                //Kiểm tra kết nối trước khi đóng
                if (SqlCn.State == ConnectionState.Open)
                    SqlCn.Close();

                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                return;
            }
            else
            {
                ManHinhChinh mhc = new ManHinhChinh();
                mhc.Show();
                //Đóng form Đăng nhập
                Visible = false;
            }
            //Đóng kết nối
            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        //Hiện mật khẩu
        private void btnHienMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        //Ẩn mật khẩu
        private void btnHienMatKhau_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quên thì alo mình nhé !!!");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alo mình để đăng kí nhé!!!");
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
//ExecuteNonQuery() thi hành loại lệnh - không cần trả về dữ liệu gì
//ExecuteReader() thi hành lệnh - trả về IDataReader từ đó đọc được dữ liệu
//ExecuteScalar() thi hành và trả về một giá trị duy nhất - ở hàng đầu tiên, cột đầu tiên