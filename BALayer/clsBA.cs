using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;
using System.Data;


namespace BALayer
{
    public class clsBA
    {
        //BE mBE = new BE();
        clsDA mDA = new clsDA();
        public int UserLogin(clsBE BE_In)
        {
            return mDA.UserLogin(BE_In);
        }
        public string IsAdmin(clsBE BE_In)
        {
            return mDA.IsAdmin(BE_In);
        }
        public string SelectUserName(clsBE BE_In)
        {
           return mDA.SelectUserName(BE_In);
        }

        public Dictionary<string, string> GetUserIdName()
        //==============================================================
        {
            return mDA.GetUserIdName();
        }
        public List<List<string>> GetAllUserDetails()
        {
            return mDA.GetAllUserDetails();
        }
        public List<List<string>> GetSingleUserDetails(clsBE BE_In)
        {
            return mDA.GetSingleUserDetails(BE_In);
        }
        public int IsUserLoggedIn(clsBE BE_In)
        {
            DateTime pDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            return mDA.IsUserLoggedIn(BE_In, pDate);
        }
        public int IsUserLoggedOut(clsBE BE_In)
        {
            DateTime pDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime pTime = Convert.ToDateTime(mDA.GetMaxLogInTime(BE_In, pDate));
            return mDA.IsUserLoggedOut(BE_In, pDate, pTime);
        }
        public string GetUserId(clsBE BE_In)
        {
            return mDA.GetUserId(BE_In);
        }
        public int TimeInInsert(clsBE BE_In, string pRemarks_In, ref DateTime pTime_Out)
        {
            DateTime pDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime pTime = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            pTime_Out = pTime;
            return mDA.TimeInInsert(BE_In, pDate, pTime, pRemarks_In);
        }
        public int TimeInReInsert(clsBE BE_In, string pRemarks_In, ref DateTime pTime_Out)
        {
            DateTime pDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime pTime = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            pTime_Out = pTime;
            return mDA.TimeInReInsert(BE_In, pDate, pTime, pRemarks_In);
        }
        public string IsUserActive(clsBE BE_In)
        {
            return mDA.IsUserActive(BE_In);
        }
        public int TimeOutInsert(clsBE BE_In, string pRemarks_In, ref DateTime pTime_Out)
        {
            DateTime pDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime pTime = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            pTime_Out = pTime;
            DateTime pLastLoginTime = Convert.ToDateTime(mDA.GetMaxLogInTime(BE_In, pDate));
            return mDA.TimeOutInsert(BE_In, pDate, pTime, pLastLoginTime, pRemarks_In);
        }
        public List<List<string>> GetSingleUserAttendanceSummary(clsBE BE_In, DateTime pFromDate_In, DateTime pToDate_In)
        {
            return mDA.GetSingleUserAttendanceSummary(BE_In, pFromDate_In, pToDate_In);
        }
		public List<List<string>> GetSingleUserAttendanceDetails(clsBE BE_In, DateTime pLoginDate_In)
		{
			return mDA.GetSingleUserAttendanceDetails(BE_In, pLoginDate_In);
		}
	}
}
