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
    public partial class CapNhatLichLamViec : Form
    {
        public CapNhatLichLamViec()
        {
            InitializeComponent();
        }

        private void btnTroVeCuaCapNhatLichLamViec_Click(object sender, EventArgs e)
        {
            ManHinhQuanLyNhanVien m = new ManHinhQuanLyNhanVien();
            m.Show();
            Visible = false;
        }

        private void btnThemLichLamViec_Click(object sender, EventArgs e)
        {

        }
    }
}
