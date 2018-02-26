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
        //
        SqlConnection con = new SqlConnection("Data Source=ADVENSOFT-PC\\SQLEXPRESS;Initial Catalog=AESDB;Integrated Security=True");

        public int UserLogin(clsBE BE_In)
            //================================
        {
            con.Open();
            string pUserName = BE_In.UserName;
            string pPassword = BE_In.Password;
            
            SqlCommand cmd = new SqlCommand("select fldUserId from tblUserLogin where fldUserName='" + pUserName + "'and fldUserPassword='" + pPassword + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
			return Convert.ToInt32(dt.Rows[0][0].ToString());
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
			//String pUserName = BE_In.UserName;
			int pUserId = BE_In.UserId;
            SqlCommand cmd = new SqlCommand("select fldUserId, fldUserName, fldLoginDate, fldLoginTime, fldLogoutTime from tblUserAttendanceSummary where fldUserId='" + pUserId + "' and fldLoginDate between '" + pFromDate_In + "' and '" + pToDate_In + "'", con);
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
			//String pUserName = BE_In.UserName;
			int pUserId = BE_In.UserId;
			SqlCommand cmd = new SqlCommand("select fldUserName, fldLoginDate, fldLoginTime, fldLoginRemarks, fldLogoutTime, fldLogoutRemarks from tblUserAttendanceDetails where fldUserId='" + pUserId + "' and fldLoginDate='" + pLoginDate_In + "'", con);
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
		public Dictionary<string, string> GetNewUserIdName()
		//==============================================================
		{
			Dictionary<string, string> pNewUserIdName = new Dictionary<string, string>();
			con.Open();
			SqlCommand cmd = new SqlCommand("select fldId, fldFullName from tblUserPersonalDetails where fldId in (select fldUserId from tblUserLogin where fldUserName is null)", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				pNewUserIdName.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
			}
			con.Close();
			return pNewUserIdName;
		}
		public int IsDuplicateUserName(clsBE BE_In)
		//==========================================
		{
			con.Open();
			string pUserName = BE_In.UserName;
			SqlCommand cmd = new SqlCommand("select * from tblUserLogin where fldUserName='" + pUserName + "'", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			int i = dt.Rows.Count;
			con.Close();
			return i;
		}
		public int SetUserNamePassword(clsBE BE_In)
		//==========================================
		{
			con.Open();
			int pUserId = BE_In.UserId;
			string pUserName = BE_In.UserName;
			string pUserPassword = BE_In.Password;
			DateTime pUserRegistrationDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
			SqlCommand cmd = new SqlCommand("update tblUserLogin set fldUserName='" + pUserName + "', fldUserPassword='"+ pUserPassword + "', fldUserRegistrationDate='"+ pUserRegistrationDate + "' where fldUserId='" + pUserId + "'", con);
			int i = cmd.ExecuteNonQuery();
			con.Close();
			return i;
		}
		public string GetMaxLeaveGenerateYear()
		//======================================
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select MAX(fldYear) from tblUserLeaveDetails", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt.Rows[0][0].ToString();
		}
		public int LeaveGenerate()
		//=========================
		{
			con.Open();
			int z = 0;
			SqlCommand cmd = new SqlCommand("select fldUserId, fldUserName from tblUserLogin where fldUserName is not null and fldUserActive=1", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				int pUserId = Convert.ToInt32(dt.Rows[i][0].ToString());
				string pUserName = dt.Rows[i][1].ToString();
				DateTime pLeaveGenerateDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
				int pYear = pLeaveGenerateDate.Year;
				for (int pSession = 1; pSession <= 2; pSession++)
				{
					double pAvailableCL = 5.0;
					double pTakenCL = 0.0;
					double pRemainCL = 5.0;
					double pAvailableEL = 7.5;
					double pTakenEL = 0.0;
					double pRemainEL = 7.5;
					double pAvailableML = 5.0;
					double pTakenML = 0.0;
					double pRemainML = 5.0;
					cmd = new SqlCommand("insert into tblUserLeaveDetails (fldUserId, fldUserName, fldYear, fldSession, fldAvailableCL, fldTakenCL, fldRemainCL, fldAvailableEL, fldTakenEL, fldRemainEL, fldAvailableML, fldTakenML, fldRemainML, fldLeaveGenerateDate) values ('" + pUserId + "','" + pUserName + "','" + pYear + "','" + pSession + "','" + pAvailableCL + "','" + pTakenCL + "','" + pRemainCL + "','" + pAvailableEL + "','" + pTakenEL + "','" + pRemainEL + "','" + pAvailableML + "','" + pTakenML + "','" + pRemainML + "', '"+ pLeaveGenerateDate + "')", con);
					z = cmd.ExecuteNonQuery();
				}
			}
			con.Close();
			return z;
		}
		public int SingleUserLeaveGenerate(clsBE BE_In)
		//==============================================
		{
			con.Open();
			int z = 0;
			int pUserId = BE_In.UserId;
			SqlCommand cmd = new SqlCommand("select fldUserName from tblUserLogin where fldUserId='"+pUserId+"'", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			string pUserName = dt.Rows[0][0].ToString();
			DateTime pCurrentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			int pYear = pCurrentDate.Year;
			int pMonthNo = pCurrentDate.Month;
			if (pMonthNo < 7)
			{
				int pSession = 1;
				int pMonth = 7 - pMonthNo;
				double pAvailableCL = 5.0 * pMonth / 6;
				double pTakenCL = 0.0;
				double pRemainCL = pAvailableCL;
				double pAvailableEL = 7.5 * pMonth / 6;
				double pTakenEL = 0.0;
				double pRemainEL = pAvailableEL;
				double pAvailableML = pAvailableCL;
				double pTakenML = 0.0;
				double pRemainML = pAvailableCL;
				cmd = new SqlCommand("insert into tblUserLeaveDetails (fldUserId, fldUserName, fldYear, fldSession, fldAvailableCL, fldTakenCL, fldRemainCL, fldAvailableEL, fldTakenEL, fldRemainEL, fldAvailableML, fldTakenML, fldRemainML) values ('" + pUserId + "','" + pUserName + "','" + pYear + "','" + pSession + "','" + pAvailableCL + "','" + pTakenCL + "','" + pRemainCL + "','" + pAvailableEL + "','" + pTakenEL + "','" + pRemainEL + "','" + pAvailableML + "','" + pTakenML + "','" + pRemainML + "')", con);
				z = cmd.ExecuteNonQuery();
				if (z > 0)
				{
					pSession = 2;
					pAvailableCL = 5.0;
					pTakenCL = 0.0;
					pRemainCL = 5.0;
					pAvailableEL = 7.5;
					pTakenEL = 0.0;
					pRemainEL = 7.5;
					pAvailableML = 5.0;
					pTakenML = 0.0;
					pRemainML = 5.0;
					cmd = new SqlCommand("insert into tblUserLeaveDetails (fldUserId, fldUserName, fldYear, fldSession, fldAvailableCL, fldTakenCL, fldRemainCL, fldAvailableEL, fldTakenEL, fldRemainEL, fldAvailableML, fldTakenML, fldRemainML) values ('" + pUserId + "','" + pUserName + "','" + pYear + "','" + pSession + "','" + pAvailableCL + "','" + pTakenCL + "','" + pRemainCL + "','" + pAvailableEL + "','" + pTakenEL + "','" + pRemainEL + "','" + pAvailableML + "','" + pTakenML + "','" + pRemainML + "')", con);
					z = cmd.ExecuteNonQuery();
				}
			}
			else
			{
				int pSession = 2;
				int pMonth = 13 - pMonthNo;
				double pAvailableCL = 5.0 * pMonth / 6;
				double pTakenCL = 0.0;
				double pRemainCL = pAvailableCL;
				double pAvailableEL = 7.5 * pMonth / 6;
				double pTakenEL = 0.0;
				double pRemainEL = pAvailableEL;
				double pAvailableML = pAvailableCL;
				double pTakenML = 0.0;
				double pRemainML = pAvailableCL;
				cmd = new SqlCommand("insert into tblUserLeaveDetails (fldUserId, fldUserName, fldYear, fldSession, fldAvailableCL, fldTakenCL, fldRemainCL, fldAvailableEL, fldTakenEL, fldRemainEL, fldAvailableML, fldTakenML, fldRemainML) values ('" + pUserId + "','" + pUserName + "','" + pYear + "','" + pSession + "','" + pAvailableCL + "','" + pTakenCL + "','" + pRemainCL + "','" + pAvailableEL + "','" + pTakenEL + "','" + pRemainEL + "','" + pAvailableML + "','" + pTakenML + "','" + pRemainML + "')", con);
				z = cmd.ExecuteNonQuery();
			}		
			con.Close();
			return z;
		}
		public Dictionary<string, string> GetNewRegisteredUserIdName()
		//==============================================================
		{
			Dictionary<string, string> pNewRegisteredUserIdName = new Dictionary<string, string>();
			con.Open();
			SqlCommand cmd = new SqlCommand("select fldId, fldFullName from tblUserPersonalDetails where fldId in (select login.fldUserId from tblUserLogin as login, tblUserLeaveDetails as LeaveDetails where login.fldUserActive=1 and login.fldUserRegistrationDate > LeaveDetails.fldLeaveGenerateDate and login.fldUserId=LeaveDetails.fldId)", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				pNewRegisteredUserIdName.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
			}
			con.Close();
			return pNewRegisteredUserIdName;
		}
	}
}
