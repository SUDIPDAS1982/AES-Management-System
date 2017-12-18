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
	{
		public clsBA mBA = new clsBA();
		public frmEmployeeEdit()
		{
			InitializeComponent();
		}

		private void frmEmployeeEdit_Load(object sender, EventArgs e)
		{
			List<List<string>> pSingleUserPersonalDetails = new List<List<string>>();
			pSingleUserPersonalDetails = mBA.GetSingleUserPersonalDetails(Program.gBE);
			txtId.Text = pSingleUserPersonalDetails[0][0].ToString();
			txtFullName.Text= pSingleUserPersonalDetails[0][1].ToString();
			txtAddress.Text= pSingleUserPersonalDetails[0][2].ToString();
			txtPincode.Text= pSingleUserPersonalDetails[0][3].ToString();
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
			txtDateOfBirth.Text= pSingleUserPersonalDetails[0][5].ToString();
			txtContactNumber.Text= pSingleUserPersonalDetails[0][6].ToString();
			txtEmailId.Text= pSingleUserPersonalDetails[0][7].ToString();
			cmbQualification.Text= pSingleUserPersonalDetails[0][8].ToString();
		}

		private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Exit();
		}

		private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
		{
			txtDateOfBirth.Text = dtpDateOfBirth.Value.ToString();
		}

		private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (txtAddress.Text == "" || txtPincode.Text=="" || txtDateOfBirth.Text=="" ||txtContactNumber.Text=="" || txtEmailId.Text=="")
			{
				MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtAddress.Focus();
				return;
			}
			if (!Regex.Match(txtPincode.Text, @"^\d{6}$").Success)
			{
				MessageBox.Show("Invalid zip code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPincode.Focus();
				return;
			}
			if (!Regex.Match(txtContactNumber.Text, @"^\d{10}$").Success)
			{
				MessageBox.Show("Invalid Phone Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContactNumber.Focus();
				return;
			}
			if (!Regex.Match(txtEmailId.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
			{
				MessageBox.Show("Invalid Email Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtEmailId.Focus();
				return;
			}
		}

		private void cmbQualification_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
