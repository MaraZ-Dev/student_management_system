
namespace StudentRegistrationProject
{
    partial class newStud
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stdClass = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.stdState = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stdMobile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.stdAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.stdEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stdSexFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.stdSexMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.stdCountry = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.stdDOB = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.stdLname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.stdFname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check = new System.Windows.Forms.Label();
            this.nokLname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nokStdEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nokStdRelationship = new System.Windows.Forms.ComboBox();
            this.nokStdMobile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nokFname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addStdBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.stdClass);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.stdState);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.stdCountry);
            this.groupBox1.Controls.Add(this.stdDOB);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.stdLname);
            this.groupBox1.Controls.Add(this.stdFname);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // stdClass
            // 
            this.stdClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stdClass.FormattingEnabled = true;
            this.stdClass.Items.AddRange(new object[] {
            "Junior Secondary(JSS1)",
            "Junior Secondary(JSS2)",
            "Junior Secondary(JSS3)",
            "Senior Secondary(SS1)",
            "Senior Secondary(SS2)",
            "Senior Secondary(SS3)"});
            this.stdClass.Location = new System.Drawing.Point(347, 59);
            this.stdClass.Name = "stdClass";
            this.stdClass.Size = new System.Drawing.Size(188, 21);
            this.stdClass.TabIndex = 11;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(290, 59);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Class:";
            // 
            // stdState
            // 
            this.stdState.Depth = 0;
            this.stdState.Hint = "State";
            this.stdState.Location = new System.Drawing.Point(294, 108);
            this.stdState.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdState.Name = "stdState";
            this.stdState.PasswordChar = '\0';
            this.stdState.SelectedText = "";
            this.stdState.SelectionLength = 0;
            this.stdState.SelectionStart = 0;
            this.stdState.Size = new System.Drawing.Size(144, 23);
            this.stdState.TabIndex = 9;
            this.stdState.UseSystemPasswordChar = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stdMobile);
            this.groupBox4.Controls.Add(this.stdAddress);
            this.groupBox4.Controls.Add(this.stdEmail);
            this.groupBox4.Location = new System.Drawing.Point(7, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 82);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Information";
            // 
            // stdMobile
            // 
            this.stdMobile.Depth = 0;
            this.stdMobile.Hint = "Mobile Number";
            this.stdMobile.Location = new System.Drawing.Point(260, 48);
            this.stdMobile.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdMobile.Name = "stdMobile";
            this.stdMobile.PasswordChar = '\0';
            this.stdMobile.SelectedText = "";
            this.stdMobile.SelectionLength = 0;
            this.stdMobile.SelectionStart = 0;
            this.stdMobile.Size = new System.Drawing.Size(237, 23);
            this.stdMobile.TabIndex = 2;
            this.stdMobile.UseSystemPasswordChar = false;
            // 
            // stdAddress
            // 
            this.stdAddress.Depth = 0;
            this.stdAddress.Hint = "Address";
            this.stdAddress.Location = new System.Drawing.Point(6, 19);
            this.stdAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdAddress.Name = "stdAddress";
            this.stdAddress.PasswordChar = '\0';
            this.stdAddress.SelectedText = "";
            this.stdAddress.SelectionLength = 0;
            this.stdAddress.SelectionStart = 0;
            this.stdAddress.Size = new System.Drawing.Size(491, 23);
            this.stdAddress.TabIndex = 1;
            this.stdAddress.UseSystemPasswordChar = false;
            // 
            // stdEmail
            // 
            this.stdEmail.Depth = 0;
            this.stdEmail.Hint = "E-Mail";
            this.stdEmail.Location = new System.Drawing.Point(6, 48);
            this.stdEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdEmail.Name = "stdEmail";
            this.stdEmail.PasswordChar = '\0';
            this.stdEmail.SelectedText = "";
            this.stdEmail.SelectionLength = 0;
            this.stdEmail.SelectionStart = 0;
            this.stdEmail.Size = new System.Drawing.Size(228, 23);
            this.stdEmail.TabIndex = 0;
            this.stdEmail.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stdSexFemale);
            this.groupBox3.Controls.Add(this.stdSexMale);
            this.groupBox3.Location = new System.Drawing.Point(7, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 69);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gender";
            // 
            // stdSexFemale
            // 
            this.stdSexFemale.AutoSize = true;
            this.stdSexFemale.Depth = 0;
            this.stdSexFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.stdSexFemale.Location = new System.Drawing.Point(119, 20);
            this.stdSexFemale.Margin = new System.Windows.Forms.Padding(0);
            this.stdSexFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.stdSexFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdSexFemale.Name = "stdSexFemale";
            this.stdSexFemale.Ripple = true;
            this.stdSexFemale.Size = new System.Drawing.Size(74, 30);
            this.stdSexFemale.TabIndex = 1;
            this.stdSexFemale.TabStop = true;
            this.stdSexFemale.Text = "Female";
            this.stdSexFemale.UseVisualStyleBackColor = true;
            // 
            // stdSexMale
            // 
            this.stdSexMale.AutoSize = true;
            this.stdSexMale.Depth = 0;
            this.stdSexMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.stdSexMale.Location = new System.Drawing.Point(18, 20);
            this.stdSexMale.Margin = new System.Windows.Forms.Padding(0);
            this.stdSexMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.stdSexMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdSexMale.Name = "stdSexMale";
            this.stdSexMale.Ripple = true;
            this.stdSexMale.Size = new System.Drawing.Size(59, 30);
            this.stdSexMale.TabIndex = 0;
            this.stdSexMale.TabStop = true;
            this.stdSexMale.Text = "Male";
            this.stdSexMale.UseVisualStyleBackColor = true;
            // 
            // stdCountry
            // 
            this.stdCountry.Depth = 0;
            this.stdCountry.Hint = "Country";
            this.stdCountry.Location = new System.Drawing.Point(294, 137);
            this.stdCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdCountry.Name = "stdCountry";
            this.stdCountry.PasswordChar = '\0';
            this.stdCountry.SelectedText = "";
            this.stdCountry.SelectionLength = 0;
            this.stdCountry.SelectionStart = 0;
            this.stdCountry.Size = new System.Drawing.Size(144, 23);
            this.stdCountry.TabIndex = 6;
            this.stdCountry.UseSystemPasswordChar = false;
            // 
            // stdDOB
            // 
            this.stdDOB.CustomFormat = "yyyy-MM-dd";
            this.stdDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stdDOB.Location = new System.Drawing.Point(58, 57);
            this.stdDOB.Name = "stdDOB";
            this.stdDOB.Size = new System.Drawing.Size(85, 20);
            this.stdDOB.TabIndex = 5;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(2, 57);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "D.O.B:";
            // 
            // stdLname
            // 
            this.stdLname.Depth = 0;
            this.stdLname.Hint = "Last Name";
            this.stdLname.Location = new System.Drawing.Point(294, 24);
            this.stdLname.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdLname.Name = "stdLname";
            this.stdLname.PasswordChar = '\0';
            this.stdLname.SelectedText = "";
            this.stdLname.SelectionLength = 0;
            this.stdLname.SelectionStart = 0;
            this.stdLname.Size = new System.Drawing.Size(245, 23);
            this.stdLname.TabIndex = 3;
            this.stdLname.UseSystemPasswordChar = false;
            // 
            // stdFname
            // 
            this.stdFname.Depth = 0;
            this.stdFname.Hint = "First Name";
            this.stdFname.Location = new System.Drawing.Point(8, 24);
            this.stdFname.MouseState = MaterialSkin.MouseState.HOVER;
            this.stdFname.Name = "stdFname";
            this.stdFname.PasswordChar = '\0';
            this.stdFname.SelectedText = "";
            this.stdFname.SelectionLength = 0;
            this.stdFname.SelectionStart = 0;
            this.stdFname.Size = new System.Drawing.Size(267, 23);
            this.stdFname.TabIndex = 1;
            this.stdFname.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.check);
            this.groupBox2.Controls.Add(this.nokLname);
            this.groupBox2.Controls.Add(this.nokStdEmail);
            this.groupBox2.Controls.Add(this.materialLabel);
            this.groupBox2.Controls.Add(this.nokStdRelationship);
            this.groupBox2.Controls.Add(this.nokStdMobile);
            this.groupBox2.Controls.Add(this.nokFname);
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Next of Kin";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(305, 85);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(0, 13);
            this.check.TabIndex = 6;
            // 
            // nokLname
            // 
            this.nokLname.Depth = 0;
            this.nokLname.Hint = "Last Name";
            this.nokLname.Location = new System.Drawing.Point(294, 21);
            this.nokLname.MouseState = MaterialSkin.MouseState.HOVER;
            this.nokLname.Name = "nokLname";
            this.nokLname.PasswordChar = '\0';
            this.nokLname.SelectedText = "";
            this.nokLname.SelectionLength = 0;
            this.nokLname.SelectionStart = 0;
            this.nokLname.Size = new System.Drawing.Size(266, 23);
            this.nokLname.TabIndex = 5;
            this.nokLname.UseSystemPasswordChar = false;
            // 
            // nokStdEmail
            // 
            this.nokStdEmail.Depth = 0;
            this.nokStdEmail.Hint = "E-Mail";
            this.nokStdEmail.Location = new System.Drawing.Point(294, 50);
            this.nokStdEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.nokStdEmail.Name = "nokStdEmail";
            this.nokStdEmail.PasswordChar = '\0';
            this.nokStdEmail.SelectedText = "";
            this.nokStdEmail.SelectionLength = 0;
            this.nokStdEmail.SelectionStart = 0;
            this.nokStdEmail.Size = new System.Drawing.Size(241, 23);
            this.nokStdEmail.TabIndex = 4;
            this.nokStdEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Depth = 0;
            this.materialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel.Location = new System.Drawing.Point(1, 80);
            this.materialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(173, 19);
            this.materialLabel.TabIndex = 3;
            this.materialLabel.Text = "Relationship To Student:";
            // 
            // nokStdRelationship
            // 
            this.nokStdRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nokStdRelationship.FormattingEnabled = true;
            this.nokStdRelationship.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Sibling",
            "Other"});
            this.nokStdRelationship.Location = new System.Drawing.Point(180, 77);
            this.nokStdRelationship.Name = "nokStdRelationship";
            this.nokStdRelationship.Size = new System.Drawing.Size(121, 21);
            this.nokStdRelationship.TabIndex = 2;
            // 
            // nokStdMobile
            // 
            this.nokStdMobile.Depth = 0;
            this.nokStdMobile.Hint = "Mobile Number";
            this.nokStdMobile.Location = new System.Drawing.Point(7, 50);
            this.nokStdMobile.MouseState = MaterialSkin.MouseState.HOVER;
            this.nokStdMobile.Name = "nokStdMobile";
            this.nokStdMobile.PasswordChar = '\0';
            this.nokStdMobile.SelectedText = "";
            this.nokStdMobile.SelectionLength = 0;
            this.nokStdMobile.SelectionStart = 0;
            this.nokStdMobile.Size = new System.Drawing.Size(193, 23);
            this.nokStdMobile.TabIndex = 1;
            this.nokStdMobile.UseSystemPasswordChar = false;
            // 
            // nokFname
            // 
            this.nokFname.Depth = 0;
            this.nokFname.Hint = "First Name";
            this.nokFname.Location = new System.Drawing.Point(7, 21);
            this.nokFname.MouseState = MaterialSkin.MouseState.HOVER;
            this.nokFname.Name = "nokFname";
            this.nokFname.PasswordChar = '\0';
            this.nokFname.SelectedText = "";
            this.nokFname.SelectionLength = 0;
            this.nokFname.SelectionStart = 0;
            this.nokFname.Size = new System.Drawing.Size(266, 23);
            this.nokFname.TabIndex = 0;
            this.nokFname.UseSystemPasswordChar = false;
            // 
            // addStdBtn
            // 
            this.addStdBtn.AutoSize = true;
            this.addStdBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addStdBtn.Depth = 0;
            this.addStdBtn.Location = new System.Drawing.Point(239, 486);
            this.addStdBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addStdBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addStdBtn.Name = "addStdBtn";
            this.addStdBtn.Primary = false;
            this.addStdBtn.Size = new System.Drawing.Size(103, 36);
            this.addStdBtn.TabIndex = 3;
            this.addStdBtn.Text = "ADD STUDENT";
            this.addStdBtn.UseVisualStyleBackColor = true;
            this.addStdBtn.Click += new System.EventHandler(this.addStdBtn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 505);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(221, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "MATRIC NUMBER: 19CG026475";
            // 
            // newStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 533);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.addStdBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newStud";
            this.Text = "New Student Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField stdLname;
        private MaterialSkin.Controls.MaterialSingleLineTextField stdFname;
        private System.Windows.Forms.DateTimePicker stdDOB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialSingleLineTextField stdMobile;
        private MaterialSkin.Controls.MaterialSingleLineTextField stdAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField stdEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRadioButton stdSexFemale;
        private MaterialSkin.Controls.MaterialRadioButton stdSexMale;
        private MaterialSkin.Controls.MaterialSingleLineTextField stdCountry;
        private System.Windows.Forms.ComboBox nokStdRelationship;
        private MaterialSkin.Controls.MaterialSingleLineTextField nokStdMobile;
        private MaterialSkin.Controls.MaterialSingleLineTextField nokFname;
        private MaterialSkin.Controls.MaterialSingleLineTextField nokLname;
        private MaterialSkin.Controls.MaterialSingleLineTextField nokStdEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField stdState;
        private System.Windows.Forms.ComboBox stdClass;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton addStdBtn;
        private System.Windows.Forms.Label check;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}