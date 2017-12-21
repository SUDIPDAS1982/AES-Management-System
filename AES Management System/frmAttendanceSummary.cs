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
    public partial class frmAttendanceSummary : Form
		//==============================================
    {
        public clsBA mBA = new clsBA();
		string mFormName;

		#region "Constructor:"
		public frmAttendanceSummary(string pFormName_In)
			//==========================================
        {
			mFormName = pFormName_In;
			InitializeComponent();
        }
		#endregion

		#region "Command Button:"

        private void cmdShow_Click(object sender, EventArgs e)
		//====================================================
		{
			if (mFormName == "Admin")
			{
				Program.gBE.UserId = Convert.ToInt32(cmbUserId.SelectedValue.ToString());
			}
			grdAttendanceSummary.Columns[5].Visible = false;
			grdAttendanceSummary.Rows.Clear();
            grdAttendanceSummary.Visible = true;
			lblColorDefinition.Visible = true;
			lblColorDefinition.Text = "Schedule time: Black, Grace Time: Dark Grey, Late: Orange, Half: Blue, Not Count: Red.";
			DateTime pScheduleLoginTime = Convert.ToDateTime("2017 - 12 - 07 10:00:59.000");
			DateTime pGraceLoginTime = Convert.ToDateTime("2017 - 12 - 07 10:15:59.000");
			DateTime pLateLoginTime = Convert.ToDateTime("2017 - 12 - 07 11:00:59.000");
			DateTime pHalfLoginTime = Convert.ToDateTime("2017 - 12 - 07 14:00:59.000");

			DateTime pScheduleLogoutTime = Convert.ToDateTime("2017 - 12 - 01 18:30:00.000");
			DateTime pHalfLogoutTime = Convert.ToDateTime("2017 - 12 - 01 14:30:00.000");

			DateTime pFromDate = Convert.ToDateTime(dtpFromDate.Text);
            DateTime pToDate = Convert.ToDateTime(dtpToDate.Text);
			if (pFromDate.Day > pToDate.Day)
			{
				MessageBox.Show("Please select correct date range.","Date Selection",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			else
			{
				List<List<string>> pSingleUserAttendanceSummary = new List<List<string>>();
				pSingleUserAttendanceSummary = mBA.GetSingleUserAttendanceSummary(Program.gBE, pFromDate, pToDate);
				if (pSingleUserAttendanceSummary.Count > 0)
				{
					grdAttendanceSummary.Columns[5].Visible = true;
				}
				for (int i = 0; i < pSingleUserAttendanceSummary.Count; i++)
				{
					grdAttendanceSummary.Rows.Add();
					for (int j = 0; j < pSingleUserAttendanceSummary[i].Count; j++)
					{
						if (j == 3)
						{
							if (pSingleUserAttendanceSummary[i][j] != "")
							{
								DateTime pLoginTime = Convert.ToDateTime(pSingleUserAttendanceSummary[i][j].ToString());
								if (pLoginTime.TimeOfDay > pHalfLoginTime.TimeOfDay)
								{
									grdAttendanceSummary.Rows[i].Cells[j].Style.ForeColor = Color.Red;
								}
								else if (pLoginTime.TimeOfDay > pLateLoginTime.TimeOfDay)
								{
									grdAttendanceSummary.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
								}
								else if (pLoginTime.TimeOfDay > pGraceLoginTime.TimeOfDay)
								{
									grdAttendanceSummary.Rows[i].Cells[j].Style.ForeColor = Color.Orange;
								}
								else if (pLoginTime.TimeOfDay > pScheduleLoginTime.TimeOfDay)
								{
									grdAttendanceSummary.Rows[i].Cells[j].Style.ForeColor = Color.DarkGray;
								}
								else
								{
									grdAttendanceSummary.Rows[i].Cells[j].Style.ForeColor = Color.Black;
								}
							}
						}
						if (j == 4)
						{
							if (pSingleUserAttendanceSummary[i][j] != "")
							{
								DateTime pLogoutTime = Convert.ToDateTime(pSingleUserAttendanceSummary[i][j].ToString());

								if (pLogoutTime.TimeOfDay < pHalfLogoutTime.TimeOfDay)
								{
									grdAttendanceSummary.Rows[i].Cells[j].Style.ForeColor = Color.Red;
								}
								else if (pLogoutTime.TimeOfDay < pScheduleLogoutTime.TimeOfDay)
								{
									grdAttendanceSummary.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
								}
								else
								{
									grdAttendanceSummary.Rows[i].Cells[j].Style.ForeColor = Color.Black;
								}
							}
						}
						grdAttendanceSummary.Rows[i].Cells[j].Value = pSingleUserAttendanceSummary[i][j].ToString();
					}
					grdAttendanceSummary.AllowUserToAddRows = false;
				}
			}
        }
		#endregion

		#region "Grid Cell Command Button:"
		private void grdAttendanceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
			//==============================================================================================
        {
            if (e.ColumnIndex == 5)
            {
				DateTime pLoginDate = Convert.ToDateTime(grdAttendanceSummary.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value.ToString());
				frmAttendanceDetails pFrmAttendanceDetails = new frmAttendanceDetails(pLoginDate);
				pFrmAttendanceDetails.ShowDialog();
			}
        }
		#endregion

		#region "Link Label:"
		private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			frmEmployee pFrmEmployee = new frmEmployee();
			pFrmEmployee.ShowDialog();
		}
		private void lnklblAdminBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

		private void frmAttendanceSummary_Load(object sender, EventArgs e)
		{
			if (mFormName == "Admin")
			{
				lnklblBack.Visible = false;
				lblUserId.Visible = true;
				cmbUserId.Visible = true;
				Dictionary<string, string> pUserIdName = new Dictionary<string, string>();
				pUserIdName = mBA.GetUserIdName();
				for (int i = 0; i < pUserIdName.Count; i++)
				{
					cmbUserId.DataSource = new BindingSource(pUserIdName, null);
					cmbUserId.ValueMember = "key";
					cmbUserId.DisplayMember = "value";
				}
			}
			else
			{
				lnklblAdminBack.Visible = false;
			}
		}

		
	}
}
