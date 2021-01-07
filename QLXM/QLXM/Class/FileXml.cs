using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace QLXM
{
    class FileXml
    {
        string Conn = "Data Source=KHOA;Initial Catalog=QLXeMay;Integrated Security=True";
        public void TaoXML(string bang)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            string sql = "Select* from " + bang;
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable("'" + bang + "'");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\" + bang + ".xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLNhanVien()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from NhanVien", conn);
            DataTable dt = new DataTable("NhanVien");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\NhanVien.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLKhachHang()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from KhachHang", conn);
            DataTable dt = new DataTable("KhachHang");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\KhachHang.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLMatHang()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from MatHang", conn);
            DataTable dt = new DataTable("MatHang");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\MatHang.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLNhaCungCap()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from NhaCungCap", conn);
            DataTable dt = new DataTable("NhaCungCap");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\NhanVien.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLPhieuNhap()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from PhieuNhap", conn);
            DataTable dt = new DataTable("PhieuNhap");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\PhieuNhap.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLPhieuXuat()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from PhieuXuat", conn);
            DataTable dt = new DataTable("PhieuXuat");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\PhieuXuat.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLChiTietPhieuNhap()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from ChiTietPhieuNhap", conn);
            DataTable dt = new DataTable("ChiTietPhieuNhap");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\ChiTietPhieuNhap.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLChiTietPhieuXuat()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from ChiTietPhieuXuat", conn);
            DataTable dt = new DataTable("ChiTietPhieuXuat");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\ChiTietPhieuXuat.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLTaiKhoan()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from TaiKhoan", conn);
            DataTable dt = new DataTable("TaiKhoan");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\TaiKhoan.xml", XmlWriteMode.WriteSchema);
        }
        public void TaoXMLChamCong()
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from ChamCong", conn);
            DataTable dt = new DataTable("ChamCong");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\ChamCong.xml", XmlWriteMode.WriteSchema);
        }
        public void InsertOrUpDateSQL(string sql)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable HienThi(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = Application.StartupPath + "\\" + file;
            if (File.Exists(FilePath))
            {
                FileStream fsReadXML = new FileStream(FilePath, FileMode.Open);
                dt.ReadXml(fsReadXML);
                fsReadXML.Close();
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
            }
            return dt;
        }
        public void Them(string duongDan, string noiDung)
        {
            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode currNode;
            XmlDocumentFragment docFrag = doc.CreateDocumentFragment();
            docFrag.InnerXml = noiDung;
            currNode = doc.DocumentElement;
            currNode.InsertAfter(docFrag, currNode.LastChild);
            doc.Save(duongDan);
        }
        public void Xoa(string duongDan, string tenFileXML, string xoaTheoTruong, string giaTriTruong)
        {
            string fileName = Application.StartupPath + "\\" + duongDan;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode nodeCu = doc.SelectSingleNode("/NewDataSet/" + tenFileXML + "[" + xoaTheoTruong + "='" + giaTriTruong + "']");
            doc.DocumentElement.RemoveChild(nodeCu);
            doc.Save(fileName);
        }

        public void Sua(string duongDan, string tenFile, string suaTheoTruong, string giaTriTruong, string noiDung)
        {
            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode oldHang;
            XmlElement root = doc.DocumentElement;
            oldHang = root.SelectSingleNode("/NewDataSet/" + tenFile + "[" + suaTheoTruong + "='" + giaTriTruong + "']");
            XmlElement newhang = doc.CreateElement(tenFile);
            newhang.InnerXml = noiDung;
            root.ReplaceChild(newhang,oldHang);
            doc.Save(duongDan);
        }
    }
}
