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
        public frmAttendanceDetails()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            grdAttendanceDetails.Rows.Clear();
            grdAttendanceDetails.Visible = true;
            DateTime pFromDate = Convert.ToDateTime(dtpFromDate.Text);
            DateTime pToDate = Convert.ToDateTime(dtpToDate.Text);
            List<List<string>> pSingleUserAttendanceDetails = new List<List<string>>();
            pSingleUserAttendanceDetails = mBA.GetSingleUserAttendanceDetails(Program.gBE, pFromDate, pToDate);
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

        private void grdAttendanceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("sudip");
            }
        }
    }
}
