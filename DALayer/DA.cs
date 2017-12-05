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

        public int UserLogin(BE be)
        {
            con.Open();
            string pUserName = be.UserName;
            string pPassword = be.Password;
            
            SqlCommand cmd = new SqlCommand("select UserName,UserPassword from tblUserLogin where UserName='" + pUserName + "'and UserPassword='" + pPassword + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i = dt.Rows.Count;
            con.Close();
            return i;
        }
        public string IsAdmin(BE be)
        {
            con.Open();
            string pUserName = be.UserName;
            string pPassword = be.Password;
            SqlCommand cmd = new SqlCommand("select UserRole from tblUserLogin where UserName='" + pUserName + "'and UserPassword='" + pPassword + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
    }
}
