namespace AES_Management_System
{
	partial class frmLeaveGenerate
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
			this.cmdLeaveGenerate = new System.Windows.Forms.Button();
			this.lnklblBack = new System.Windows.Forms.LinkLabel();
			this.lnklblExit = new System.Windows.Forms.LinkLabel();
			this.lblNewUser = new System.Windows.Forms.Label();
			this.cmbNewUserName = new System.Windows.Forms.ComboBox();
			this.grpNewUserLeaveGenerate = new System.Windows.Forms.GroupBox();
			this.cmdGenerate = new System.Windows.Forms.Button();
			this.txtNewUserId = new System.Windows.Forms.TextBox();
			this.grpNewUserLeaveGenerate.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdLeaveGenerate
			// 
			this.cmdLeaveGenerate.Location = new System.Drawing.Point(88, 91);
			this.cmdLeaveGenerate.Name = "cmdLeaveGenerate";
			this.cmdLeaveGenerate.Size = new System.Drawing.Size(190, 23);
			this.cmdLeaveGenerate.TabIndex = 0;
			this.cmdLeaveGenerate.Text = "Generate for this Year";
			this.cmdLeaveGenerate.UseVisualStyleBackColor = true;
			this.cmdLeaveGenerate.Click += new System.EventHandler(this.cmdLeaveGenerate_Click);
			// 
			// lnklblBack
			// 
			this.lnklblBack.AutoSize = true;
			this.lnklblBack.Location = new System.Drawing.Point(12, 19);
			this.lnklblBack.Name = "lnklblBack";
			this.lnklblBack.Size = new System.Drawing.Size(32, 13);
			this.lnklblBack.TabIndex = 1;
			this.lnklblBack.TabStop = true;
			this.lnklblBack.Text = "Back";
			this.lnklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBack_LinkClicked);
			// 
			// lnklblExit
			// 
			this.lnklblExit.AutoSize = true;
			this.lnklblExit.Location = new System.Drawing.Point(292, 19);
			this.lnklblExit.Name = "lnklblExit";
			this.lnklblExit.Size = new System.Drawing.Size(48, 13);
			this.lnklblExit.TabIndex = 2;
			this.lnklblExit.TabStop = true;
			this.lnklblExit.Text = "Sign Out";
			this.lnklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblExit_LinkClicked);
			// 
			// lblNewUser
			// 
			this.lblNewUser.AutoSize = true;
			this.lblNewUser.Location = new System.Drawing.Point(1, 35);
			this.lblNewUser.Name = "lblNewUser";
			this.lblNewUser.Size = new System.Drawing.Size(57, 13);
			this.lblNewUser.TabIndex = 3;
			this.lblNewUser.Text = "New User:";
			// 
			// cmbNewUserName
			// 
			this.cmbNewUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNewUserName.FormattingEnabled = true;
			this.cmbNewUserName.Location = new System.Drawing.Point(73, 35);
			this.cmbNewUserName.Name = "cmbNewUserName";
			this.cmbNewUserName.Size = new System.Drawing.Size(121, 21);
			this.cmbNewUserName.TabIndex = 4;
			this.cmbNewUserName.SelectedIndexChanged += new System.EventHandler(this.cmbNewUserName_SelectedIndexChanged);
			// 
			// grpNewUserLeaveGenerate
			// 
			this.grpNewUserLeaveGenerate.Controls.Add(this.txtNewUserId);
			this.grpNewUserLeaveGenerate.Controls.Add(this.cmdGenerate);
			this.grpNewUserLeaveGenerate.Controls.Add(this.cmbNewUserName);
			this.grpNewUserLeaveGenerate.Controls.Add(this.lblNewUser);
			this.grpNewUserLeaveGenerate.Location = new System.Drawing.Point(15, 149);
			this.grpNewUserLeaveGenerate.Name = "grpNewUserLeaveGenerate";
			this.grpNewUserLeaveGenerate.Size = new System.Drawing.Size(325, 138);
			this.grpNewUserLeaveGenerate.TabIndex = 5;
			this.grpNewUserLeaveGenerate.TabStop = false;
			this.grpNewUserLeaveGenerate.Text = "New User Leave Generate:";
			this.grpNewUserLeaveGenerate.Visible = false;
			// 
			// cmdGenerate
			// 
			this.cmdGenerate.Location = new System.Drawing.Point(119, 92);
			this.cmdGenerate.Name = "cmdGenerate";
			this.cmdGenerate.Size = new System.Drawing.Size(75, 23);
			this.cmdGenerate.TabIndex = 5;
			this.cmdGenerate.Text = "Generate";
			this.cmdGenerate.UseVisualStyleBackColor = true;
			// 
			// txtNewUserId
			// 
			this.txtNewUserId.BackColor = System.Drawing.SystemColors.Window;
			this.txtNewUserId.Location = new System.Drawing.Point(219, 36);
			this.txtNewUserId.Name = "txtNewUserId";
			this.txtNewUserId.ReadOnly = true;
			this.txtNewUserId.Size = new System.Drawing.Size(74, 20);
			this.txtNewUserId.TabIndex = 6;
			// 
			// frmLeaveGenerate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 341);
			this.Controls.Add(this.grpNewUserLeaveGenerate);
			this.Controls.Add(this.lnklblExit);
			this.Controls.Add(this.lnklblBack);
			this.Controls.Add(this.cmdLeaveGenerate);
			this.Name = "frmLeaveGenerate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Leave Generate";
			this.Load += new System.EventHandler(this.frmLeaveGenerate_Load);
			this.grpNewUserLeaveGenerate.ResumeLayout(false);
			this.grpNewUserLeaveGenerate.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdLeaveGenerate;
		private System.Windows.Forms.LinkLabel lnklblBack;
		private System.Windows.Forms.LinkLabel lnklblExit;
		private System.Windows.Forms.Label lblNewUser;
		private System.Windows.Forms.ComboBox cmbNewUserName;
		private System.Windows.Forms.GroupBox grpNewUserLeaveGenerate;
		private System.Windows.Forms.Button cmdGenerate;
		private System.Windows.Forms.TextBox txtNewUserId;
	}
}