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
    public partial class frmAdmin : Form
    {
        public BA mBA = new BA();
        //public BE mBE = new BE();
        public frmAdmin()
        {
            InitializeComponent();
        }
        

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            string pUserName= mBA.SelectUserName(Program.gBE);
            lblWelcome.Text= "Welcome " + pUserName + "";
        }
    }
}
