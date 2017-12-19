namespace AES_Management_System
{
	partial class frmEmployeeDelete
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
			this.grpUserName = new System.Windows.Forms.GroupBox();
			this.cmbUserName = new System.Windows.Forms.ComboBox();
			this.grpUserId = new System.Windows.Forms.GroupBox();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.lnklblExit = new System.Windows.Forms.LinkLabel();
			this.lnklblBack = new System.Windows.Forms.LinkLabel();
			this.grpUserName.SuspendLayout();
			this.grpUserId.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpUserName
			// 
			this.grpUserName.Controls.Add(this.cmbUserName);
			this.grpUserName.Location = new System.Drawing.Point(38, 52);
			this.grpUserName.Name = "grpUserName";
			this.grpUserName.Size = new System.Drawing.Size(227, 75);
			this.grpUserName.TabIndex = 0;
			this.grpUserName.TabStop = false;
			this.grpUserName.Text = "Select User Name:";
			// 
			// cmbUserName
			// 
			this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUserName.FormattingEnabled = true;
			this.cmbUserName.Location = new System.Drawing.Point(74, 29);
			this.cmbUserName.Name = "cmbUserName";
			this.cmbUserName.Size = new System.Drawing.Size(121, 21);
			this.cmbUserName.TabIndex = 0;
			this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
			// 
			// grpUserId
			// 
			this.grpUserId.Controls.Add(this.txtUserId);
			this.grpUserId.Location = new System.Drawing.Point(271, 52);
			this.grpUserId.Name = "grpUserId";
			this.grpUserId.Size = new System.Drawing.Size(125, 75);
			this.grpUserId.TabIndex = 1;
			this.grpUserId.TabStop = false;
			this.grpUserId.Text = "Selected User Id Is:";
			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(43, 30);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.ReadOnly = true;
			this.txtUserId.Size = new System.Drawing.Size(61, 20);
			this.txtUserId.TabIndex = 0;
			// 
			// cmdDelete
			// 
			this.cmdDelete.Enabled = false;
			this.cmdDelete.Location = new System.Drawing.Point(158, 155);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(75, 23);
			this.cmdDelete.TabIndex = 2;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.UseVisualStyleBackColor = true;
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			// 
			// lnklblExit
			// 
			this.lnklblExit.AutoSize = true;
			this.lnklblExit.Location = new System.Drawing.Point(404, 13);
			this.lnklblExit.Name = "lnklblExit";
			this.lnklblExit.Size = new System.Drawing.Size(48, 13);
			this.lnklblExit.TabIndex = 8;
			this.lnklblExit.TabStop = true;
			this.lnklblExit.Text = "Sign Out";
			this.lnklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblExit_LinkClicked);
			// 
			// lnklblBack
			// 
			this.lnklblBack.AutoSize = true;
			this.lnklblBack.Location = new System.Drawing.Point(35, 13);
			this.lnklblBack.Name = "lnklblBack";
			this.lnklblBack.Size = new System.Drawing.Size(32, 13);
			this.lnklblBack.TabIndex = 7;
			this.lnklblBack.TabStop = true;
			this.lnklblBack.Text = "Back";
			this.lnklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBack_LinkClicked);
			// 
			// frmEmployeeDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 197);
			this.Controls.Add(this.lnklblExit);
			this.Controls.Add(this.lnklblBack);
			this.Controls.Add(this.cmdDelete);
			this.Controls.Add(this.grpUserId);
			this.Controls.Add(this.grpUserName);
			this.Name = "frmEmployeeDelete";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Employee";
			this.Load += new System.EventHandler(this.frmEmployeeDelete_Load);
			this.grpUserName.ResumeLayout(false);
			this.grpUserId.ResumeLayout(false);
			this.grpUserId.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpUserName;
		private System.Windows.Forms.ComboBox cmbUserName;
		private System.Windows.Forms.GroupBox grpUserId;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.Button cmdDelete;
		private System.Windows.Forms.LinkLabel lnklblExit;
		private System.Windows.Forms.LinkLabel lnklblBack;
	}
}