namespace AES_Management_System
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditEmployee = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEmployeeDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAttendance = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLeave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLeaveSummary = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLeaveHistory = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfile,
            this.mnuAttendance,
            this.mnuLeave,
            this.mnuExit});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuProfile
			// 
			this.mnuProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddEmployee,
            this.mnuEditEmployee,
            this.mnuEmployeeDetails,
            this.mnuDeleteEmployee});
			this.mnuProfile.Name = "mnuProfile";
			this.mnuProfile.Size = new System.Drawing.Size(53, 20);
			this.mnuProfile.Text = "Profile";
			// 
			// mnuAddEmployee
			// 
			this.mnuAddEmployee.Name = "mnuAddEmployee";
			this.mnuAddEmployee.Size = new System.Drawing.Size(164, 22);
			this.mnuAddEmployee.Text = "Add Employee";
			// 
			// mnuEditEmployee
			// 
			this.mnuEditEmployee.Name = "mnuEditEmployee";
			this.mnuEditEmployee.Size = new System.Drawing.Size(164, 22);
			this.mnuEditEmployee.Text = "Edit Employee";
			// 
			// mnuEmployeeDetails
			// 
			this.mnuEmployeeDetails.Name = "mnuEmployeeDetails";
			this.mnuEmployeeDetails.Size = new System.Drawing.Size(164, 22);
			this.mnuEmployeeDetails.Text = "Employee Details";
			this.mnuEmployeeDetails.Click += new System.EventHandler(this.mnuEmployeeDetails_Click);
			// 
			// mnuDeleteEmployee
			// 
			this.mnuDeleteEmployee.Name = "mnuDeleteEmployee";
			this.mnuDeleteEmployee.Size = new System.Drawing.Size(164, 22);
			this.mnuDeleteEmployee.Text = "Delete Employee";
			// 
			// mnuAttendance
			// 
			this.mnuAttendance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCheck});
			this.mnuAttendance.Name = "mnuAttendance";
			this.mnuAttendance.Size = new System.Drawing.Size(80, 20);
			this.mnuAttendance.Text = "Attendance";
			// 
			// mnuCheck
			// 
			this.mnuCheck.Name = "mnuCheck";
			this.mnuCheck.Size = new System.Drawing.Size(107, 22);
			this.mnuCheck.Text = "Check";
			// 
			// mnuLeave
			// 
			this.mnuLeave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLeaveSummary,
            this.mnuLeaveHistory});
			this.mnuLeave.Name = "mnuLeave";
			this.mnuLeave.Size = new System.Drawing.Size(49, 20);
			this.mnuLeave.Text = "Leave";
			// 
			// mnuLeaveSummary
			// 
			this.mnuLeaveSummary.Name = "mnuLeaveSummary";
			this.mnuLeaveSummary.Size = new System.Drawing.Size(158, 22);
			this.mnuLeaveSummary.Text = "Leave Summary";
			// 
			// mnuLeaveHistory
			// 
			this.mnuLeaveHistory.Name = "mnuLeaveHistory";
			this.mnuLeaveHistory.Size = new System.Drawing.Size(158, 22);
			this.mnuLeaveHistory.Text = "Leave History";
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(37, 20);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Location = new System.Drawing.Point(92, 51);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(35, 13);
			this.lblWelcome.TabIndex = 1;
			this.lblWelcome.Text = "label1";
			// 
			// frmAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Panel";
			this.Load += new System.EventHandler(this.frmAdmin_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuEditEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployeeDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuCheck;
        private System.Windows.Forms.ToolStripMenuItem mnuLeave;
        private System.Windows.Forms.ToolStripMenuItem mnuLeaveSummary;
        private System.Windows.Forms.ToolStripMenuItem mnuLeaveHistory;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblWelcome;
    }
}