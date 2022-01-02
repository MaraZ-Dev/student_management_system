
namespace StudentRegistrationProject
{
    partial class adminLogin
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
            this.components = new System.ComponentModel.Container();
            this.userBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Depth = 0;
            this.userBox.Font = new System.Drawing.Font("SketchFlow Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Hint = "Username";
            this.userBox.Location = new System.Drawing.Point(280, 253);
            this.userBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.userBox.Name = "userBox";
            this.userBox.PasswordChar = '\0';
            this.userBox.SelectedText = "";
            this.userBox.SelectionLength = 0;
            this.userBox.SelectionStart = 0;
            this.userBox.Size = new System.Drawing.Size(130, 23);
            this.userBox.TabIndex = 2;
            this.userBox.UseSystemPasswordChar = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Depth = 0;
            this.passwordBox.Font = new System.Drawing.Font("SketchFlow Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Hint = "Password";
            this.passwordBox.Location = new System.Drawing.Point(280, 282);
            this.passwordBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.Size = new System.Drawing.Size(130, 23);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginBtn.Depth = 0;
            this.loginBtn.Location = new System.Drawing.Point(297, 311);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Primary = true;
            this.loginBtn.Size = new System.Drawing.Size(99, 31);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::StudentRegistrationProject.Properties.Resources.adminEdit2;
            this.pictureBox1.Location = new System.Drawing.Point(272, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(0, 432);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(221, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "MATRIC NUMBER: 19CG026475";
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 460);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userBox);
            this.Name = "adminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField userBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordBox;
        private MaterialSkin.Controls.MaterialRaisedButton loginBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

