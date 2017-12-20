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
            SqlCommand cmd = new SqlCommand("select fldFullName from tblUserPersonalDetails where fldId in (select fldUserId from tblUserLogin where fldUserName='" + pUserName + "')", con);
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
            SqlCommand cmd = new SqlCommand("select fldId, fldFullName from tblUserPersonalDetails where fldId in (select fldUserId from tblUserLogin where fldUserActive='"+true+"')", con);
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
        public List<List<string>> GetAllUserPersonalDetails()
        //==============================================================
        {
            List<List<string>> pAllUserDetails = new List<List<string>>();           
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblUserPersonalDetails where fldId in (select fldUserId from tblUserLogin where fldUserActive='" + true + "')", con);
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
        public List<List<string>> GetSingleUserPersonalDetails(clsBE BE_In)
        //==============================================================
        {
            List<List<string>> pSingleUserDetails = new List<List<string>>();
            con.Open();
            int pUserId = BE_In.UserId;
            SqlCommand cmd = new SqlCommand("select * from tblUserPersonalDetails where fldId='" + pUserId + "'", con);
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
            string pSQL = "select fldUserName from tblUserAttendanceSummary where fldLoginDate='" + pLoginDate + "' and fldUserId in (select fldUserId from tblUserLogin where fldUserName='" + pUserName + "')";
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
			//===========================================================
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
        public int TimeInInsert(clsBE BE_In, DateTime pDate_In, DateTime pTime_In, string pRemarks_In)
			//==========================================================================================
        {
            con.Open();
            int i = 0;
            String pUserName = BE_In.UserName;
            int pUserId = BE_In.UserId;
            SqlCommand cmd = new SqlCommand("INSERT INTO tblUserAttendanceSummary (fldUserId, fldUserName, fldLoginDate, fldLoginTime) values ('"+pUserId+"','" + pUserName + "',' " +pDate_In + "', '" + pTime_In + "')", con);
            i = cmd.ExecuteNonQuery();
            if(i > 0)
            {
                cmd = new SqlCommand("INSERT INTO tblUserAttendanceDetails (fldUserId, fldUserName, fldLoginDate, fldLoginTime, fldLoginRemarks) values ('" + pUserId + "','" + pUserName + "',' " + pDate_In + "', '" + pTime_In + "', '"+pRemarks_In+"')", con);
                i = cmd.ExecuteNonQuery();
            }            
            con.Close();
            return i;
        }
        public int TimeInReInsert(clsBE BE_In, DateTime pDate_In, DateTime pTime_In, string pRemarks_In)
			//=================================================================================================
        {
            con.Open();
            int i = 0;
            String pUserName = BE_In.UserName;
            int pUserId = BE_In.UserId;
            SqlCommand cmd = new SqlCommand("INSERT INTO tblUserAttendanceDetails (fldUserId, fldUserName, fldLoginDate, fldLoginTime, fldLoginRemarks) values ('" + pUserId + "','" + pUserName + "',' " + pDate_In + "', '" + pTime_In + "', '" + pRemarks_In + "')", con);
            i = cmd.ExecuteNonQuery();           
            con.Close();
            return i;
        }
        public int TimeOutInsert(clsBE BE_In, DateTime pDate_In, DateTime pTime_In, DateTime pLastLoginTime_In, string pRemarks_In)
			//========================================================================================================================
        {
            con.Open();
            int i = 0;
            String pUserName = BE_In.UserName;
            SqlCommand cmd = new SqlCommand("update tblUserAttendanceSummary set fldLogoutTime='" + pTime_In + "' where fldUserName='" + pUserName + "' and fldLoginDate='" + pDate_In + "'", con);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                cmd = new SqlCommand("update tblUserAttendanceDetails set fldLogoutTime='" + pTime_In + "' , fldLogoutRemarks='"+pRemarks_In+"' where fldUserName='" + pUserName + "' and fldLoginDate='" + pDate_In + "' and fldLoginTime='"+ pLastLoginTime_In + "'", con);
                i = cmd.ExecuteNonQuery();
            }
            con.Close();
            return i;
        }
        public List<List<string>> GetSingleUserAttendanceSummary(clsBE BE_In, DateTime pFromDate_In, DateTime pToDate_In)
        //==================================================================================================================
        {
            List<List<string>> pSingleUserAttendanceSummary = new List<List<string>>();
            con.Open();
            String pUserName = BE_In.UserName;
            SqlCommand cmd = new SqlCommand("select fldUserId, fldUserName, fldLoginDate, fldLoginTime, fldLogoutTime from tblUserAttendanceSummary where fldUserName='" + pUserName + "' and fldLoginDate between '" + pFromDate_In + "' and '" + pToDate_In + "'", con);
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
                pSingleUserAttendanceSummary.Add(pCol);
            }
            con.Close();
            return pSingleUserAttendanceSummary;
        }
		public List<List<string>> GetSingleUserAttendanceDetails(clsBE BE_In, DateTime pLoginDate_In)
		//============================================================================================
		{
			List<List<string>> pSingleUserAttendanceDetails = new List<List<string>>();
			con.Open();
			String pUserName = BE_In.UserName;
			SqlCommand cmd = new SqlCommand("select fldUserName, fldLoginDate, fldLoginTime, fldLoginRemarks, fldLogoutTime, fldLogoutRemarks from tblUserAttendanceDetails where fldUserName='" + pUserName + "' and fldLoginDate='" + pLoginDate_In + "'", con);
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
		public int EditUserPersonalDetails(clsBE BE_In)
			//===============================================
		{
			con.Open();
			int pUserId = BE_In.UserId;
			string pUserAddress = BE_In.UserAddress;
			int pUserPincode = BE_In.UserPincode;
			string pUserGender = BE_In.UserGender;
			DateTime pUserDOB = BE_In.UserDOB;
			Int64 pUserContactNo = BE_In.UserContactNo;
			string pUserEmail = BE_In.UserEmail;
			string pUserQualification = BE_In.UserQualification;
			SqlCommand cmd = new SqlCommand("update tblUserPersonalDetails set fldAddress='" + pUserAddress + "', fldPincode='" + pUserPincode + "', fldGender='" + pUserGender + "', fldDOB='" + pUserDOB + "', fldContactNo='" + pUserContactNo + "', fldEmail='" + pUserEmail + "', fldQualification='" + pUserQualification + "' where fldId='"+pUserId+"'", con);
			int i = cmd.ExecuteNonQuery();
			con.Close();
			return i;
		}
		public int DeleteUser(clsBE BE_In)
			//=================================
		{
			con.Open();
			int pUserId = BE_In.UserId;
			SqlCommand cmd = new SqlCommand("update tblUserLogin set fldUserActive='" + false + "' where fldUserId='" + pUserId + "'", con);
			int i = cmd.ExecuteNonQuery();
			con.Close();
			return i;
		}
		public string IsDeleteAdmin(clsBE BE_In)
		//==============================
		{
			con.Open();
			int pUserId = BE_In.UserId;
			SqlCommand cmd = new SqlCommand("select fldUserRole from tblUserLogin where fldUserId='" + pUserId + "'", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt.Rows[0][0].ToString();
		}
		public int AddUserPersonalDetails(clsBE BE_In)
		//===============================================
		{
			con.Open();
			string pUserRole = BE_In.UserRole;
			bool pUserActive = true;
			String pUserFullName = BE_In.UserFullName;
			string pUserAddress = BE_In.UserAddress;
			int pUserPincode = BE_In.UserPincode;
			string pUserGender = BE_In.UserGender;
			DateTime pUserDOB = BE_In.UserDOB;
			Int64 pUserContactNo = BE_In.UserContactNo;
			string pUserEmail = BE_In.UserEmail;
			string pUserQualification = BE_In.UserQualification;
			SqlCommand cmd = new SqlCommand("insert into tblUserPersonalDetails (fldFullName, fldAddress, fldPincode, fldGender, fldDOB, fldContactNo, fldEmail, fldQualification) values ('"+pUserFullName+"','" + pUserAddress + "','" + pUserPincode + "','" + pUserGender + "','" + pUserDOB + "','" + pUserContactNo + "','" + pUserEmail + "','" + pUserQualification + "')", con);
			int i = 0;
			i = cmd.ExecuteNonQuery();
			if (i > 0)
			{
				cmd = new SqlCommand("insert into tblUserLogin (fldUserRole, fldUserActive) values('" + pUserRole + "','" + pUserActive + "')", con);
				i = cmd.ExecuteNonQuery();
			}
			if (i > 0)
			{
				cmd = new SqlCommand("select MAX(fldUserId) from tblUserLogin", con);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				i = Convert.ToInt32(dt.Rows[0][0].ToString());
			}
			con.Close();
			return i;
		}
	}
}
