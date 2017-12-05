using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;

namespace BALayer
{
    public class BA
    {
        //BE mBE = new BE();
        DA mDA = new DA();
        public int UserLogin(BE BE_In)
        {
            return mDA.UserLogin(BE_In);
        }
        public string IsAdmin(BE BE_In)
        {
            return mDA.IsAdmin(BE_In);
        }
        public string SelectUserName(BE BE_IN)
        {
           return mDA.SelectUserName(BE_IN);
        }
    }
}
