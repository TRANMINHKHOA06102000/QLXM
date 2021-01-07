using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLXEMAY.Model;
using QLXM.DataSet;
using System.Xml.Linq;

namespace QLXEMAY.Class
{
    class XeMayDAL
    {
        Connection tc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public XeMayDAL()
        {
            tc = new Connection();
        }
        public DataTable getAllXeMay()
        {
            //tạo lệnh sql
            string sql = "SELECT * from MatHang";
            //kết nối sql
            SqlConnection con = tc.getconnect();
            //khơi tạo đói tượng lớp sqldata
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Insertxemay(XeMayModel xm)
        {
            string sql = "INSERT INTO MatHang(MaHang,TenHang,NhaSx,SoLuong,ThongTinBaoHanh,DonViTinh) VALUES(@MaHang,@TenHang,@NhaSx,@SoLuong,@ThongTinBaoHanh,@DonViTinh)";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHang", SqlDbType.Char).Value = xm.MaHang;
                cmd.Parameters.Add("@TenHang", SqlDbType.NVarChar).Value = xm.TenHang;
                cmd.Parameters.Add("@NhaSx", SqlDbType.NVarChar).Value = xm.NhaSx;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = xm.SoLuong;
                cmd.Parameters.Add("@ThongTinBaoHanh", SqlDbType.NVarChar).Value = xm.ThongTinBaoHanh;
                cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = xm.DonViTinh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Updatexemay(XeMayModel xm)
        {
            string sql = "UPDATE MatHang SET MaHang= @MaHang, TenHang=@TenHang, NhaSx=@NhaSx, SoLuong=@SoLuong, ThongTinBaoHanh=@ThongTinBaoHanh, DonViTinh=@DonViTinh WHERE MaHang=@MaHang";

            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHang", SqlDbType.Char).Value = xm.MaHang;
                cmd.Parameters.Add("@TenHang", SqlDbType.NVarChar).Value = xm.TenHang;
                cmd.Parameters.Add("@NhaSx", SqlDbType.NVarChar).Value = xm.NhaSx;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = xm.SoLuong;
                cmd.Parameters.Add("@ThongTinBaoHanh", SqlDbType.NVarChar).Value = xm.ThongTinBaoHanh;
                cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = xm.DonViTinh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DELETExemay(XeMayModel xm)
        {
            String sql = "DELETE MatHang WHERE MaHang=@MaHang";
            SqlConnection con = tc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHang", SqlDbType.Char).Value = xm.MaHang;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public DataTable Findxemay(string xm)
        {
            string sql = "SELECT * FROM MatHang WHERE MaHang like '%" + xm + "%' or TenHang like '%" + xm + "%'";
            //kết nối sql
            SqlConnection con = tc.getconnect();
            //khơi tạo đói tượng lớp sqldata
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
