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
    }
}
