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
            
            SqlCommand cmd = new SqlCommand("select fldUserName,fldUserPassword from tblUserLogin where fldUserName='" + pUserName + "'and fldUserPassword='" + pPassword + "'", con);
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
            SqlCommand cmd = new SqlCommand("select fldUserRole from tblUserLogin where fldUserName='" + pUserName + "'and fldUserPassword='" + pPassword + "'", con);
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
            SqlCommand cmd = new SqlCommand("select fldFullName from tblUserDetails where fldId in (select fldUserId from tblUserLogin where fldUserName='" + pUserName + "')", con);
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
            SqlCommand cmd = new SqlCommand("select fldId, fldFullName from tblUserDetails", con);
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
            SqlCommand cmd = new SqlCommand("select * from tblUserDetails where fldId='" + pUserId + "'", con);
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
        public int IsUserLoggedIn(clsBE BE_In)
        //==============================
        {
            con.Open();
            string pUserName = BE_In.UserName;
            DateTime pLoginDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string pSQL = "select fldUserName from tblUserAttendance where fldLoginDate='" + pLoginDate + "' and fldUserId in (select fldUserId from tblUserLogin where fldUserName='" + pUserName + "')";
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
            SqlCommand cmd = new SqlCommand("select fldUserId from tblUserLogin where fldUserName='" + pUserName + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
        public int TimeInInsert(clsBE BE_In, DateTime pDate, DateTime pTime)
        {
            con.Open();
            String pUserName = BE_In.UserName;
            int pUserId = BE_In.UserId;
            SqlCommand cmd = new SqlCommand("INSERT INTO tblUserAttendance (fldUserId, fldUserName, fldLoginDate, fldLoginTime) values ('"+pUserId+"','" + pUserName + "',' " +pDate + "', '" + pTime + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string IsUserActive(clsBE BE_In)
        //==============================
        {
            con.Open();
            string pUserName = BE_In.UserName;
            string pPassword = BE_In.Password;
            SqlCommand cmd = new SqlCommand("select fldUserActive from tblUserLogin where fldUserName='" + pUserName + "'and fldUserPassword='" + pPassword + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }
        public int TimeOutInsert(clsBE BE_In, DateTime pDate, DateTime pTime)
        {
            con.Open();
            String pUserName = BE_In.UserName;
            SqlCommand cmd = new SqlCommand("update tblUserAttendance set fldLogoutTime='" + pTime + "' where fldUserName='" + pUserName + "' and fldLoginDate='" + pDate + "'", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
