
namespace StudentRegistrationProject
{
    partial class adminChangPassword
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
            this.currentPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.newPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.confirmNewPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chngPassBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // currentPass
            // 
            this.currentPass.Depth = 0;
            this.currentPass.Hint = "Current Password";
            this.currentPass.Location = new System.Drawing.Point(114, 145);
            this.currentPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.currentPass.Name = "currentPass";
            this.currentPass.PasswordChar = '\0';
            this.currentPass.SelectedText = "";
            this.currentPass.SelectionLength = 0;
            this.currentPass.SelectionStart = 0;
            this.currentPass.Size = new System.Drawing.Size(172, 23);
            this.currentPass.TabIndex = 0;
            this.currentPass.UseSystemPasswordChar = true;
            // 
            // newPass
            // 
            this.newPass.Depth = 0;
            this.newPass.Hint = "New Password";
            this.newPass.Location = new System.Drawing.Point(114, 174);
            this.newPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '\0';
            this.newPass.SelectedText = "";
            this.newPass.SelectionLength = 0;
            this.newPass.SelectionStart = 0;
            this.newPass.Size = new System.Drawing.Size(172, 23);
            this.newPass.TabIndex = 1;
            this.newPass.UseSystemPasswordChar = true;
            // 
            // confirmNewPass
            // 
            this.confirmNewPass.Depth = 0;
            this.confirmNewPass.Hint = "Confirm New Password";
            this.confirmNewPass.Location = new System.Drawing.Point(114, 203);
            this.confirmNewPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmNewPass.Name = "confirmNewPass";
            this.confirmNewPass.PasswordChar = '\0';
            this.confirmNewPass.SelectedText = "";
            this.confirmNewPass.SelectionLength = 0;
            this.confirmNewPass.SelectionStart = 0;
            this.confirmNewPass.Size = new System.Drawing.Size(172, 23);
            this.confirmNewPass.TabIndex = 2;
            this.confirmNewPass.UseSystemPasswordChar = true;
            // 
            // chngPassBtn
            // 
            this.chngPassBtn.AutoSize = true;
            this.chngPassBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chngPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chngPassBtn.Depth = 0;
            this.chngPassBtn.Location = new System.Drawing.Point(128, 235);
            this.chngPassBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chngPassBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.chngPassBtn.Name = "chngPassBtn";
            this.chngPassBtn.Primary = false;
            this.chngPassBtn.Size = new System.Drawing.Size(144, 36);
            this.chngPassBtn.TabIndex = 3;
            this.chngPassBtn.Text = "Change Password";
            this.chngPassBtn.UseVisualStyleBackColor = false;
            this.chngPassBtn.Click += new System.EventHandler(this.chngPassBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(2, 317);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(221, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "MATRIC NUMBER: 19CG026475";
            // 
            // adminChangPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 345);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.chngPassBtn);
            this.Controls.Add(this.confirmNewPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.currentPass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminChangPassword";
            this.Text = "Admin Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField currentPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField newPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField confirmNewPass;
        private MaterialSkin.Controls.MaterialFlatButton chngPassBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}