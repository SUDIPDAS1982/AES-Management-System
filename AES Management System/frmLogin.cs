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
        public BA ba = new BA();
        public BE be = new BE();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            be.UserName = txtUserName.Text;
            be.Password = txtPassword.Text;
            if(ba.UserLogin(be)>0)
            {
                if(ba.IsAdmin(be)=="ADMIN")
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
