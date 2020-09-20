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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btnTroVeCuaThongKe_Click(object sender, EventArgs e)
        {
            ManHinhChinh m = new ManHinhChinh();
            m.Show();
            Visible = false;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
