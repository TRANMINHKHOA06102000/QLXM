using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXM.GUI
{
    public partial class XNDiLam : Form
    {
        KiemTraTK kt = new KiemTraTK();
        TaiKhoan tk = new TaiKhoan();
        public XNDiLam()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    if (kt.kiemtraTTDN("TaiKhoan.xml", txtTaiKhoan.Text, txtMatKhau.Text) == false)
                    {
                        MessageBox.Show("Thông tin của người dùng không khớp nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DateTime date = new DateTime();
                        date = DateTime.Today;

                        MessageBox.Show("Hôm nay là ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year);
                        if (tk.kiemtraNgayThang(txtTaiKhoan.Text, date.Day, date.Month, date.Year))
                        {
                            MessageBox.Show("Hôm nay bạn đã xác nhận đi làm rồi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            tk.XacNhanDiLam(txtTaiKhoan.Text, date.Day, date.Month, date.Year);
                            MessageBox.Show("Đã xác nhận nhân viên '" + txtTaiKhoan.Text + "' đi làm ngày hôm nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txtTaiKhoan.Enabled = txtMatKhau.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XNDiLam_Load(object sender, EventArgs e)
        {
            txtMatKhau.Focus();
        }
    }
}
