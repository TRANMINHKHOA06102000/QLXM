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

namespace QLXM
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void dn_Click(object sender, EventArgs e)
        {
            SqlConnection co = new  SqlConnection(@"Data Source=KHOA;Initial Catalog=QLXeMay;Integrated Security=True");
            try
            {
                co.Open();
                string tk = tendn.Text;
                string mk = matkhau.Text;
                string sql = "select * from TaiKhoan where TaiKhoan= '" + tk + "' and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql,co);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Form form = new GDHeThong();
                    form.Show();
                }
                else
                    MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi Kết Nối" + ex);
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
                Form form = new HeThong();
                form.Show();
            }
                
        }
    }
}
