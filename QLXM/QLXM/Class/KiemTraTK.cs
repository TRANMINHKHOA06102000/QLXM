using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLXM
{
    
    class KiemTraTK
    {
        FileXml Fxml = new FileXml();
        public bool kiemtraTTDN(string duongdan, string TaiKhoan, string MatKhau)
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi(duongdan);
            dt.DefaultView.RowFilter = "TaiKhoan ='" + TaiKhoan + "' AND MatKhau='" + MatKhau + "'";
            if (dt.DefaultView.Count > 0)
                return true;
            return false;

        }
    }
}
