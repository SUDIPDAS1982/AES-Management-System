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
    public class clsDA
    {
        SqlConnection con = new SqlConnection("Data Source=ADVENSOFT-PC\\SQLEXPRESS;Initial Catalog=AESDB;Integrated Security=True");

        public int UserLogin(clsBE BE_In)
            //================================
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
        public string IsAdmin(clsBE BE_In)
            //==============================
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
        public string SelectUserName(clsBE BE_In)
            //====================================
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
        public Dictionary<string, string> GetUserIdName()
            //==============================================================
        {
            Dictionary<string, string> pUserIdName = new Dictionary<string, string>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select id, fullname from tblUserDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pUserIdName.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
            }
            con.Close();
            return pUserIdName;
        }
        public List<List<string>> GetAllUserDetails()
        //==============================================================
        {
            List<List<string>> pAllUserDetails = new List<List<string>>();           
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblUserDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                List<string> pCol = new List<string>();
                for (int j = 0; j < dt.Columns.Count ; j++)
                {
                    pCol.Add(dt.Rows[i][j].ToString());
                }                
                pAllUserDetails.Add(pCol);
            }
            con.Close();
            return pAllUserDetails;
        }
        public List<List<string>> GetSingleUserDetails(clsBE BE_In)
        //==============================================================
        {
            List<List<string>> pSingleUserDetails = new List<List<string>>();
            con.Open();
            int pUserId = BE_In.UserId;
            SqlCommand cmd = new SqlCommand("select * from tblUserDetails where id='" + pUserId + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                List<string> pCol = new List<string>();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    pCol.Add(dt.Rows[i][j].ToString());
                }
                pSingleUserDetails.Add(pCol);
            }
            con.Close();
            return pSingleUserDetails;
        }
        public int IsLoggedIn(clsBE BE_In)
        //==============================
        {
            con.Open();
            string pUserName = BE_In.UserName;
            DateTime pLoginDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string pSQL = "select username from tbluserattendance where logindate='" + pLoginDate + "' and userid in (select UserId from tblUserLogin where UserName='" + pUserName + "')";
            SqlCommand cmd = new SqlCommand(pSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows.Count;
        }
        public string GetUserId(clsBE BE_In)
            //=======================================
        {
            con.Open();
            string pUserName = BE_In.UserName;
            SqlCommand cmd = new SqlCommand("select userid from tblUserLogin where username='" + pUserName + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
    }
}
