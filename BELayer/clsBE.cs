using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BELayer
{
    public class clsBE
    {
        public string _UserName;

        public  string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public int _UserId;

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }
}
