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
using System.Text.RegularExpressions;

namespace AES_Management_System
{
	public partial class frmEmployeeEdit : Form
		//=======================================
	{
		public clsBA mBA = new clsBA();
		string mFormName;

		#region "Constructor:"
		public frmEmployeeEdit(string pFormName_In)
			//======================================
		{
			mFormName = pFormName_In;
			InitializeComponent();
		}
		#endregion

		#region "Form Load:"
		private void frmEmployeeEdit_Load(object sender, EventArgs e)
			//=========================================================
		{
			if (mFormName == "Employee Details")
			{
				List<List<string>> pSingleUserPersonalDetails = new List<List<string>>();
				pSingleUserPersonalDetails = mBA.GetSingleUserPersonalDetails(Program.gBE);
				txtId.Text = pSingleUserPersonalDetails[0][0].ToString();
				txtFullName.Text = pSingleUserPersonalDetails[0][1].ToString();
				txtAddress.Text = pSingleUserPersonalDetails[0][2].ToString();
				txtPincode.Text = pSingleUserPersonalDetails[0][3].ToString();
				if (pSingleUserPersonalDetails[0][4].ToString().Trim() == "MALE")
				{
					optMale.Checked = true;
				}
				else if (pSingleUserPersonalDetails[0][4].ToString().Trim() == "FEMALE")
				{
					optFemale.Checked = true;
				}
				else
				{
					optOther.Checked = true;
				}
				txtDateOfBirth.Text = pSingleUserPersonalDetails[0][5].ToString();
				txtAge.Text = (Convert.ToDateTime(DateTime.Now.ToShortDateString()).Year - Convert.ToDateTime(txtDateOfBirth.Text).Year).ToString();
				txtContactNumber.Text = pSingleUserPersonalDetails[0][6].ToString();
				txtEmailId.Text = pSingleUserPersonalDetails[0][7].ToString();
				cmbQualification.Text = pSingleUserPersonalDetails[0][8].ToString();
			}
			else
			{
				cmbUserId.Visible = true;
				txtId.Visible = false;
				grpUserInformation.Visible = false;
				cmdSave.Visible = false;
				cmdShow.Visible = true;
				Dictionary<string, string> pUserIdName = new Dictionary<string, string>();
				pUserIdName = mBA.GetUserIdName();
				for (int i = 0; i < pUserIdName.Count; i++)
				{
					cmbUserId.DataSource = new BindingSource(pUserIdName, null);
					cmbUserId.ValueMember = "key";
					cmbUserId.DisplayMember = "key";
				}
			}
		}
		#endregion

		#region "Link Label:"
		private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
			//===============================================================================
		{
			Application.Restart();
		}

		private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		//================================================================================
		{
			this.Hide();
		}
		#endregion

		#region "Date Time Picker:"
		private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
			//=================================================================
		{
			txtDateOfBirth.Text = dtpDateOfBirth.Value.ToString();
			txtAge.Text = (Convert.ToDateTime(DateTime.Now.ToShortDateString()).Year - Convert.ToDateTime(dtpDateOfBirth.Text).Year).ToString();
		}
		#endregion

		#region "Command Button:"
		private void cmdSave_Click(object sender, EventArgs e)
			//===================================================
		{
			if (txtAddress.Text == "" || txtPincode.Text=="" || txtDateOfBirth.Text=="" ||txtContactNumber.Text=="" || txtEmailId.Text=="")
			{
				MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtAddress.Focus();
				return;
			}
			if (!Regex.Match(txtPincode.Text, @"^\d{6}$").Success)
			{
				MessageBox.Show("Please input 6 digit integer value as Pincode.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPincode.Focus();
				return;
			}
			DateTime pDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			if (Convert.ToDateTime(dtpDateOfBirth.Text).Year > pDate.Year-18)
			{
				MessageBox.Show("User Age should be Minimum 18 Years. Please input Proper Date of Birth.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dtpDateOfBirth.Focus();
				return;
			}
			if (!Regex.Match(txtContactNumber.Text, @"^\d{10}$").Success)
			{
				MessageBox.Show("Please input 6 digit integer value as Phone Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContactNumber.Focus();
				return;
			}
			if (!Regex.Match(txtEmailId.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
			{
				MessageBox.Show("Invalid Email Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtEmailId.Focus();
				return;
			}
			Program.gBE.UserId = Convert.ToInt32(txtId.Text.ToString());
			Program.gBE.UserAddress = txtAddress.Text.ToString();
			Program.gBE.UserPincode = Convert.ToInt32(txtPincode.Text.ToString());
			if (optMale.Checked == true)
			{
				Program.gBE.UserGender = optMale.Text.ToString();
			}
			else if (optFemale.Checked == true)
			{
				Program.gBE.UserGender = optFemale.Text.ToString();
			}
			else
			{
				Program.gBE.UserGender = optOther.Text.ToString();
			}
			Program.gBE.UserDOB = Convert.ToDateTime(txtDateOfBirth.Text.ToString());
			Program.gBE.UserContactNo = Convert.ToInt64(txtContactNumber.Text.ToString());
			Program.gBE.UserEmail = txtEmailId.Text.ToString();
			Program.gBE.UserQualification = cmbQualification.SelectedItem.ToString();
			if (mBA.EditUserPersonalDetails(Program.gBE) > 0)
			{
				MessageBox.Show("User Personal Details Updated Successufully.");
				this.Hide();
				frmEmployeeDetails pFrmEmployeeDetails = new frmEmployeeDetails();
				pFrmEmployeeDetails.ShowDialog();
			}
		}
		private void cmdShow_Click(object sender, EventArgs e)
			//====================================================
		{
			grpUserInformation.Visible = true;
			cmdSave.Visible = true;
			Program.gBE.UserId = Convert.ToInt32(cmbUserId.SelectedValue);
			List<List<string>> pSingleUserPersonalDetails = new List<List<string>>();
			pSingleUserPersonalDetails = mBA.GetSingleUserPersonalDetails(Program.gBE);
			txtFullName.Enabled = true;
			txtFullName.Text = pSingleUserPersonalDetails[0][1].ToString();
			txtAddress.Text = pSingleUserPersonalDetails[0][2].ToString();
			txtPincode.Text = pSingleUserPersonalDetails[0][3].ToString();
			if (pSingleUserPersonalDetails[0][4].ToString().Trim() == "MALE")
			{
				optMale.Checked = true;
			}
			else if (pSingleUserPersonalDetails[0][4].ToString().Trim() == "FEMALE")
			{
				optFemale.Checked = true;
			}
			else
			{
				optOther.Checked = true;
			}
			txtDateOfBirth.Text = pSingleUserPersonalDetails[0][5].ToString();
			txtAge.Text = (Convert.ToDateTime(DateTime.Now.ToShortDateString()).Year - Convert.ToDateTime(txtDateOfBirth.Text).Year).ToString();
			txtContactNumber.Text = pSingleUserPersonalDetails[0][6].ToString();
			txtEmailId.Text = pSingleUserPersonalDetails[0][7].ToString();
			cmbQualification.Text = pSingleUserPersonalDetails[0][8].ToString();
		}
		#endregion

		#region "Combo Box:"
		private void cmbUserId_SelectedIndexChanged(object sender, EventArgs e)
			//======================================================================
		{
			
		}
		#endregion
	}
}
