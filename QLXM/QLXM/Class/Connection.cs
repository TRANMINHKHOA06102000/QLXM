using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLXEMAY.Model
{
    class Connection
    {
        string conn;
        public Connection()
        {
            conn = "Data Source=KHOA;Initial Catalog=QLXeMay;Integrated Security=True";
        }
        public SqlConnection getconnect()
        {
            return new SqlConnection(conn);
        }
    }
}
