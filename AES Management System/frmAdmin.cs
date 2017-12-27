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
		string mFormName = "Admin";
		//public BE mBE = new BE();

		#region "Constructor:"
		public frmAdmin()
			//==============
        {
            InitializeComponent();
        }
		#endregion

		#region "Load:"
		private void frmAdmin_Load(object sender, EventArgs e)
			//=====================================================
        {
			string pUserName = mBA.SelectUserName(Program.gBE);
			lblWelcome.Text = "Login As: " + pUserName + "";
		}
#endregion

		#region "Menu:"
		private void mnuEmployeeDetails_Click(object sender, EventArgs e)
			//===============================================================
        {
            this.Hide();
            frmEmployeeDetails pFrmEmployeeDetails = new frmEmployeeDetails(mFormName);
            pFrmEmployeeDetails.ShowDialog();
        }
        private void mnuExit_Click(object sender, EventArgs e)
			//====================================================
        {
			Application.Restart();
		}	
		private void mnuDeleteEmployee_Click(object sender, EventArgs e)
			//==============================================================
		{
			this.Hide();
			frmEmployeeDelete pFrmEmployeeDelete = new frmEmployeeDelete();
			pFrmEmployeeDelete.ShowDialog();
		}
		private void mnuAddEmployee_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmEmployeeAdd pFrmEmployeeAdd = new frmEmployeeAdd();
			pFrmEmployeeAdd.ShowDialog();
		}
		private void mnuEditEmployee_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmEmployeeEdit pFrmEmployeeEdit = new frmEmployeeEdit(mFormName);
			pFrmEmployeeEdit.ShowDialog();
		}
		private void mnuAttendanceCheck_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmAttendanceSummary pFrmAttendanceSummary = new frmAttendanceSummary(mFormName);
			pFrmAttendanceSummary.ShowDialog();
		}
		private void mnuLeaveGenerate_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmLeaveGenerate pFrmLeaveGenerate = new frmLeaveGenerate();
			pFrmLeaveGenerate.ShowDialog();
		}
		#endregion
	}
}
