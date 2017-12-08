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

		#region "Constructor:"
		public frmAttendanceSummary()
			//============================
        {
            InitializeComponent();
        }
		#endregion

		#region "Command Button:"
		private void cmdExit_Click(object sender, EventArgs e)
			//===================================================
        {
            Application.Exit();
        }

        private void cmdShow_Click(object sender, EventArgs e)
			//====================================================
        {
            grdAttendanceSummary.Rows.Clear();
            grdAttendanceSummary.Visible = true;
            DateTime pFromDate = Convert.ToDateTime(dtpFromDate.Text);
            DateTime pToDate = Convert.ToDateTime(dtpToDate.Text);
            List<List<string>> pSingleUserAttendanceSummary = new List<List<string>>();
            pSingleUserAttendanceSummary = mBA.GetSingleUserAttendanceSummary(Program.gBE, pFromDate, pToDate);
            for (int i = 0; i < pSingleUserAttendanceSummary.Count; i++)
            {
                grdAttendanceSummary.Rows.Add();
                for (int j = 0; j < pSingleUserAttendanceSummary[i].Count; j++)
                {
                    grdAttendanceSummary.Rows[i].Cells[j].Value = pSingleUserAttendanceSummary[i][j].ToString();
                }
                grdAttendanceSummary.AllowUserToAddRows = false;
            }
        }
		#endregion

		#region "Grid Cell Command Button:"
		private void grdAttendanceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
			//==============================================================================================
        {
            if (e.ColumnIndex == 5)
            {
				//int pUserId=Convert.ToInt32(grdAttendanceSummary.Rows[e.RowIndex].Cells[e.ColumnIndex-5].Value.ToString());
				DateTime pLoginDate = Convert.ToDateTime(grdAttendanceSummary.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value.ToString());
				frmAttendanceDetails pFrmAttendanceHistory = new frmAttendanceDetails(pLoginDate);
				pFrmAttendanceHistory.ShowDialog();
			}
        }
#endregion
	}
}
