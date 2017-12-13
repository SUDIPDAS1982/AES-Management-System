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
    public partial class frmEmployee : Form
    {
        public clsBA mBA = new clsBA();

		#region "Constructor:"
		public frmEmployee()
			//================
        {
            InitializeComponent();
        }
#endregion

		#region "Load:"

		private void frmEmployee_Load(object sender, EventArgs e)
			//======================================================
        {
            string pUserName = mBA.SelectUserName(Program.gBE);
            lblWelcome.Text = "Login As: " + pUserName + "";
            lblInfo.Text="Welcome "+ pUserName + "";
            try
            {
                if (mBA.IsUserLoggedIn(Program.gBE) > 0)
                {
                    if(mBA.IsUserLoggedOut(Program.gBE) > 0)
                    {
                        cmdTimeOut.Enabled = false;
                        cmdTimeIn.Enabled = true;
                    }
                    else
                    {
                        cmdTimeOut.Enabled = true;
                        cmdTimeIn.Enabled = false;
                    }                    
                }
                else
                {
                    cmdTimeOut.Enabled = false;
                    cmdTimeIn.Enabled = true;
                }
            }
            catch
            {

            }
            
        }
		#endregion

		#region "Command Button:"
		private void cmdTimeIn_Click(object sender, EventArgs e)
			//=====================================================
        {
            Program.gBE.UserId = Convert.ToInt32(mBA.GetUserId(Program.gBE));
			string pRemarks = txtRemarks.Text;
            DateTime pTime = new DateTime();
            if (mBA.IsUserLoggedIn(Program.gBE) > 0)
            {
                if (mBA.IsUserLoggedOut(Program.gBE) > 0)
                {
                    if (mBA.TimeInReInsert(Program.gBE, pRemarks, ref pTime) > 0)
                    {
                        lblInfo.Text = "Your registered Re-entry time is: " + pTime + "";
                        MessageBox.Show("Time In Done. ");
                        cmdTimeOut.Enabled = true;
                        cmdTimeIn.Enabled = false;
						txtRemarks.Text = "";
                    }
                }
            }
            else
            {
                if (mBA.TimeInInsert(Program.gBE, pRemarks, ref pTime) > 0)
                {
                    lblInfo.Text = "Your registered entry time is: " + pTime + "";
                    MessageBox.Show("Time In Done. ");
                    cmdTimeOut.Enabled = true;
                    cmdTimeIn.Enabled = false;
					txtRemarks.Text = "";
				}
            }                  
        }

        private void cmdTimeOut_Click(object sender, EventArgs e)
			//======================================================
        {
			string pRemarks = txtRemarks.Text;
			DateTime pTime = new DateTime();
            if (mBA.IsUserLoggedIn(Program.gBE) > 0)
            {
                if (mBA.IsUserLoggedOut(Program.gBE) == 0)
                {
                    if (mBA.TimeOutInsert(Program.gBE, pRemarks, ref pTime) > 0)
                    {
                        lblInfo.Text = "Your registered exit time is: " + pTime + "";
                        MessageBox.Show("Time Out Done. ");
                        cmdTimeOut.Enabled = false;
                        cmdTimeIn.Enabled = true;
						txtRemarks.Text = "";
					}
                }
            }            
        }

        private void cmdExit_Click(object sender, EventArgs e)
			//===================================================
        {
            Application.Exit();
        }
        private void CmdAttendanceSummary_Click(object sender, EventArgs e)
			//=================================================================
        {
            this.Hide();
            frmAttendanceSummary pFrmAttendanceDetails = new frmAttendanceSummary();
            pFrmAttendanceDetails.ShowDialog();
        }
		#endregion

		#region "Link Label:"
		private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Exit();
		}
#endregion
	}
}
