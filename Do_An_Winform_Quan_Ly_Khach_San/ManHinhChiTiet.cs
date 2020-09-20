using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Do_An_Winform_Quan_Ly_Khach_San
{
    public partial class ManHinhChiTiet : Form
    {
        SqlConnection SqlCn;
        public ManHinhChiTiet()
        {
            InitializeComponent();
            //Đường dẫn tới SQL
            SqlCn = new SqlConnection(@"Data Source=DESKTOP-5FAI3IM;Initial Catalog=SQL_PMQLKS;Integrated Security=True");
        }

        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
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

        private void btnTroVeCuaCTPP_Click(object sender, EventArgs e)
        {
            ManHinhChinh mhc = new ManHinhChinh();
            mhc.Show();
            Visible = false;
        }

        private void ManHinhChiTiet_Load(object sender, EventArgs e)
        {
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            //Load tên loại phòng
            string loadTenPhong = "select * from LoaiPhong";
            SqlDataAdapter sqladt = new SqlDataAdapter(loadTenPhong, SqlCn);
            DataSet ds = new DataSet();
            sqladt.Fill(ds);

            cmbLoaiPhong.DisplayMember = "TenLoai";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbLoaiPhong.DataSource = ds.Tables[0];

            //Load tên nguồn đặt phòng
            string loadTenNguonDatPhong = "select TenNguonDatPhong from NguonDatPhong";
            SqlDataAdapter sqladt1 = new SqlDataAdapter(loadTenNguonDatPhong, SqlCn);
            DataSet ds1 = new DataSet();
            sqladt1.Fill(ds1);

            cmbTenNguonDat.DisplayMember = "TenNguonDatPhong";
            cmbTenNguonDat.ValueMember = "TenNguonDatPhong";
            cmbTenNguonDat.DataSource = ds1.Tables[0];

            //Load tên dịch vụ
            string loadTenDichVu = "select TenDV from DichVu";
            SqlDataAdapter sqladt2 = new SqlDataAdapter(loadTenDichVu, SqlCn);
            DataSet ds2 = new DataSet();
            sqladt2.Fill(ds2);

            cmbTenDichVu.DisplayMember = "TenDV";
            cmbTenDichVu.ValueMember = "TenDV";
            cmbTenDichVu.DataSource = ds2.Tables[0];

            //Load tên nhân viên
            string loadTenNhanVien = "select TenNV from NhanVien";
            SqlDataAdapter sqladt3 = new SqlDataAdapter(loadTenNhanVien, SqlCn);
            DataSet ds3 = new DataSet();
            sqladt3.Fill(ds3);

            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "TenNV";
            cmbNhanVien.DataSource = ds3.Tables[0];

            SetGridViewStyle(dgvChiTietDichVu);

            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        private void ManHinhChiTiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SqlCn.State == ConnectionState.Closed)
                SqlCn.Open();

            if (cmbLoaiPhong.SelectedValue != null)
            {
                string GiaPhong = "select GiaPhong from Phong p,LoaiPhong lp where p.MaLoaiPhong=lp.MaLoaiPhong and p.MaLoaiPhong = '" + cmbLoaiPhong.SelectedValue.ToString() + "'";//" + cmbLoaiPhong.SelectedValue.ToString() + "
                SqlCommand CauTruyVan = new SqlCommand(GiaPhong, SqlCn);
                object oj = CauTruyVan.ExecuteScalar();
                string kt = Convert.ToString(oj.ToString());
                txtChiTietGiaPhong.Text = kt;
            }

            //Load Số phòng
            string loadSoPhong = "select MaPhong from Phong p, LoaiPhong lp where p.MaLoaiPhong=lp.MaLoaiPhong and lp.MaLoaiPhong = '" + cmbLoaiPhong.SelectedValue.ToString() + "'";
            SqlDataAdapter sqladt1 = new SqlDataAdapter(loadSoPhong, SqlCn);
            DataSet ds1 = new DataSet();
            sqladt1.Fill(ds1);

            cmbSoPhong.DisplayMember = "MaPhong";
            cmbSoPhong.ValueMember = "MaPhong";
            cmbSoPhong.DataSource = ds1.Tables[0];

            if (SqlCn.State == ConnectionState.Open)
                SqlCn.Close();
        }

        private void cmbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtChiTietSoDem_TextChanged(object sender, EventArgs e)
        {
            if (txtChiTietSoDem.Text == "")
            {
                lblThanhTien.Text = "0";
            }

            try
            {
                int sd = int.Parse(txtChiTietSoDem.Text.ToString());
                int g = int.Parse(txtChiTietGiaPhong.Text.ToString());
                int tt = sd * g;
                lblThanhTien.Text = tt.ToString();
                return;
            }
            catch (Exception)
            { }
        }

        private void txtChiTietSoDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            ManHinhChinh.tennd = cmbTenNguonDat.Text;
            ManHinhChinh.tenlp = cmbLoaiPhong.Text;
            ManHinhChinh.tenk = txtChiTietTenKhach.Text;
            ManHinhChinh.sk = txtChiTietSoKhach.Text;
            ManHinhChinh.qt = txtChiTietQuocTich.Text;
            ManHinhChinh.ngden = dtpNgayDen.Text;
            ManHinhChinh.ngdi = dtpNgayDi.Text;

            ManHinhChinh mhc = new ManHinhChinh();
            Visible = false;
            mhc.Show();
        }

        private void btnThemCuaCTP_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra kết nối trước khi mở
                if (SqlCn.State == ConnectionState.Closed)
                    SqlCn.Open();
                //Lấy tên dịch vụ
                string gdv = "select GiaDV from DichVu where TenDV = N'" + cmbTenDichVu.Text + "'";
                SqlCommand CauTruyVan = new SqlCommand(gdv, SqlCn);
                object ok = CauTruyVan.ExecuteScalar();
                int giaDichVu = int.Parse(ok.ToString());
                //Đóng kết nối
                if (SqlCn.State == ConnectionState.Open)
                    SqlCn.Close();

                //Báo lỗi
                if (txtSoLuong.Text == "")
                    throw new Exception("Vui lòng nhập số lượng dịch vụ!!!");

                int index = dgvChiTietDichVu.Rows.Add();
                dgvChiTietDichVu.Rows[index].Cells[0].Value = (index + 1).ToString();
                dgvChiTietDichVu.Rows[index].Cells[1].Value = cmbTenDichVu.Text;
                dgvChiTietDichVu.Rows[index].Cells[2].Value = giaDichVu;
                dgvChiTietDichVu.Rows[index].Cells[3].Value = txtSoLuong.Text;
                int thanhtien = int.Parse(giaDichVu.ToString()) * int.Parse(txtSoLuong.Text);
                dgvChiTietDichVu.Rows[index].Cells[4].Value = thanhtien;

                //Tính tổng tiền
                int tongTien = int.Parse(lblThanhTien.Text) + thanhtien;
                lblChiTietTongTien.Text = tongTien.ToString();

                txtSoLuong.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaCTPP_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvChiTietDichVu.SelectedRows)
                dgvChiTietDichVu.Rows.RemoveAt(item.Index);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
        }

        private void txtChiTietSoKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
        }
    }
}
