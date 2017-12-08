using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using BELayer;

namespace AES_Management_System
{
    static class Program
    {
        public static clsBE gBE = new clsBE();
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]

		#region "Mod Main:"
		static void Main()
			//=================
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
#endregion
	}
}
