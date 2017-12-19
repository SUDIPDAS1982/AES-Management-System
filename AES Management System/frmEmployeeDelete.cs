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
	public partial class frmEmployeeDelete : Form
		//===========================================
	{
		public clsBA mBA = new clsBA();

		#region "Constructor:"
		public frmEmployeeDelete()
		//========================
		{
			InitializeComponent();
		}
		#endregion

		#region "Link Label:"
		private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		//===============================================================================
		{
			Application.Exit();
		}

		private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		//=================================================================================
		{
			this.Hide();
			frmAdmin pFrmAdmin = new frmAdmin();
			pFrmAdmin.ShowDialog();
		}
		#endregion

		#region "Load:"
		private void frmEmployeeDelete_Load(object sender, EventArgs e)
		//==============================================================
		{
			Dictionary<string, string> pUserIdName = new Dictionary<string, string>();
			pUserIdName = mBA.GetUserIdName();
			for (int i = 0; i < pUserIdName.Count; i++)
			{
				cmbUserName.DataSource = new BindingSource(pUserIdName, null);
				cmbUserName.ValueMember = "key";
				cmbUserName.DisplayMember = "value";
				if (i == 0)
				{
					txtUserId.Text = cmbUserName.SelectedValue.ToString();
				}
			}
			if (txtUserId.Text != "")
			{
				cmdDelete.Enabled = true;
			}
		}
		#endregion

		#region "Combo Box:"
		private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
		//======================================================================
		{
			txtUserId.Text = cmbUserName.SelectedValue.ToString();
		}
		#endregion

		#region "Command Button:"
		private void cmdDelete_Click(object sender, EventArgs e)
			//=======================================================
		{
			int pUserId = Convert.ToInt32(txtUserId.Text);
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show("Are you sure you want to delete?", "User Deletion", buttons, MessageBoxIcon.Warning);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				Program.gBE.UserId = pUserId;
				if (mBA.DeleteUser(Program.gBE) > 0)
				{
					MessageBox.Show("User Deleted Successufully.");
					this.Hide();
					frmEmployeeDelete pFrmEmployeeDelete = new frmEmployeeDelete();
					pFrmEmployeeDelete.ShowDialog();
				}
			}
		}
#endregion
	}
}
