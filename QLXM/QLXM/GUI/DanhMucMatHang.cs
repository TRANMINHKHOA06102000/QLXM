using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using QLXEMAY.Class;
using QLXEMAY.Controller;
using QLXEMAY.Model;
using QLXM.DataSet;

namespace QLXM
{
    public partial class DanhMucMatHang : Form
    {
        XeMayBLL bllxm;
        /*MatHang mh = new MatHang();
        FileXml Fxml = new FileXml();
        string MaHang, TenHang, NhaSx, SoLuong, ThongTinBaoHanh, DonViTinh;*/
        public DanhMucMatHang()
        {
            InitializeComponent();
            bllxm = new XeMayBLL();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            showAllxemay();
        }
       /* public void LoadDuLieu()
        {
            MaHang = txt_mahang.Text;
            TenHang = txt_th.Text;
            NhaSx = txt_nsx.Text;
            SoLuong = txt_sl.Text;
            ThongTinBaoHanh = txt_ttbh.Text;
            DonViTinh = txt_dvt.Text;
        }*/
        public void showAllxemay()
        {
            DataTable dt = bllxm.getALLXeMay();
            dgv.DataSource = dt;
        }
        /*public void hienthiMatHang()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("MatHang.xml");
            dgv.DataSource = dt;
        }*/
        private void show_Click(object sender, EventArgs e)
        {
            showAllxemay();
            /*hienthiMatHang();*/
        }
        private void reset_Click(object sender, EventArgs e)
        {
            txt_mahang.Text = "";
            txt_th.Text = "";
            txt_nsx.Text = "";
            txt_sl.Text = "";
            txt_ttbh.Text = "";
            txt_dvt.Text = "";
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string value = txt_tk.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dtt = bllxm.Findxemay(value);
                dgv.DataSource = dtt;
            }
            else
            {
                showAllxemay();
            }
            /*XmlTextReader reader = new XmlTextReader("MatHang.xml");
            XeMayDataSet ds = new XeMayDataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaHang";
            reader.Close();
            int index = dv.Find(txt_tk.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                txt_tk.Text = "";
                txt_tk.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaHang");
                dt.Columns.Add("TenHang");
                dt.Columns.Add("NhaSx");
                dt.Columns.Add("SoLuong");
                dt.Columns.Add("ThongTinBaoHanh");
                dt.Columns.Add("DonViTinh");
                object[] list = { dv[index]["MaHang"], dv[index]["TenHang"], dv[index]["NhaSx"], dv[index]["SoLuong"], dv[index]["ThongTinBaoHanh"], dv[index]["DonViTinh"] };
                dt.Rows.Add(list);
                dgv.DataSource = dt;
                txt_tk.Text = "";
            }*/
        }
        public bool CheckData()
        {
            if ((string.IsNullOrEmpty(txt_mahang.Text)) || (string.IsNullOrEmpty(txt_th.Text)) || (string.IsNullOrEmpty(txt_nsx.Text)) || (string.IsNullOrEmpty(txt_sl.Text)) || (string.IsNullOrEmpty(txt_ttbh.Text)) || (string.IsNullOrEmpty(txt_dvt.Text)))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahang.Focus();
                txt_th.Focus();
                txt_nsx.Focus();
                txt_sl.Focus();
                txt_ttbh.Focus();
                txt_dvt.Focus();
                return false;
            }
            return true;
        }
        private void them_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                XeMayModel xm = new XeMayModel();
                xm.MaHang = txt_mahang.Text;
                xm.TenHang = txt_th.Text;
                xm.NhaSx = txt_nsx.Text;
                xm.SoLuong = int.Parse(txt_sl.Text);
                xm.ThongTinBaoHanh = txt_ttbh.Text;
                xm.DonViTinh = txt_dvt.Text;
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắc muốn thêm mặt hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (bllxm.Insertxemay(xm) && dlr == DialogResult.Yes)
                {
                    showAllxemay();
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("lỗi Mã Hàng đã tồn tại, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            /*LoadDuLieu();
            if (mh.kiemtra(MaHang) == true)
            {
                MessageBox.Show("Mã Hàng đã tồn tại");
            }
            else
            {
                mh.themMH(MaHang, TenHang, NhaSx, SoLuong, ThongTinBaoHanh, DonViTinh);
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                hienthiMatHang();
                txt_mahang.Focus();
            }*/
        }
        private void sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mahang.Text))
                MessageBox.Show("Bạn Cần nhập mã hàng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (CheckData())
                {
                    XeMayModel xm = new XeMayModel();
                    xm.MaHang = txt_mahang.Text;
                    xm.TenHang = txt_th.Text;
                    xm.NhaSx = txt_nsx.Text;
                    xm.SoLuong = int.Parse(txt_sl.Text);
                    xm.ThongTinBaoHanh = txt_ttbh.Text;
                    xm.DonViTinh = txt_dvt.Text;
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắc muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (bllxm.Updatexemay(xm) && dlr == DialogResult.Yes)
                    {
                        showAllxemay();
                        MessageBox.Show("Đã sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);                       
                    }
                }
            }
            /*LoadDuLieu();
            mh.suaMH(MaHang, TenHang, NhaSx, SoLuong, ThongTinBaoHanh, DonViTinh);
            MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            hienthiMatHang();*/
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mahang.Text))
                MessageBox.Show("Bạn Cần nhập mã hàng cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                XeMayModel xm = new XeMayModel();
                xm.MaHang = txt_mahang.Text;
                DialogResult dlr = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (bllxm.DELETExemay(xm) && dlr == DialogResult.Yes)
                {
                    showAllxemay();
                    MessageBox.Show("Đã Xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            /* mh.xoaMH(MaHang);
             MessageBox.Show("Đã xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
             hienthiMatHang();*/
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy thông tin dòng hiện tại hiển thị ra các textbox
            /*txt_mahang.ReadOnly = true;*/
            int d = dgv.CurrentRow.Index;
            txt_mahang.Text = dgv.Rows[d].Cells[0].Value.ToString();
            txt_th.Text = dgv.Rows[d].Cells[1].Value.ToString();
            txt_nsx.Text = dgv.Rows[d].Cells[2].Value.ToString();
            txt_sl.Text = dgv.Rows[d].Cells[3].Value.ToString();
            txt_ttbh.Text = dgv.Rows[d].Cells[4].Value.ToString();
            txt_dvt.Text = dgv.Rows[d].Cells[5].Value.ToString();
        }
        private void preview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\MatHang.xml";
            try
            {
                System.Diagnostics.Process.Start("Explorer.exe", path);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa có file cần mở trong bin/debug", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
