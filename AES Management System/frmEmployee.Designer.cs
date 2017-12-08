﻿namespace AES_Management_System
{
    partial class frmEmployee
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
			this.lblWelcome = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.cmdTimeIn = new System.Windows.Forms.Button();
			this.cmdTimeOut = new System.Windows.Forms.Button();
			this.cmdAttendanceSummary = new System.Windows.Forms.Button();
			this.cmdExit = new System.Windows.Forms.Button();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.grpRemarks = new System.Windows.Forms.GroupBox();
			this.grpRemarks.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Location = new System.Drawing.Point(445, 30);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(35, 13);
			this.lblWelcome.TabIndex = 0;
			this.lblWelcome.Text = "label1";
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Location = new System.Drawing.Point(70, 30);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(35, 13);
			this.lblInfo.TabIndex = 1;
			this.lblInfo.Text = "label1";
			// 
			// cmdTimeIn
			// 
			this.cmdTimeIn.Location = new System.Drawing.Point(73, 85);
			this.cmdTimeIn.Name = "cmdTimeIn";
			this.cmdTimeIn.Size = new System.Drawing.Size(75, 23);
			this.cmdTimeIn.TabIndex = 2;
			this.cmdTimeIn.Text = "Time In";
			this.cmdTimeIn.UseVisualStyleBackColor = true;
			this.cmdTimeIn.Click += new System.EventHandler(this.cmdTimeIn_Click);
			// 
			// cmdTimeOut
			// 
			this.cmdTimeOut.Location = new System.Drawing.Point(73, 162);
			this.cmdTimeOut.Name = "cmdTimeOut";
			this.cmdTimeOut.Size = new System.Drawing.Size(75, 23);
			this.cmdTimeOut.TabIndex = 3;
			this.cmdTimeOut.Text = "Time Out";
			this.cmdTimeOut.UseVisualStyleBackColor = true;
			this.cmdTimeOut.Click += new System.EventHandler(this.cmdTimeOut_Click);
			// 
			// cmdAttendanceSummary
			// 
			this.cmdAttendanceSummary.Location = new System.Drawing.Point(73, 231);
			this.cmdAttendanceSummary.Name = "cmdAttendanceSummary";
			this.cmdAttendanceSummary.Size = new System.Drawing.Size(75, 41);
			this.cmdAttendanceSummary.TabIndex = 4;
			this.cmdAttendanceSummary.Text = "Attendance Summary";
			this.cmdAttendanceSummary.UseVisualStyleBackColor = true;
			this.cmdAttendanceSummary.Click += new System.EventHandler(this.CmdAttendanceSummary_Click);
			// 
			// cmdExit
			// 
			this.cmdExit.Location = new System.Drawing.Point(448, 85);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(75, 23);
			this.cmdExit.TabIndex = 5;
			this.cmdExit.Text = "Exit";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// txtRemarks
			// 
			this.txtRemarks.Location = new System.Drawing.Point(6, 22);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(188, 72);
			this.txtRemarks.TabIndex = 6;
			// 
			// grpRemarks
			// 
			this.grpRemarks.Controls.Add(this.txtRemarks);
			this.grpRemarks.Location = new System.Drawing.Point(169, 85);
			this.grpRemarks.Name = "grpRemarks";
			this.grpRemarks.Size = new System.Drawing.Size(200, 100);
			this.grpRemarks.TabIndex = 7;
			this.grpRemarks.TabStop = false;
			this.grpRemarks.Text = "Remarks (Optional)";
			// 
			// frmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 318);
			this.Controls.Add(this.grpRemarks);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.cmdAttendanceSummary);
			this.Controls.Add(this.cmdTimeOut);
			this.Controls.Add(this.cmdTimeIn);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.lblWelcome);
			this.Name = "frmEmployee";
			this.Text = "Employee Panel";
			this.Load += new System.EventHandler(this.frmEmployee_Load);
			this.grpRemarks.ResumeLayout(false);
			this.grpRemarks.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button cmdTimeIn;
        private System.Windows.Forms.Button cmdTimeOut;
        private System.Windows.Forms.Button cmdAttendanceSummary;
        private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.TextBox txtRemarks;
		private System.Windows.Forms.GroupBox grpRemarks;
	}
}