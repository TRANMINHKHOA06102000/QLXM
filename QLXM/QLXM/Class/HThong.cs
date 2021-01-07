using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXM
{
    class HThong
    {
        FileXml Fxml = new FileXml();
        public void TaoXML()
        {
            Fxml.TaoXML("NhanVien");
            Fxml.TaoXML("KhachHang");
            Fxml.TaoXML("MatHang");
            Fxml.TaoXML("NhaCungCap");
            Fxml.TaoXML("PhieuNhap");
            Fxml.TaoXML("PhieuXuat");
            Fxml.TaoXML("ChiTietPhieuNhap");
            Fxml.TaoXML("ChiTietPhieuXuat");
            Fxml.TaoXML("TaiKhoan");
            Fxml.TaoXML("ChamCong");
        }
        void CapNhapTungBang(string tenBang)
        {
            string duongDan = @"" + tenBang + ".xml";
            DataTable table = Fxml.HienThi(duongDan);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sql = "insert into " + tenBang + " values(";
                for (int j = 0; j < table.Columns.Count - 1; j++)
                {
                    sql += "N'" + table.Rows[i][j].ToString().Trim() + "',";
                }
                sql += "N'" + table.Rows[i][table.Columns.Count - 1].ToString().Trim() + "'";
                sql += ")";
                //MessageBox.Show(sql);
                Fxml.InsertOrUpDateSQL(sql);
            }
        }
        public void CapNhapSQL()
        {

            //Xóa toàn bộ dữ liệu các bảng
            Fxml.InsertOrUpDateSQL("delete from ChiTietPhieuNhap");
            Fxml.InsertOrUpDateSQL("delete from ChiTietPhieuXuat");
            Fxml.InsertOrUpDateSQL("delete from PhieuNhap");
            Fxml.InsertOrUpDateSQL("delete from PhieuXuat");
            Fxml.InsertOrUpDateSQL("delete from NhanVien");
            Fxml.InsertOrUpDateSQL("delete from KhachHang");
            Fxml.InsertOrUpDateSQL("delete from MatHang");
            Fxml.InsertOrUpDateSQL("delete from NhaCungCap");
            Fxml.InsertOrUpDateSQL("delete from ChamCong");
            Fxml.InsertOrUpDateSQL("delete from TaiKhoan");            
            //Cập nhập toàn bộ dữ liệu các bảng
            CapNhapTungBang("NhanVien");
            CapNhapTungBang("KhachHang");
            CapNhapTungBang("MatHang");
            CapNhapTungBang("NhaCungCap");
            CapNhapTungBang("PhieuNhap");
            CapNhapTungBang("PhieuXuat");
            CapNhapTungBang("ChiTietPhieuNhap");
            CapNhapTungBang("ChiTietPhieuXuat");
            CapNhapTungBang("TaiKhoan");
            CapNhapTungBang("ChamCong");
        }
    }
}
