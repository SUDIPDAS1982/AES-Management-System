namespace AES_Management_System
{
	partial class frmEmployeeEdit
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
			this.lblId = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.lblFullName = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtPincode = new System.Windows.Forms.TextBox();
			this.lblPincode = new System.Windows.Forms.Label();
			this.txtDateOfBirth = new System.Windows.Forms.TextBox();
			this.lblDateOfBirth = new System.Windows.Forms.Label();
			this.txtContactNumber = new System.Windows.Forms.TextBox();
			this.lblContactNumber = new System.Windows.Forms.Label();
			this.txtEmailId = new System.Windows.Forms.TextBox();
			this.lblEmailId = new System.Windows.Forms.Label();
			this.lblQualification = new System.Windows.Forms.Label();
			this.grpGender = new System.Windows.Forms.GroupBox();
			this.optOther = new System.Windows.Forms.RadioButton();
			this.optFemale = new System.Windows.Forms.RadioButton();
			this.optMale = new System.Windows.Forms.RadioButton();
			this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.cmdSave = new System.Windows.Forms.Button();
			this.lnklblExit = new System.Windows.Forms.LinkLabel();
			this.lnklblBack = new System.Windows.Forms.LinkLabel();
			this.cmbQualification = new System.Windows.Forms.ComboBox();
			this.grpGender.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(63, 70);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(21, 13);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "ID:";
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(156, 70);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 1;
			// 
			// txtFullName
			// 
			this.txtFullName.Enabled = false;
			this.txtFullName.Location = new System.Drawing.Point(156, 119);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(205, 20);
			this.txtFullName.TabIndex = 3;
			// 
			// lblFullName
			// 
			this.lblFullName.AutoSize = true;
			this.lblFullName.Location = new System.Drawing.Point(63, 119);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(57, 13);
			this.lblFullName.TabIndex = 2;
			this.lblFullName.Text = "Full Name:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(156, 159);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(282, 20);
			this.txtAddress.TabIndex = 7;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(63, 159);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(48, 13);
			this.lblAddress.TabIndex = 6;
			this.lblAddress.Text = "Address:";
			// 
			// txtPincode
			// 
			this.txtPincode.Location = new System.Drawing.Point(540, 159);
			this.txtPincode.Name = "txtPincode";
			this.txtPincode.Size = new System.Drawing.Size(100, 20);
			this.txtPincode.TabIndex = 5;
			// 
			// lblPincode
			// 
			this.lblPincode.AutoSize = true;
			this.lblPincode.Location = new System.Drawing.Point(468, 159);
			this.lblPincode.Name = "lblPincode";
			this.lblPincode.Size = new System.Drawing.Size(49, 13);
			this.lblPincode.TabIndex = 4;
			this.lblPincode.Text = "Pincode:";
			// 
			// txtDateOfBirth
			// 
			this.txtDateOfBirth.BackColor = System.Drawing.SystemColors.Window;
			this.txtDateOfBirth.Location = new System.Drawing.Point(156, 272);
			this.txtDateOfBirth.Name = "txtDateOfBirth";
			this.txtDateOfBirth.ReadOnly = true;
			this.txtDateOfBirth.Size = new System.Drawing.Size(158, 20);
			this.txtDateOfBirth.TabIndex = 11;
			// 
			// lblDateOfBirth
			// 
			this.lblDateOfBirth.AutoSize = true;
			this.lblDateOfBirth.Location = new System.Drawing.Point(63, 269);
			this.lblDateOfBirth.Name = "lblDateOfBirth";
			this.lblDateOfBirth.Size = new System.Drawing.Size(71, 13);
			this.lblDateOfBirth.TabIndex = 10;
			this.lblDateOfBirth.Text = "Date Of Birth:";
			// 
			// txtContactNumber
			// 
			this.txtContactNumber.Location = new System.Drawing.Point(156, 322);
			this.txtContactNumber.Name = "txtContactNumber";
			this.txtContactNumber.Size = new System.Drawing.Size(100, 20);
			this.txtContactNumber.TabIndex = 13;
			// 
			// lblContactNumber
			// 
			this.lblContactNumber.AutoSize = true;
			this.lblContactNumber.Location = new System.Drawing.Point(63, 322);
			this.lblContactNumber.Name = "lblContactNumber";
			this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
			this.lblContactNumber.TabIndex = 12;
			this.lblContactNumber.Text = "Contact Number:";
			// 
			// txtEmailId
			// 
			this.txtEmailId.Location = new System.Drawing.Point(156, 376);
			this.txtEmailId.Name = "txtEmailId";
			this.txtEmailId.Size = new System.Drawing.Size(208, 20);
			this.txtEmailId.TabIndex = 15;
			// 
			// lblEmailId
			// 
			this.lblEmailId.AutoSize = true;
			this.lblEmailId.Location = new System.Drawing.Point(63, 376);
			this.lblEmailId.Name = "lblEmailId";
			this.lblEmailId.Size = new System.Drawing.Size(47, 13);
			this.lblEmailId.TabIndex = 14;
			this.lblEmailId.Text = "Email Id:";
			// 
			// lblQualification
			// 
			this.lblQualification.AutoSize = true;
			this.lblQualification.Location = new System.Drawing.Point(63, 429);
			this.lblQualification.Name = "lblQualification";
			this.lblQualification.Size = new System.Drawing.Size(91, 13);
			this.lblQualification.TabIndex = 16;
			this.lblQualification.Text = "Last Qualification:";
			// 
			// grpGender
			// 
			this.grpGender.Controls.Add(this.optOther);
			this.grpGender.Controls.Add(this.optFemale);
			this.grpGender.Controls.Add(this.optMale);
			this.grpGender.Location = new System.Drawing.Point(66, 198);
			this.grpGender.Name = "grpGender";
			this.grpGender.Size = new System.Drawing.Size(351, 43);
			this.grpGender.TabIndex = 18;
			this.grpGender.TabStop = false;
			this.grpGender.Text = "Gender:";
			// 
			// optOther
			// 
			this.optOther.AutoSize = true;
			this.optOther.Location = new System.Drawing.Point(263, 16);
			this.optOther.Name = "optOther";
			this.optOther.Size = new System.Drawing.Size(51, 17);
			this.optOther.TabIndex = 2;
			this.optOther.TabStop = true;
			this.optOther.Text = "Other";
			this.optOther.UseVisualStyleBackColor = true;
			// 
			// optFemale
			// 
			this.optFemale.AutoSize = true;
			this.optFemale.Location = new System.Drawing.Point(158, 16);
			this.optFemale.Name = "optFemale";
			this.optFemale.Size = new System.Drawing.Size(59, 17);
			this.optFemale.TabIndex = 1;
			this.optFemale.TabStop = true;
			this.optFemale.Text = "Female";
			this.optFemale.UseVisualStyleBackColor = true;
			// 
			// optMale
			// 
			this.optMale.AutoSize = true;
			this.optMale.Location = new System.Drawing.Point(65, 16);
			this.optMale.Name = "optMale";
			this.optMale.Size = new System.Drawing.Size(48, 17);
			this.optMale.TabIndex = 0;
			this.optMale.TabStop = true;
			this.optMale.Text = "Male";
			this.optMale.UseVisualStyleBackColor = true;
			// 
			// dtpDateOfBirth
			// 
			this.dtpDateOfBirth.Location = new System.Drawing.Point(309, 272);
			this.dtpDateOfBirth.Name = "dtpDateOfBirth";
			this.dtpDateOfBirth.Size = new System.Drawing.Size(19, 20);
			this.dtpDateOfBirth.TabIndex = 19;
			this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
			// 
			// cmdSave
			// 
			this.cmdSave.Location = new System.Drawing.Point(265, 481);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(75, 23);
			this.cmdSave.TabIndex = 20;
			this.cmdSave.Text = "Save";
			this.cmdSave.UseVisualStyleBackColor = true;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// lnklblExit
			// 
			this.lnklblExit.AutoSize = true;
			this.lnklblExit.Location = new System.Drawing.Point(592, 15);
			this.lnklblExit.Name = "lnklblExit";
			this.lnklblExit.Size = new System.Drawing.Size(48, 13);
			this.lnklblExit.TabIndex = 22;
			this.lnklblExit.TabStop = true;
			this.lnklblExit.Text = "Sign Out";
			this.lnklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblExit_LinkClicked);
			// 
			// lnklblBack
			// 
			this.lnklblBack.AutoSize = true;
			this.lnklblBack.Location = new System.Drawing.Point(49, 15);
			this.lnklblBack.Name = "lnklblBack";
			this.lnklblBack.Size = new System.Drawing.Size(32, 13);
			this.lnklblBack.TabIndex = 21;
			this.lnklblBack.TabStop = true;
			this.lnklblBack.Text = "Back";
			this.lnklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBack_LinkClicked);
			// 
			// cmbQualification
			// 
			this.cmbQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbQualification.FormattingEnabled = true;
			this.cmbQualification.Items.AddRange(new object[] {
            "PHD",
            "MASTER",
            "BACHELOR",
            "12TH STANDARDS",
            "10TH STANDARDS"});
			this.cmbQualification.Location = new System.Drawing.Point(156, 429);
			this.cmbQualification.Name = "cmbQualification";
			this.cmbQualification.Size = new System.Drawing.Size(127, 21);
			this.cmbQualification.TabIndex = 23;
			this.cmbQualification.SelectedIndexChanged += new System.EventHandler(this.cmbQualification_SelectedIndexChanged);
			// 
			// frmEmployeeEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 516);
			this.Controls.Add(this.cmbQualification);
			this.Controls.Add(this.lnklblExit);
			this.Controls.Add(this.lnklblBack);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.dtpDateOfBirth);
			this.Controls.Add(this.grpGender);
			this.Controls.Add(this.lblQualification);
			this.Controls.Add(this.txtEmailId);
			this.Controls.Add(this.lblEmailId);
			this.Controls.Add(this.txtContactNumber);
			this.Controls.Add(this.lblContactNumber);
			this.Controls.Add(this.txtDateOfBirth);
			this.Controls.Add(this.lblDateOfBirth);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.txtPincode);
			this.Controls.Add(this.lblPincode);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.lblFullName);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblId);
			this.Name = "frmEmployeeEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Employee";
			this.Load += new System.EventHandler(this.frmEmployeeEdit_Load);
			this.grpGender.ResumeLayout(false);
			this.grpGender.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtPincode;
		private System.Windows.Forms.Label lblPincode;
		private System.Windows.Forms.TextBox txtDateOfBirth;
		private System.Windows.Forms.Label lblDateOfBirth;
		private System.Windows.Forms.TextBox txtContactNumber;
		private System.Windows.Forms.Label lblContactNumber;
		private System.Windows.Forms.TextBox txtEmailId;
		private System.Windows.Forms.Label lblEmailId;
		private System.Windows.Forms.Label lblQualification;
		private System.Windows.Forms.GroupBox grpGender;
		private System.Windows.Forms.RadioButton optOther;
		private System.Windows.Forms.RadioButton optFemale;
		private System.Windows.Forms.RadioButton optMale;
		private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.LinkLabel lnklblExit;
		private System.Windows.Forms.LinkLabel lnklblBack;
		private System.Windows.Forms.ComboBox cmbQualification;
	}
}