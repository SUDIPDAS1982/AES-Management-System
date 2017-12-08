namespace AES_Management_System
{
	partial class frmAttendanceDetails
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
			this.grdAttendanceDetails = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lnklblExit = new System.Windows.Forms.LinkLabel();
			this.lnklblBack = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.grdAttendanceDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// grdAttendanceDetails
			// 
			this.grdAttendanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdAttendanceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
			this.grdAttendanceDetails.Location = new System.Drawing.Point(50, 54);
			this.grdAttendanceDetails.Name = "grdAttendanceDetails";
			this.grdAttendanceDetails.Size = new System.Drawing.Size(965, 258);
			this.grdAttendanceDetails.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "User Name";
			this.Column1.Name = "Column1";
			this.Column1.Width = 130;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Login Date";
			this.Column2.Name = "Column2";
			this.Column2.Width = 130;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Login Time";
			this.Column3.Name = "Column3";
			this.Column3.Width = 130;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Login Remarks";
			this.Column6.Name = "Column6";
			this.Column6.Width = 200;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Logout Time";
			this.Column4.Name = "Column4";
			this.Column4.Width = 130;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Logout Remarks";
			this.Column5.Name = "Column5";
			this.Column5.Width = 200;
			// 
			// lnklblExit
			// 
			this.lnklblExit.AutoSize = true;
			this.lnklblExit.Location = new System.Drawing.Point(114, 346);
			this.lnklblExit.Name = "lnklblExit";
			this.lnklblExit.Size = new System.Drawing.Size(24, 13);
			this.lnklblExit.TabIndex = 8;
			this.lnklblExit.TabStop = true;
			this.lnklblExit.Text = "Exit";
			this.lnklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblExit_LinkClicked);
			// 
			// lnklblBack
			// 
			this.lnklblBack.AutoSize = true;
			this.lnklblBack.Location = new System.Drawing.Point(47, 346);
			this.lnklblBack.Name = "lnklblBack";
			this.lnklblBack.Size = new System.Drawing.Size(32, 13);
			this.lnklblBack.TabIndex = 7;
			this.lnklblBack.TabStop = true;
			this.lnklblBack.Text = "Back";
			this.lnklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBack_LinkClicked);
			// 
			// frmAttendanceDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 368);
			this.Controls.Add(this.lnklblExit);
			this.Controls.Add(this.lnklblBack);
			this.Controls.Add(this.grdAttendanceDetails);
			this.Name = "frmAttendanceDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Attendance Details";
			((System.ComponentModel.ISupportInitialize)(this.grdAttendanceDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdAttendanceDetails;
		private System.Windows.Forms.LinkLabel lnklblExit;
		private System.Windows.Forms.LinkLabel lnklblBack;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}