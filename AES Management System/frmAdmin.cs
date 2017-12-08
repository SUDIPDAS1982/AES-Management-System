using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BELayer;
using BALayer;

namespace AES_Management_System
{
    public partial class frmAdmin : Form
		//===================================
    {
        public clsBA mBA = new clsBA();
		//public BE mBE = new BE();

		#region "Constructor:"
		public frmAdmin()
			//==============
        {
            InitializeComponent();
        }
		#endregion

		#region "Menu:"
		private void frmAdmin_Load(object sender, EventArgs e)
			//=====================================================
        {
            string pUserName= mBA.SelectUserName(Program.gBE);
            lblWelcome.Text= "Welcome " + pUserName + "";
        }

        private void mnuEmployeeDetails_Click(object sender, EventArgs e)
			//===============================================================
        {
            this.Hide();
            frmEmployeeDetails pFrmEmployeeDetails = new frmEmployeeDetails();
            pFrmEmployeeDetails.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
			//====================================================
        {
            Application.Exit();
        }
#endregion
	}
}
