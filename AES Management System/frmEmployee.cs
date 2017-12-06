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
    public partial class frmEmployee : Form
    {
        public clsBA mBA = new clsBA();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string pUserName = mBA.SelectUserName(Program.gBE);
            lblWelcome.Text = "Login As: " + pUserName + "";
            lblInfo.Text="Welcome "+ pUserName + "";
            try
            {
                if (mBA.IsLoggedIn(Program.gBE) > 0)
                {
                    cmdTimeOut.Enabled = true;
                    cmdTimeIn.Enabled = false;
                }
                else
                {
                    cmdTimeOut.Enabled = false;
                    cmdTimeIn.Enabled = true;
                }
            }
            catch
            {

            }
            
        }

        private void cmdTimeIn_Click(object sender, EventArgs e)
        {
            int pUserId = Convert.ToInt32(mBA.GetUserId(Program.gBE));
            MessageBox.Show("'+pUserId+'");
        }
    }
}
