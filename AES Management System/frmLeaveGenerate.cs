using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;

namespace AES_Management_System
{
	public partial class frmLeaveGenerate : Form
		//=======================================
	{
		public clsBA mBA = new clsBA();
		#region "Constructor:"
		public frmLeaveGenerate()
			//======================
		{
			InitializeComponent();
		}
		#endregion

		#region "Load:"
		private void frmLeaveGenerate_Load(object sender, EventArgs e)
		{
			string pMaxLeaveGenerateYear = mBA.GetMaxLeaveGenerateYear();
			DateTime pDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			if (pMaxLeaveGenerateYear != "")
			{
				if (Convert.ToInt32(pMaxLeaveGenerateYear) >= pDate.Year)
				{
					cmdLeaveGenerate.Enabled = false;
					grpNewUserLeaveGenerate.Visible = true;
				}
			}
			Dictionary<string, string> pNewRegisteredUserIdName = new Dictionary<string, string>();
			pNewRegisteredUserIdName = mBA.GetNewRegisteredUserIdName();
			for (int i = 0; i < pNewRegisteredUserIdName.Count; i++)
			{
				cmbNewUserName.DataSource = new BindingSource(pNewRegisteredUserIdName, null);
				cmbNewUserName.ValueMember = "key";
				cmbNewUserName.DisplayMember = "value";
				if (i == 0)
				{
					var first = pNewRegisteredUserIdName.First();
					txtNewUserId.Text = first.Key;
				}
			}
		}
		#endregion

		#region "Command Button:"
		private void cmdLeaveGenerate_Click(object sender, EventArgs e)
		{
			if (mBA.LeaveGenerate() > 0)
			{
				MessageBox.Show("User Leave Record Generated successfully.", "Leave Generation", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cmdLeaveGenerate.Enabled = false;
				grpNewUserLeaveGenerate.Visible = true;
			}
		}
		#endregion

		#region "Link Label:"
		private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			frmAdmin pFrmAdmin = new frmAdmin();
			pFrmAdmin.ShowDialog();
		}

		private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Restart();
		}
		#endregion

		private void cmbNewUserName_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtNewUserId.Text =cmbNewUserName.SelectedValue.ToString();
		}
	}
}
