namespace AES_Management_System
{
    partial class frmAttendanceSummary
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
			this.grdAttendanceSummary = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.cmdShow = new System.Windows.Forms.Button();
			this.lblToDate = new System.Windows.Forms.Label();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.lblFromDate = new System.Windows.Forms.Label();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.lblColorDefinition = new System.Windows.Forms.Label();
			this.lnklblExit = new System.Windows.Forms.LinkLabel();
			this.lnklblBack = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.grdAttendanceSummary)).BeginInit();
			this.SuspendLayout();
			// 
			// grdAttendanceSummary
			// 
			this.grdAttendanceSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdAttendanceSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.grdAttendanceSummary.Location = new System.Drawing.Point(36, 122);
			this.grdAttendanceSummary.Name = "grdAttendanceSummary";
			this.grdAttendanceSummary.Size = new System.Drawing.Size(764, 309);
			this.grdAttendanceSummary.TabIndex = 12;
			this.grdAttendanceSummary.Visible = false;
			this.grdAttendanceSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAttendanceDetails_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "User Id";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "User Name";
			this.Column2.Name = "Column2";
			this.Column2.Width = 130;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Login Date";
			this.Column3.Name = "Column3";
			this.Column3.Width = 130;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Login Time";
			this.Column4.Name = "Column4";
			this.Column4.Width = 130;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Logout Time";
			this.Column5.Name = "Column5";
			this.Column5.Width = 130;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Details";
			this.Column6.Name = "Column6";
			this.Column6.Text = "Show";
			this.Column6.UseColumnTextForButtonValue = true;
			// 
			// cmdShow
			// 
			this.cmdShow.Location = new System.Drawing.Point(398, 93);
			this.cmdShow.Name = "cmdShow";
			this.cmdShow.Size = new System.Drawing.Size(75, 23);
			this.cmdShow.TabIndex = 11;
			this.cmdShow.Text = "Show";
			this.cmdShow.UseVisualStyleBackColor = true;
			this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
			// 
			// lblToDate
			// 
			this.lblToDate.AutoSize = true;
			this.lblToDate.Location = new System.Drawing.Point(503, 46);
			this.lblToDate.Name = "lblToDate";
			this.lblToDate.Size = new System.Drawing.Size(46, 13);
			this.lblToDate.TabIndex = 10;
			this.lblToDate.Text = "To Date";
			// 
			// dtpToDate
			// 
			this.dtpToDate.Location = new System.Drawing.Point(600, 46);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(200, 20);
			this.dtpToDate.TabIndex = 9;
			// 
			// lblFromDate
			// 
			this.lblFromDate.AutoSize = true;
			this.lblFromDate.Location = new System.Drawing.Point(46, 46);
			this.lblFromDate.Name = "lblFromDate";
			this.lblFromDate.Size = new System.Drawing.Size(56, 13);
			this.lblFromDate.TabIndex = 8;
			this.lblFromDate.Text = "From Date";
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.Location = new System.Drawing.Point(141, 46);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
			this.dtpFromDate.TabIndex = 7;
			// 
			// lblColorDefinition
			// 
			this.lblColorDefinition.AutoSize = true;
			this.lblColorDefinition.Location = new System.Drawing.Point(33, 458);
			this.lblColorDefinition.Name = "lblColorDefinition";
			this.lblColorDefinition.Size = new System.Drawing.Size(35, 13);
			this.lblColorDefinition.TabIndex = 14;
			this.lblColorDefinition.Text = "label1";
			this.lblColorDefinition.Visible = false;
			// 
			// lnklblExit
			// 
			this.lnklblExit.AutoSize = true;
			this.lnklblExit.Location = new System.Drawing.Point(752, 9);
			this.lnklblExit.Name = "lnklblExit";
			this.lnklblExit.Size = new System.Drawing.Size(48, 13);
			this.lnklblExit.TabIndex = 16;
			this.lnklblExit.TabStop = true;
			this.lnklblExit.Text = "Sign Out";
			this.lnklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblExit_LinkClicked);
			// 
			// lnklblBack
			// 
			this.lnklblBack.AutoSize = true;
			this.lnklblBack.Location = new System.Drawing.Point(46, 9);
			this.lnklblBack.Name = "lnklblBack";
			this.lnklblBack.Size = new System.Drawing.Size(32, 13);
			this.lnklblBack.TabIndex = 15;
			this.lnklblBack.TabStop = true;
			this.lnklblBack.Text = "Back";
			this.lnklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBack_LinkClicked);
			// 
			// frmAttendanceSummary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(902, 515);
			this.Controls.Add(this.lnklblExit);
			this.Controls.Add(this.lnklblBack);
			this.Controls.Add(this.lblColorDefinition);
			this.Controls.Add(this.grdAttendanceSummary);
			this.Controls.Add(this.cmdShow);
			this.Controls.Add(this.lblToDate);
			this.Controls.Add(this.dtpToDate);
			this.Controls.Add(this.lblFromDate);
			this.Controls.Add(this.dtpFromDate);
			this.Name = "frmAttendanceSummary";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Attendance Summary";
			((System.ComponentModel.ISupportInitialize)(this.grdAttendanceSummary)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdAttendanceSummary;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
		private System.Windows.Forms.Label lblColorDefinition;
		private System.Windows.Forms.LinkLabel lnklblExit;
		private System.Windows.Forms.LinkLabel lnklblBack;
	}
}