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
    //
    public partial class frmLogin : Form
		//===================================
    {
        public clsBA mBA = new clsBA();
		//public BE pBE = new BE();

		#region "Constructor:"
		public frmLogin()
			//================
        {
            InitializeComponent();
        }
		#endregion

		#region "Command Button:"
		private void cmdLogin_Click(object sender, EventArgs e)
			//======================================================
        {
            Program.gBE.UserName = txtUserName.Text;
            Program.gBE.Password = txtPassword.Text;
			int pUserId = mBA.UserLogin(Program.gBE);
			if (pUserId >0)
            {
				Program.gBE.UserId = pUserId;
                if(Convert.ToBoolean(mBA.IsUserActive(Program.gBE))==true)
                {
                    if (mBA.IsAdmin(Program.gBE) == "ADMIN")
                    {
                        MessageBox.Show("Login success.");
                        this.Hide();
                        frmAdmin pFrmAdmin = new frmAdmin();
                        pFrmAdmin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login success.");
                        this.Hide();
                        frmEmployee pFrmEmployee = new frmEmployee();
                        pFrmEmployee.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("User has been Deactivated!!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Login!! Please check username and password");
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
			//=====================================================
        {
            Application.Exit();
        }
		#endregion

		#region "Link Label:"
		private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			frmUserRegistration pFrmUserRegistration = new frmUserRegistration();
			pFrmUserRegistration.ShowDialog();
		}
#endregion
	}
}
