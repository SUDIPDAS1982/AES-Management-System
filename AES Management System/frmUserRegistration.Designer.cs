namespace AES_Management_System
{
	partial class frmUserRegistration
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
			this.cmbUserId = new System.Windows.Forms.ComboBox();
			this.grpUserId = new System.Windows.Forms.GroupBox();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblCreatePassword = new System.Windows.Forms.Label();
			this.txtCreatePassword = new System.Windows.Forms.TextBox();
			this.lblConfirmPassword = new System.Windows.Forms.Label();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.cmdRegister = new System.Windows.Forms.Button();
			this.grpRegistration = new System.Windows.Forms.GroupBox();
			this.lnklblBack = new System.Windows.Forms.LinkLabel();
			this.lnklblExit = new System.Windows.Forms.LinkLabel();
			this.lblPsswordError = new System.Windows.Forms.Label();
			this.grpUserId.SuspendLayout();
			this.grpRegistration.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbUserId
			// 
			this.cmbUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUserId.FormattingEnabled = true;
			this.cmbUserId.Location = new System.Drawing.Point(72, 32);
			this.cmbUserId.Name = "cmbUserId";
			this.cmbUserId.Size = new System.Drawing.Size(150, 21);
			this.cmbUserId.TabIndex = 0;
			this.cmbUserId.SelectedIndexChanged += new System.EventHandler(this.cmbUserId_SelectedIndexChanged);
			// 
			// grpUserId
			// 
			this.grpUserId.Controls.Add(this.cmbUserId);
			this.grpUserId.Controls.Add(this.txtUserId);
			this.grpUserId.Location = new System.Drawing.Point(30, 47);
			this.grpUserId.Name = "grpUserId";
			this.grpUserId.Size = new System.Drawing.Size(405, 78);
			this.grpUserId.TabIndex = 1;
			this.grpUserId.TabStop = false;
			this.grpUserId.Text = "Select Your Full Name and check Your Id is correct as given by Admin:";
			// 
			// txtUserId
			// 
			this.txtUserId.BackColor = System.Drawing.SystemColors.Window;
			this.txtUserId.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtUserId.Location = new System.Drawing.Point(260, 32);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.ReadOnly = true;
			this.txtUserId.Size = new System.Drawing.Size(80, 20);
			this.txtUserId.TabIndex = 1;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(199, 27);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(141, 20);
			this.txtUserName.TabIndex = 2;
			this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(54, 34);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(127, 13);
			this.lblUserName.TabIndex = 3;
			this.lblUserName.Text = "Choose Your User Name:";
			// 
			// lblCreatePassword
			// 
			this.lblCreatePassword.AutoSize = true;
			this.lblCreatePassword.Location = new System.Drawing.Point(54, 74);
			this.lblCreatePassword.Name = "lblCreatePassword";
			this.lblCreatePassword.Size = new System.Drawing.Size(99, 13);
			this.lblCreatePassword.TabIndex = 5;
			this.lblCreatePassword.Text = "Create a Password:";
			// 
			// txtCreatePassword
			// 
			this.txtCreatePassword.Location = new System.Drawing.Point(199, 67);
			this.txtCreatePassword.Name = "txtCreatePassword";
			this.txtCreatePassword.PasswordChar = '*';
			this.txtCreatePassword.Size = new System.Drawing.Size(141, 20);
			this.txtCreatePassword.TabIndex = 4;
			this.txtCreatePassword.Leave += new System.EventHandler(this.txtCreatePassword_Leave);
			// 
			// lblConfirmPassword
			// 
			this.lblConfirmPassword.AutoSize = true;
			this.lblConfirmPassword.Location = new System.Drawing.Point(54, 125);
			this.lblConfirmPassword.Name = "lblConfirmPassword";
			this.lblConfirmPassword.Size = new System.Drawing.Size(119, 13);
			this.lblConfirmPassword.TabIndex = 7;
			this.lblConfirmPassword.Text = "Confirm Your Password:";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(199, 118);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(141, 20);
			this.txtConfirmPassword.TabIndex = 6;
			this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
			// 
			// cmdRegister
			// 
			this.cmdRegister.Location = new System.Drawing.Point(147, 165);
			this.cmdRegister.Name = "cmdRegister";
			this.cmdRegister.Size = new System.Drawing.Size(75, 23);
			this.cmdRegister.TabIndex = 9;
			this.cmdRegister.Text = "Register";
			this.cmdRegister.UseVisualStyleBackColor = true;
			this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
			// 
			// grpRegistration
			// 
			this.grpRegistration.Controls.Add(this.lblPsswordError);
			this.grpRegistration.Controls.Add(this.cmdRegister);
			this.grpRegistration.Controls.Add(this.txtUserName);
			this.grpRegistration.Controls.Add(this.lblUserName);
			this.grpRegistration.Controls.Add(this.txtCreatePassword);
			this.grpRegistration.Controls.Add(this.lblConfirmPassword);
			this.grpRegistration.Controls.Add(this.lblCreatePassword);
			this.grpRegistration.Controls.Add(this.txtConfirmPassword);
			this.grpRegistration.Location = new System.Drawing.Point(30, 131);
			this.grpRegistration.Name = "grpRegistration";
			this.grpRegistration.Size = new System.Drawing.Size(405, 211);
			this.grpRegistration.TabIndex = 10;
			this.grpRegistration.TabStop = false;
			this.grpRegistration.Text = "Registration Process:";
			// 
			// lnklblBack
			// 
			this.lnklblBack.AutoSize = true;
			this.lnklblBack.Location = new System.Drawing.Point(27, 9);
			this.lnklblBack.Name = "lnklblBack";
			this.lnklblBack.Size = new System.Drawing.Size(32, 13);
			this.lnklblBack.TabIndex = 11;
			this.lnklblBack.TabStop = true;
			this.lnklblBack.Text = "Back";
			this.lnklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBack_LinkClicked);
			// 
			// lnklblExit
			// 
			this.lnklblExit.AutoSize = true;
			this.lnklblExit.Location = new System.Drawing.Point(387, 9);
			this.lnklblExit.Name = "lnklblExit";
			this.lnklblExit.Size = new System.Drawing.Size(48, 13);
			this.lnklblExit.TabIndex = 12;
			this.lnklblExit.TabStop = true;
			this.lnklblExit.Text = "Sign Out";
			this.lnklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblExit_LinkClicked);
			// 
			// lblPsswordError
			// 
			this.lblPsswordError.AutoSize = true;
			this.lblPsswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPsswordError.Location = new System.Drawing.Point(196, 90);
			this.lblPsswordError.Name = "lblPsswordError";
			this.lblPsswordError.Size = new System.Drawing.Size(139, 9);
			this.lblPsswordError.TabIndex = 10;
			this.lblPsswordError.Text = "Password should be at least 8 character";
			// 
			// frmUserRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 370);
			this.Controls.Add(this.lnklblExit);
			this.Controls.Add(this.lnklblBack);
			this.Controls.Add(this.grpRegistration);
			this.Controls.Add(this.grpUserId);
			this.Name = "frmUserRegistration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Registration";
			this.Load += new System.EventHandler(this.frmUserRegistration_Load);
			this.grpUserId.ResumeLayout(false);
			this.grpUserId.PerformLayout();
			this.grpRegistration.ResumeLayout(false);
			this.grpRegistration.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbUserId;
		private System.Windows.Forms.GroupBox grpUserId;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblCreatePassword;
		private System.Windows.Forms.TextBox txtCreatePassword;
		private System.Windows.Forms.Label lblConfirmPassword;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Button cmdRegister;
		private System.Windows.Forms.GroupBox grpRegistration;
		private System.Windows.Forms.LinkLabel lnklblBack;
		private System.Windows.Forms.LinkLabel lnklblExit;
		private System.Windows.Forms.Label lblPsswordError;
	}
}