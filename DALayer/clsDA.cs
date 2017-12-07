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
        public int IsUserLoggedIn(clsBE BE_In, DateTime pDate_In)
        //==========================================================
        {
            con.Open();
            string pUserName = BE_In.UserName;
            DateTime pLoginDate = pDate_In;
            string pSQL = "select fldUserName from tblUserAttendance where fldLoginDate='" + pLoginDate + "' and fldUserId in (select fldUserId from tblUserLogin where fldUserName='" + pUserName + "')";
            SqlCommand cmd = new SqlCommand(pSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows.Count;
        }
        public int IsUserLoggedOut(clsBE BE_In, DateTime pDate_In, DateTime pTime_In)
        //============================================================================
        {
            con.Open();
            string pUserName = BE_In.UserName;
            DateTime pLoginDate = pDate_In;
            DateTime pLoginTime = pTime_In;
            string pSQL = "select fldLogoutTime from tblUserAttendanceDetails where fldLoginDate='" + pLoginDate + "' and fldLoginTime='"+pLoginTime+"' and fldUserId in (select fldUserId from tblUserLogin where fldUserName='" + pUserName + "')";
            SqlCommand cmd = new SqlCommand(pSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (!Convert.IsDBNull(dt.Rows[0][0]))
            {
                return 1;
            }
            
            return 0;
        }
        public string GetMaxLogInTime(clsBE BE_In, DateTime pDate_In)
        {
            con.Open();
            string pUserName = BE_In.UserName;
            DateTime pLoginDate = pDate_In;
            SqlCommand cmd = new SqlCommand("select MAX(fldLoginTime) from tblUserAttendanceDetails where fldUserName='" + pUserName + "' and fldLoginDate='" + pLoginDate + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
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
        public int TimeInInsert(clsBE BE_In, DateTime pDate_In, DateTime pTime_In)
        {
            con.Open();
            int i = 0;
            String pUserName = BE_In.UserName;
            int pUserId = BE_In.UserId;
            SqlCommand cmd = new SqlCommand("INSERT INTO tblUserAttendance (fldUserId, fldUserName, fldLoginDate, fldLoginTime) values ('"+pUserId+"','" + pUserName + "',' " +pDate_In + "', '" + pTime_In + "')", con);
            i = cmd.ExecuteNonQuery();
            if(i > 0)
            {
                cmd = new SqlCommand("INSERT INTO tblUserAttendanceDetails (fldUserId, fldUserName, fldLoginDate, fldLoginTime) values ('" + pUserId + "','" + pUserName + "',' " + pDate_In + "', '" + pTime_In + "')", con);
                i = cmd.ExecuteNonQuery();
            }            
            con.Close();
            return i;
        }
        public int TimeInReInsert(clsBE BE_In, DateTime pDate_In, DateTime pTime_In)
        {
            con.Open();
            int i = 0;
            String pUserName = BE_In.UserName;
            int pUserId = BE_In.UserId;
            SqlCommand cmd = new SqlCommand("INSERT INTO tblUserAttendanceDetails (fldUserId, fldUserName, fldLoginDate, fldLoginTime) values ('" + pUserId + "','" + pUserName + "',' " + pDate_In + "', '" + pTime_In + "')", con);
            i = cmd.ExecuteNonQuery();           
            con.Close();
            return i;
        }
        public int TimeOutInsert(clsBE BE_In, DateTime pDate_In, DateTime pTime_In, DateTime pLastLoginTime_In)
        {
            con.Open();
            int i = 0;
            String pUserName = BE_In.UserName;
            SqlCommand cmd = new SqlCommand("update tblUserAttendance set fldLogoutTime='" + pTime_In + "' where fldUserName='" + pUserName + "' and fldLoginDate='" + pDate_In + "'", con);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                cmd = new SqlCommand("update tblUserAttendanceDetails set fldLogoutTime='" + pTime_In + "' where fldUserName='" + pUserName + "' and fldLoginDate='" + pDate_In + "' and fldLoginTime='"+ pLastLoginTime_In + "'", con);
                i = cmd.ExecuteNonQuery();
            }
            con.Close();
            return i;
        }
        public List<List<string>> GetSingleUserAttendanceDetails(clsBE BE_In, DateTime pFromDate_In, DateTime pToDate_In)
        //==================================================================================================================
        {
            List<List<string>> pSingleUserAttendanceDetails = new List<List<string>>();
            con.Open();
            String pUserName = BE_In.UserName;
            SqlCommand cmd = new SqlCommand("select fldUserId, fldUserName, fldLoginDate, fldLoginTime, fldLogoutTime from tblUserAttendance where fldUserName='" + pUserName + "' and fldLoginDate between '" + pFromDate_In + "' and '" + pToDate_In + "'", con);
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
                pSingleUserAttendanceDetails.Add(pCol);
            }
            con.Close();
            return pSingleUserAttendanceDetails;
        }
    }
}
