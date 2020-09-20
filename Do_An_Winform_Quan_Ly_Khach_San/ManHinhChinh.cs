using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Winform_Quan_Ly_Khach_San
{
    public partial class ManHinhChinh : Form
    {
        public static string checkOut = ".........................................";
        public static string tennd = checkOut;
        public static string tenlp = "Loại phòng: ";
        public static string tenk = checkOut;
        public static string sk = checkOut;
        public static string qt = checkOut;
        public static string ngden = checkOut;
        public static string ngdi = checkOut;


        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void cmbPhong1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong1.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Trống":
                    lblPhong1.BackColor = Color.LightGreen;
                    break;
                case "Phòng Ở":
                    lblPhong1.BackColor = Color.Red;
                    break;
                case "Phòng Trả":
                    lblPhong1.BackColor = Color.Yellow;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong1.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong2.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Trống":
                    lblPhong2.BackColor = Color.LightGreen;
                    break;
                case "Phòng Ở":
                    lblPhong2.BackColor = Color.Red;
                    break;
                case "Phòng Trả":
                    lblPhong2.BackColor = Color.Yellow;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong2.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong3.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Trống":
                    lblPhong3.BackColor = Color.LightGreen;
                    break;
                case "Phòng Ở":
                    lblPhong3.BackColor = Color.Red;
                    break;
                case "Phòng Trả":
                    lblPhong3.BackColor = Color.Yellow;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong3.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong4.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Trống":
                    lblPhong4.BackColor = Color.LightGreen;
                    break;
                case "Phòng Ở":
                    lblPhong4.BackColor = Color.Red;
                    break;
                case "Phòng Trả":
                    lblPhong4.BackColor = Color.Yellow;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong4.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong5.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Trống":
                    lblPhong5.BackColor = Color.LightGreen;
                    break;
                case "Phòng Ở":
                    lblPhong5.BackColor = Color.Red;
                    break;
                case "Phòng Trả":
                    lblPhong5.BackColor = Color.Yellow;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong5.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong6.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Trống":
                    lblPhong6.BackColor = Color.LightGreen;
                    break;
                case "Phòng Ở":
                    lblPhong6.BackColor = Color.Red;
                    break;
                case "Phòng Trả":
                    lblPhong6.BackColor = Color.Yellow;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong6.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong7.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Trống":
                    lblPhong7.BackColor = Color.LightGreen;
                    break;
                case "Phòng Ở":
                    lblPhong7.BackColor = Color.Red;
                    break;
                case "Phòng Trả":
                    lblPhong7.BackColor = Color.Yellow;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong7.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong8.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Trống":
                    lblPhong8.BackColor = Color.LightGreen;
                    break;
                case "Phòng Ở":
                    lblPhong8.BackColor = Color.Red;
                    break;
                case "Phòng Trả":
                    lblPhong8.BackColor = Color.Yellow;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong8.BackColor = Color.Gray;
                    break;
            }
        }

        private void btnChiTiet1_Click(object sender, EventArgs e)
        {
            ManHinhChiTiet mhct = new ManHinhChiTiet();
            mhct.Show();
            Visible = false;
        }

        private void btnCheckOut1_Click(object sender, EventArgs e)
        {
            string checkOut = ".........................................";

            lblNoiDungTenBooking1.Text = checkOut;
            lblNoiDungTenKhach1.Text = checkOut;
            lblNoiDungSoKhach1.Text = checkOut;
            lblNoiDungQuocTich1.Text = checkOut;
            lblNoiDungNgayDen1.Text = checkOut;
            lblNoiDungNgayDi1.Text = checkOut;
            lblPhong1.BackColor = Color.Gray;
        }

        private void btnCheckOut2_Click(object sender, EventArgs e)
        {
            string checkOut = ".........................................";

            lblNoiDungTenBooking2.Text = checkOut;
            lblNoiDungTenKhach2.Text = checkOut;
            lblNoiDungSoKhach2.Text = checkOut;
            lblNoiDungQuocTich2.Text = checkOut;
            lblNoiDungNgayDen2.Text = checkOut;
            lblNoiDungNgayDi2.Text = checkOut;
            lblPhong2.BackColor = Color.Gray;
        }

        private void btnCheckOut3_Click(object sender, EventArgs e)
        {
            string checkOut = ".........................................";

            lblNoiDungTenBooking3.Text = checkOut;
            lblNoiDungTenKhach3.Text = checkOut;
            lblNoiDungSoKhach3.Text = checkOut;
            lblNoiDungQuocTich3.Text = checkOut;
            lblNoiDungNgayDen3.Text = checkOut;
            lblNoiDungNgayDi3.Text = checkOut;
            lblPhong3.BackColor = Color.Gray;
        }

        private void btnCheckOut4_Click(object sender, EventArgs e)
        {
            string checkOut = ".........................................";

            lblNoiDungTenBooking4.Text = checkOut;
            lblNoiDungTenKhach4.Text = checkOut;
            lblNoiDungSoKhach4.Text = checkOut;
            lblNoiDungQuocTich4.Text = checkOut;
            lblNoiDungNgayDen4.Text = checkOut;
            lblNoiDungNgayDi4.Text = checkOut;
            lblPhong4.BackColor = Color.Gray;
        }

        private void btnCheckOut5_Click(object sender, EventArgs e)
        {
            string checkOut = ".........................................";

            lblNoiDungTenBooking5.Text = checkOut;
            lblNoiDungTenKhach5.Text = checkOut;
            lblNoiDungSoKhach5.Text = checkOut;
            lblNoiDungQuocTich5.Text = checkOut;
            lblNoiDungNgayDen5.Text = checkOut;
            lblNoiDungNgayDi5.Text = checkOut;
            lblPhong5.BackColor = Color.Gray;
        }

        private void btnCheckOut6_Click(object sender, EventArgs e)
        {
            string checkOut = ".........................................";

            lblNoiDungTenBooking6.Text = checkOut;
            lblNoiDungTenKhach6.Text = checkOut;
            lblNoiDungSoKhach6.Text = checkOut;
            lblNoiDungQuocTich6.Text = checkOut;
            lblNoiDungNgayDen6.Text = checkOut;
            lblNoiDungNgayDi6.Text = checkOut;
            lblPhong6.BackColor = Color.Gray;
        }

        private void btnCheckOut7_Click(object sender, EventArgs e)
        {
            string checkOut = ".........................................";

            lblNoiDungTenBooking7.Text = checkOut;
            lblNoiDungTenKhach7.Text = checkOut;
            lblNoiDungSoKhach7.Text = checkOut;
            lblNoiDungQuocTich7.Text = checkOut;
            lblNoiDungNgayDen7.Text = checkOut;
            lblNoiDungNgayDi7.Text = checkOut;
            lblPhong7.BackColor = Color.Gray;
        }

        private void btnCheckOut8_Click(object sender, EventArgs e)
        {
            string checkOut = ".........................................";

            lblNoiDungTenBooking8.Text = checkOut;
            lblNoiDungTenKhach8.Text = checkOut;
            lblNoiDungSoKhach8.Text = checkOut;
            lblNoiDungQuocTich8.Text = checkOut;
            lblNoiDungNgayDen8.Text = checkOut;
            lblNoiDungNgayDi8.Text = checkOut;
            lblPhong8.BackColor = Color.Gray;
        }

        private void QuanLyPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManHinhQuanLyPhong mhqlp = new ManHinhQuanLyPhong();
            mhqlp.Show();
            Visible = false;
        }

        private void qlNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManHinhQuanLyNhanVien mhqlnv = new ManHinhQuanLyNhanVien();
            mhqlnv.Show();
            Visible = false;

        }

        private void qlKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManHinhQuanLyKhachHang mhqlkh = new ManHinhQuanLyKhachHang();
            mhqlkh.Show();
            Visible = false;
        }


        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            lblNoiDungTenBooking1.Text = tennd;
            lblPhong1.Text = tenlp;
            lblNoiDungTenKhach1.Text = tenk;
            lblNoiDungSoKhach1.Text = sk;
            lblNoiDungQuocTich1.Text = qt;
            lblNoiDungNgayDen1.Text = ngden;
            lblNoiDungNgayDi1.Text = ngdi;
        }

        private void panManHinhChinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe t = new ThongKe();
            t.Show();
            Visible = false;
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHe l = new LienHe();
            l.Show();
            Visible = false;
        }
    }
}
