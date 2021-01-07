using QLXEMAY.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLXM
{
    public partial class TimKiemMH : Form
    {
        XeMayBLL bllxm;
        public TimKiemMH()
        {
            InitializeComponent();
            bllxm = new XeMayBLL();
        }
        public void showAllxemay()
        {
            DataTable dt = bllxm.getALLXeMay();
            dgvTK.DataSource = dt;
        }
        private void TimKiemMatHang_Load(object sender, EventArgs e)
        {
            showAllxemay();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string value = TextBox1.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dtt = bllxm.Findxemay(value);
                dgvTK.DataSource = dtt;
            }
            else
            {
                showAllxemay();
            }
        }
        private void show_Click(object sender, EventArgs e)
        {
            showAllxemay();
        }
    }
}
