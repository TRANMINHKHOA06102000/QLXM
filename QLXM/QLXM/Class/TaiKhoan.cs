using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QLXM
{  
    class TaiKhoan
    {
        FileXml Fxml = new FileXml();
        public void XacNhanDiLam(string TaiKhoan, int Ngay, int Thang, int Nam)
        {
            XmlTextReader textread = new XmlTextReader("ChamCong.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(textread);
            textread.Close();
            XmlNode currNode;
            XmlDocumentFragment docFrag = doc.CreateDocumentFragment();
            docFrag.InnerXml = "<ChamCong>" +
            "<TaiKhoan>" + TaiKhoan + "</TaiKhoan>" +
            "<Ngay>" + Ngay + "</Ngay>" +
            "<Thang>" + Thang + "</Thang>" +
            "<Nam>" + Nam + "</Nam>" +
            "</ChamCong>";
            currNode = doc.DocumentElement;
            currNode.InsertAfter(docFrag, currNode.LastChild);
            doc.Save("ChamCong.xml");
        }
        public bool kiemtraNgayThang(string TaiKhoan, int Ngay, int Thang, int Nam)
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("ChamCong.xml");
            dt.DefaultView.RowFilter = "TaiKhoan ='" + TaiKhoan + "' AND Ngay='" + Ngay + "' AND Thang='" + Thang + "' AND Nam='" + Nam + "'";
            if (dt.DefaultView.Count > 0)
                return true;
            return false;
        }

    }
}
