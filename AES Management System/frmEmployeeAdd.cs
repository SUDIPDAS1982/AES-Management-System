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
	public partial class frmEmployeeAdd : Form
		//==========================================
	{
		public clsBA mBA = new clsBA();

		#region "Constructor:"
		public frmEmployeeAdd()
			//======================
		{
			InitializeComponent();
		}
		#endregion

		#region "Link Label:"

		private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
			//==================================================================================
		{
			this.Hide();
			frmAdmin pFrmAdmin = new frmAdmin();
			pFrmAdmin.ShowDialog();
		}

		private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
			//=====================================================================================
		{
			Application.Restart();
		}
		#endregion

		#region "Date Time Picker:"
		private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
		{
			txtDateOfBirth.Text = dtpDateOfBirth.Value.ToString();
			txtAge.Text = (Convert.ToDateTime(DateTime.Now.ToShortDateString()).Year - Convert.ToDateTime(dtpDateOfBirth.Text).Year).ToString();
		}
		#endregion

		#region "Command Button:"
		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (cmbUserRole.Text=="" || txtFullName.Text=="" || txtAddress.Text == "" || txtPincode.Text == "" || txtDateOfBirth.Text == "" || txtContactNumber.Text == "" || txtEmailId.Text == "" || cmbQualification.Text=="")
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
			if (Convert.ToDateTime(dtpDateOfBirth.Text).Year > pDate.Year - 18)
			{
				MessageBox.Show("User Age should be Minimum 18 Years. Please input Proper Date of Birth.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dtpDateOfBirth.Focus();
				return;
			}
			if (optMale.Checked == false && optFemale.Checked == false && optOther.Checked == false)
			{
				MessageBox.Show("Please select User Gender.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			Program.gBE.UserRole = cmbUserRole.SelectedItem.ToString();
			Program.gBE.UserFullName = txtFullName.Text.ToString();
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
			int pUserId = mBA.AddUserPersonalDetails(Program.gBE);
			if (pUserId > 0)
			{
				MessageBox.Show("User Personal Details Added Successufully. New User Id Is: " + pUserId, "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Hide();
				frmEmployeeAdd pFrmEmployeeAdd = new frmEmployeeAdd();
				pFrmEmployeeAdd.ShowDialog();
			}
		}
#endregion

		#region "Form Load:"
		private void frmEmployeeAdd_Load(object sender, EventArgs e)
		{
			
		}
#endregion
	}
}
