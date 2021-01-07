using QLXM.GUI;
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
    public partial class GDHeThong : Form
    {
        HThong HT = new HThong();
        public GDHeThong()
        {
            InitializeComponent();
        }

        private void QuảnLýMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new DanhMucMatHang();
            form.Show();
        }

      
        private void GDHeThong_Load(object sender, EventArgs e)
        {
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn cần đăng xuất trước khi đăng nhập tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Hide();
                Form form = new HeThong();
                form.Show();
            }             
        }

        private void từSQLXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HT.TaoXML();
                MessageBox.Show("Tạo XML thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void từXMLSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HT.CapNhapSQL();
                MessageBox.Show("Cập nhập SQL server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void xácNhậnĐiLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new XNDiLam();
            form.Show();
        }
    }
}
