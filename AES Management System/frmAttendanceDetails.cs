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
	public partial class frmAttendanceDetails : Form
	{
		public clsBA mBA = new clsBA();
		public frmAttendanceDetails(DateTime pLoginDate_In)
		{
			InitializeComponent();
			grdAttendanceDetails.Rows.Clear();
			grdAttendanceDetails.Visible = true;
			List<List<string>> pSingleUserAttendanceDetails = new List<List<string>>();
			pSingleUserAttendanceDetails = mBA.GetSingleUserAttendanceDetails(Program.gBE, pLoginDate_In);
			for (int i = 0; i < pSingleUserAttendanceDetails.Count; i++)
			{
				grdAttendanceDetails.Rows.Add();
				for (int j = 0; j < pSingleUserAttendanceDetails[i].Count; j++)
				{
					grdAttendanceDetails.Rows[i].Cells[j].Value = pSingleUserAttendanceDetails[i][j].ToString();
				}
				grdAttendanceDetails.AllowUserToAddRows = false;
			}
		}

		private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
		}

			private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Exit();
		}
	}
}
