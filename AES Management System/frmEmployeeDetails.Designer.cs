namespace AES_Management_System
{
    partial class frmEmployeeDetails
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
			this.optAll = new System.Windows.Forms.RadioButton();
			this.optIndividualEmployee = new System.Windows.Forms.RadioButton();
			this.cmbUser = new System.Windows.Forms.ComboBox();
			this.cmdDisplay = new System.Windows.Forms.Button();
			this.grdEmployeeDetailDisplay = new System.Windows.Forms.DataGridView();
			this.lnklblBack = new System.Windows.Forms.LinkLabel();
			this.lnklblExit = new System.Windows.Forms.LinkLabel();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdEmployeeDetailDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// optAll
			// 
			this.optAll.AutoSize = true;
			this.optAll.Location = new System.Drawing.Point(332, 48);
			this.optAll.Name = "optAll";
			this.optAll.Size = new System.Drawing.Size(36, 17);
			this.optAll.TabIndex = 0;
			this.optAll.TabStop = true;
			this.optAll.Text = "All";
			this.optAll.UseVisualStyleBackColor = true;
			this.optAll.CheckedChanged += new System.EventHandler(this.optAll_CheckedChanged);
			// 
			// optIndividualEmployee
			// 
			this.optIndividualEmployee.AutoSize = true;
			this.optIndividualEmployee.Location = new System.Drawing.Point(445, 48);
			this.optIndividualEmployee.Name = "optIndividualEmployee";
			this.optIndividualEmployee.Size = new System.Drawing.Size(119, 17);
			this.optIndividualEmployee.TabIndex = 1;
			this.optIndividualEmployee.TabStop = true;
			this.optIndividualEmployee.Text = "Individual Employee";
			this.optIndividualEmployee.UseVisualStyleBackColor = true;
			this.optIndividualEmployee.CheckedChanged += new System.EventHandler(this.optIndividualEmployee_CheckedChanged);
			// 
			// cmbUser
			// 
			this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUser.FormattingEnabled = true;
			this.cmbUser.Location = new System.Drawing.Point(611, 48);
			this.cmbUser.Name = "cmbUser";
			this.cmbUser.Size = new System.Drawing.Size(110, 21);
			this.cmbUser.TabIndex = 2;
			this.cmbUser.Visible = false;
			// 
			// cmdDisplay
			// 
			this.cmdDisplay.Location = new System.Drawing.Point(445, 97);
			this.cmdDisplay.Name = "cmdDisplay";
			this.cmdDisplay.Size = new System.Drawing.Size(75, 23);
			this.cmdDisplay.TabIndex = 3;
			this.cmdDisplay.Text = "Display";
			this.cmdDisplay.UseVisualStyleBackColor = true;
			this.cmdDisplay.Click += new System.EventHandler(this.cmdDisplay_Click);
			// 
			// grdEmployeeDetailDisplay
			// 
			this.grdEmployeeDetailDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdEmployeeDetailDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
			this.grdEmployeeDetailDisplay.Location = new System.Drawing.Point(12, 141);
			this.grdEmployeeDetailDisplay.Name = "grdEmployeeDetailDisplay";
			this.grdEmployeeDetailDisplay.Size = new System.Drawing.Size(1009, 279);
			this.grdEmployeeDetailDisplay.TabIndex = 4;
			this.grdEmployeeDetailDisplay.Visible = false;
			this.grdEmployeeDetailDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployeeDetailDisplay_CellContentClick);
			// 
			// lnklblBack
			// 
			this.lnklblBack.AutoSize = true;
			this.lnklblBack.Location = new System.Drawing.Point(62, 9);
			this.lnklblBack.Name = "lnklblBack";
			this.lnklblBack.Size = new System.Drawing.Size(32, 13);
			this.lnklblBack.TabIndex = 5;
			this.lnklblBack.TabStop = true;
			this.lnklblBack.Text = "Back";
			this.lnklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBack_LinkClicked);
			// 
			// lnklblExit
			// 
			this.lnklblExit.AutoSize = true;
			this.lnklblExit.Location = new System.Drawing.Point(931, 9);
			this.lnklblExit.Name = "lnklblExit";
			this.lnklblExit.Size = new System.Drawing.Size(48, 13);
			this.lnklblExit.TabIndex = 6;
			this.lnklblExit.TabStop = true;
			this.lnklblExit.Text = "Sign Out";
			this.lnklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblExit_LinkClicked);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.Width = 30;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Full Name";
			this.Column2.Name = "Column2";
			this.Column2.Width = 120;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Address";
			this.Column3.Name = "Column3";
			this.Column3.Width = 120;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Pincode";
			this.Column4.Name = "Column4";
			this.Column4.Width = 60;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Gender";
			this.Column5.Name = "Column5";
			this.Column5.Width = 80;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "DOB";
			this.Column6.Name = "Column6";
			this.Column6.Width = 120;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Contact No";
			this.Column7.Name = "Column7";
			this.Column7.Width = 80;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Email";
			this.Column8.Name = "Column8";
			this.Column8.Width = 150;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Qualification";
			this.Column9.Name = "Column9";
			// 
			// Column10
			// 
			this.Column10.HeaderText = "";
			this.Column10.Name = "Column10";
			this.Column10.Text = "Edit";
			this.Column10.UseColumnTextForButtonValue = true;
			this.Column10.Width = 50;
			// 
			// Column11
			// 
			this.Column11.HeaderText = "";
			this.Column11.Name = "Column11";
			this.Column11.Text = "Delete";
			this.Column11.UseColumnTextForButtonValue = true;
			this.Column11.Width = 50;
			// 
			// frmEmployeeDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1076, 478);
			this.Controls.Add(this.lnklblExit);
			this.Controls.Add(this.lnklblBack);
			this.Controls.Add(this.grdEmployeeDetailDisplay);
			this.Controls.Add(this.cmdDisplay);
			this.Controls.Add(this.cmbUser);
			this.Controls.Add(this.optIndividualEmployee);
			this.Controls.Add(this.optAll);
			this.Name = "frmEmployeeDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Details";
			this.Load += new System.EventHandler(this.frmEmployeeDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdEmployeeDetailDisplay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.RadioButton optIndividualEmployee;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Button cmdDisplay;
        private System.Windows.Forms.DataGridView grdEmployeeDetailDisplay;
        private System.Windows.Forms.LinkLabel lnklblBack;
        private System.Windows.Forms.LinkLabel lnklblExit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewButtonColumn Column10;
		private System.Windows.Forms.DataGridViewButtonColumn Column11;
	}
}