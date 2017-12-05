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
        BE be = new BE();
        DA da = new DA();
        public int UserLogin(BE be)
        {
            return da.UserLogin(be);
        }
        public string IsAdmin(BE be)
        {
            return da.IsAdmin(be);
        }
    }
}
