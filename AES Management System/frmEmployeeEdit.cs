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
			txtQualification.Text= pSingleUserPersonalDetails[0][8].ToString();
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
	}
}
