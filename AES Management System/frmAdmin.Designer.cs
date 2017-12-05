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
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.leaveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.editEmployeeToolStripMenuItem,
            this.employeeDetailsToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editEmployeeToolStripMenuItem.Text = "Edit Employee";
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaveSummaryToolStripMenuItem,
            this.leaveHistoryToolStripMenuItem});
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.leaveToolStripMenuItem.Text = "Leave";
            // 
            // leaveSummaryToolStripMenuItem
            // 
            this.leaveSummaryToolStripMenuItem.Name = "leaveSummaryToolStripMenuItem";
            this.leaveSummaryToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.leaveSummaryToolStripMenuItem.Text = "Leave Summary";
            // 
            // leaveHistoryToolStripMenuItem
            // 
            this.leaveHistoryToolStripMenuItem.Name = "leaveHistoryToolStripMenuItem";
            this.leaveHistoryToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.leaveHistoryToolStripMenuItem.Text = "Leave History";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
    }
}