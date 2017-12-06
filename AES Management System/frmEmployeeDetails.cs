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
    {
        public clsBA mBA = new clsBA();

        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void optAll_CheckedChanged(object sender, EventArgs e)
        {
            cmbUser.Visible = false;
        }

        private void optIndividualEmployee_CheckedChanged(object sender, EventArgs e)
        {
            cmbUser.Visible = true;
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> pUserIdName = new Dictionary<string, string>();
            pUserIdName = mBA.GetUserIdName();
            for (int i=0; i< pUserIdName.Count; i++)
            {
                cmbUser.DataSource = new BindingSource(pUserIdName, null);
                cmbUser.ValueMember = "key";
                cmbUser.DisplayMember = "value";
            }            
        }

        private void cmdDisplay_Click(object sender, EventArgs e)
        {
            grdEmployeeDetailDisplay.Rows.Clear();
            grdEmployeeDetailDisplay.Visible = true;
            Program.gBE.UserId = Convert.ToInt32(cmbUser.SelectedValue);
            List<List<string>> pAllUserDetails = new List<List<string>>();
            if (optAll.Checked)
            {
                pAllUserDetails = mBA.GetAllUserDetails();
                for (int i = 0; i < pAllUserDetails.Count; i++)
                {
                    grdEmployeeDetailDisplay.Rows.Add();
                    for (int j = 0; j < pAllUserDetails[i].Count; j++)
                    {
                        grdEmployeeDetailDisplay.Rows[i].Cells[j].Value = pAllUserDetails[i][j].ToString();
                    }
                    grdEmployeeDetailDisplay.AllowUserToAddRows = false;
                }
            }
            else
            {
                pAllUserDetails = mBA.GetSingleUserDetails(Program.gBE);
                for (int i = 0; i < pAllUserDetails.Count; i++)
                {
                    grdEmployeeDetailDisplay.Rows.Add();
                    for (int j = 0; j < pAllUserDetails[i].Count; j++)
                    {
                        grdEmployeeDetailDisplay.Rows[i].Cells[j].Value = pAllUserDetails[i][j].ToString();
                    }
                    grdEmployeeDetailDisplay.AllowUserToAddRows = false;
                }
            }
        }

        private void lnklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAdmin pFrmAdmin = new frmAdmin();
            pFrmAdmin.ShowDialog();
        }
    }
}
