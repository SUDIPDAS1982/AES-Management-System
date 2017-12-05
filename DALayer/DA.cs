using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using BELayer;
using System.ComponentModel;
using System.Globalization;
using System.Drawing;

namespace DALayer
{
    public class DA
    {
        SqlConnection con = new SqlConnection("Data Source=ADVENSOFT-PC\\SQLEXPRESS;Initial Catalog=AESDB;Integrated Security=True");

        public int UserLogin(BE BE_In)
        {
            con.Open();
            string pUserName = BE_In.UserName;
            string pPassword = BE_In.Password;
            
            SqlCommand cmd = new SqlCommand("select UserName,UserPassword from tblUserLogin where UserName='" + pUserName + "'and UserPassword='" + pPassword + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i = dt.Rows.Count;
            con.Close();
            return i;
        }
        public string IsAdmin(BE BE_In)
        {
            con.Open();
            string pUserName = BE_In.UserName;
            string pPassword = BE_In.Password;
            SqlCommand cmd = new SqlCommand("select UserRole from tblUserLogin where UserName='" + pUserName + "'and UserPassword='" + pPassword + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
        public string SelectUserName(BE BE_In)
        {
            con.Open();
            string pUserName = BE_In.UserName;
            string pPassword = BE_In.Password;
            SqlCommand cmd = new SqlCommand("select fullname from tblUserDetails where id in (select UserId from tblUserLogin where UserName='" + pUserName + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
    }
}
