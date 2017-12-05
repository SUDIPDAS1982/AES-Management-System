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
    public partial class frmLogin : Form
    {
        public BA mBA = new BA();
        //public BE pBE = new BE();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Program.gBE.UserName = txtUserName.Text;
            Program.gBE.Password = txtPassword.Text;
            if(mBA.UserLogin(Program.gBE) >0)
            {
                if(mBA.IsAdmin(Program.gBE) =="ADMIN")
                {
                    MessageBox.Show("Login success.");
                    this.Hide();
                    frmAdmin pFrmAdmin = new frmAdmin();
                    pFrmAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login success.");
                    this.Hide();
                    frmEmployee pFrmEmployee = new frmEmployee();
                    pFrmEmployee.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
