using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QLXM
{
    class MatHang
    {
        FileXml Fxml = new FileXml();
        /*public bool kiemtra(string MaHang)
        {
            XmlTextReader reader = new XmlTextReader("MatHang.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/MatHang[MaHang='" + MaHang + "']");
            reader.Close();
            bool kq = true;
            if (node != null)
            {
                return kq = true;
            }
            else
            {
                return kq = false;
            }
        }*/
        public void themMH(string MaHang, string TenHang ,string NhaSx, string SoLuong, string ThongTinBaoHanh, string DonViTinh)
        {
            string noiDung = "<_x0027_MatHang_x0027_>" +
                    "<MaHang>" + MaHang + "</MaHang>" +
                    "<TenHang>" + TenHang + "</TenHang>" +
                    "<NhaSx>" + NhaSx + "</NhaSx>" +
                    "<SoLuong>" + SoLuong + "</SoLuong>" +
                    "<ThongTinBaoHanh>" + ThongTinBaoHanh + "</ThongTinBaoHanh>" +
                    "<DonViTinh>" + DonViTinh + "</DonViTinh>" +
                    "</_x0027_MatHang_x0027_>";
            Fxml.Them("MatHang.xml", noiDung);
        }
        public void suaMH(string MaHang, string TenHang, string NhaSx, string SoLuong, string ThongTinBaoHanh, string DonViTinh)
        {

            string noiDung = "<MaHang>" + MaHang + "</MaHang>" +
                    "<TenHang>" + TenHang + "</TenHang>" +
                    "<NhaSx>" + NhaSx + "</NhaSx>" +
                    "<SoLuong>" + SoLuong + "</SoLuong>" +
                    "<ThongTinBaoHanh>" + ThongTinBaoHanh + "</ThongTinBaoHanh>" +
                    "<DonViTinh>" + DonViTinh + "</DonViTinh>";
            Fxml.Sua("MatHang.xml", "MatHang", "MaHang", MaHang, noiDung);
        }
        public void xoaMH(string MaHang)
        {
            Fxml.Xoa("MatHang.xml", "MatHang", "MaHang", MaHang);
        }
    }
}
