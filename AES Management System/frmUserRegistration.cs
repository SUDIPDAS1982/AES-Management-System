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
	public partial class frmUserRegistration : Form
		//=============================================
	{
		public clsBA mBA = new clsBA();

		#region "Constructor:"
		public frmUserRegistration()
			//===========================
		{
			InitializeComponent();
		}
		#endregion

		#region "Load:"
		private void frmUserRegistration_Load(object sender, EventArgs e)
			//=================================================================
		{
			Dictionary<string, string> pNewUserIdName = new Dictionary<string, string>();
			pNewUserIdName = mBA.GetNewUserIdName();
			for (int i = 0; i < pNewUserIdName.Count; i++)
			{
				cmbUserId.DataSource = new BindingSource(pNewUserIdName, null);

				cmbUserId.ValueMember = "key";
				cmbUserId.DisplayMember = "value";
				if (i == 0)
				{
					var first = pNewUserIdName.First();
					txtUserId.Text = first.Key;
				}
			}
		}
		#endregion

		#region "Link Label:"
		private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			frmLogin pFrmLogin = new frmLogin();
			pFrmLogin.ShowDialog();
		}
		private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Restart();
		}
		#endregion

		#region "Combo Box:"
		private void cmbUserId_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtUserId.Text = cmbUserId.SelectedValue.ToString();
		}
		#endregion

		#region "Text Box:"
		private void txtUserName_Leave(object sender, EventArgs e)
		{
			if (txtUserName.Text != "")
			{
				Program.gBE.UserName = txtUserName.Text;
				if (mBA.IsDuplicateUserName(Program.gBE) > 0)
				{
					MessageBox.Show("User Name is taken. Please try another.", "Dulicate User Name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					txtUserName.Text = "";
					txtUserName.Focus();
				}
			}
		}
		private void txtCreatePassword_Leave(object sender, EventArgs e)
		{
			if (txtCreatePassword.Text.Length < 8)
			{
				MessageBox.Show("Password should be at least 8 character.", "User Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtCreatePassword.Text = "";
				txtCreatePassword.Focus();
			}
		}
		private void txtConfirmPassword_Leave(object sender, EventArgs e)
		{
			if(!txtCreatePassword.Text.Equals(txtConfirmPassword.Text))
			{
				MessageBox.Show("These Passwords don't match. Please try again.", "User Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtConfirmPassword.Text = "";
				txtConfirmPassword.Focus();
			}
		}
		#endregion

		private void cmdRegister_Click(object sender, EventArgs e)
		{
			Program.gBE.UserId = Convert.ToInt32(txtUserId.Text);
			Program.gBE.Password = txtCreatePassword.Text;
			if (txtUserName.Text == "" || txtCreatePassword.Text == "" || txtConfirmPassword.Text == "")
			{
				MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUserName.Focus();
				return;
			}
			if (mBA.SetUserNamePassword(Program.gBE) > 0)
			{
				MessageBox.Show("Registration has been completed Successufully.", "Registration",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Hide();
				frmLogin pFrmLogin = new frmLogin();
				pFrmLogin.ShowDialog();
			}
		}
	}
}
