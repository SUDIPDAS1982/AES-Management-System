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
    public partial class frmEmployeeDetails : Form
		//============================================
    {
        public clsBA mBA = new clsBA();

		#region "Constructor:"
		public frmEmployeeDetails()
			//=========================
        {
            InitializeComponent();
        }
		#endregion

		#region "Load:"
		private void frmEmployeeDetails_Load(object sender, EventArgs e)
		//================================================================
		{
			Dictionary<string, string> pUserIdName = new Dictionary<string, string>();
			pUserIdName = mBA.GetUserIdName();
			for (int i = 0; i < pUserIdName.Count; i++)
			{
				cmbUser.DataSource = new BindingSource(pUserIdName, null);
				cmbUser.ValueMember = "key";
				cmbUser.DisplayMember = "value";
			}
		}
		#endregion

		#region "Radio Button:"
		private void optAll_CheckedChanged(object sender, EventArgs e)
			//=============================================================
        {
            cmbUser.Visible = false;
        }

        private void optIndividualEmployee_CheckedChanged(object sender, EventArgs e)
			//===============================================================================
        {
            cmbUser.Visible = true;
        }
		#endregion

		#region "Command Button:"
		private void cmdDisplay_Click(object sender, EventArgs e)
			//========================================================
        {
			grdEmployeeDetailDisplay.Columns[9].Visible = false;
			grdEmployeeDetailDisplay.Columns[10].Visible = false;
			grdEmployeeDetailDisplay.Rows.Clear();
            grdEmployeeDetailDisplay.Visible = true;
            Program.gBE.UserId = Convert.ToInt32(cmbUser.SelectedValue);
            List<List<string>> pAllUserPersonalDetails = new List<List<string>>();
            if (optAll.Checked)
            {
                pAllUserPersonalDetails = mBA.GetAllUserPersonalDetails();
                for (int i = 0; i < pAllUserPersonalDetails.Count; i++)
                {
					grdEmployeeDetailDisplay.Columns[9].Visible = true;
					grdEmployeeDetailDisplay.Columns[10].Visible = true;
					grdEmployeeDetailDisplay.Rows.Add();
                    for (int j = 0; j < pAllUserPersonalDetails[i].Count; j++)
                    {
                        grdEmployeeDetailDisplay.Rows[i].Cells[j].Value = pAllUserPersonalDetails[i][j].ToString();
                    }
                    grdEmployeeDetailDisplay.AllowUserToAddRows = false;
                }
            }
            else
            {
                pAllUserPersonalDetails = mBA.GetSingleUserPersonalDetails(Program.gBE);
                for (int i = 0; i < pAllUserPersonalDetails.Count; i++)
                {
					grdEmployeeDetailDisplay.Columns[9].Visible = true;
					grdEmployeeDetailDisplay.Columns[10].Visible = true;
					grdEmployeeDetailDisplay.Rows.Add();
                    for (int j = 0; j < pAllUserPersonalDetails[i].Count; j++)
                    {
                        grdEmployeeDetailDisplay.Rows[i].Cells[j].Value = pAllUserPersonalDetails[i][j].ToString();
                    }
                    grdEmployeeDetailDisplay.AllowUserToAddRows = false;
                }
            }
        }
		#endregion

		#region "Link Label:"
		private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
			//=================================================================================
        {
			Application.Restart();
		}

        private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
			//=================================================================================
        {
            this.Hide();
            frmAdmin pFrmAdmin = new frmAdmin();
            pFrmAdmin.ShowDialog();
        }
		#endregion

		#region "Data Grid View:"
		private void grdEmployeeDetailDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
			//=================================================================================================
		{
			if (e.ColumnIndex == 9)
			{
				int pUserId = Convert.ToInt32(grdEmployeeDetailDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex - 9].Value.ToString());
				Program.gBE.UserId = pUserId;
				string pFormName="Employee Details";
				frmEmployeeEdit pFrmEmployeeEdit = new frmEmployeeEdit(pFormName);
				pFrmEmployeeEdit.ShowDialog();
			}
			if (e.ColumnIndex == 10)
			{
				int pUserId = Convert.ToInt32(grdEmployeeDetailDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex - 10].Value.ToString());
				Program.gBE.UserId = pUserId;
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				if (mBA.IsDeleteAdmin(Program.gBE) == "ADMIN")
				{
					DialogResult result = MessageBox.Show("Are you sure you want to delete? Admin deletion will forcefully sign out the application. You have to re-login again.", "Admin Deletion", buttons, MessageBoxIcon.Warning);
					if (result == System.Windows.Forms.DialogResult.Yes)
					{
						if (mBA.DeleteUser(Program.gBE) > 0)
						{
							MessageBox.Show("Admin Deleted Successufully.");
							Application.Restart();
						}
					}
				}
				else
				{
					DialogResult result = MessageBox.Show("Are you sure you want to delete?", "User Deletion", buttons, MessageBoxIcon.Warning);
					if (result == System.Windows.Forms.DialogResult.Yes)
					{
						if (mBA.DeleteUser(Program.gBE) > 0)
						{
							MessageBox.Show("User Deleted Successufully.");
							this.Hide();
							frmEmployeeDetails pFrmEmployeeDetails = new frmEmployeeDetails();
							pFrmEmployeeDetails.ShowDialog();
						}
					}
				}			
			}
		}
#endregion
	}
}
