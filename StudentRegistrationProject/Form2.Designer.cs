
namespace StudentRegistrationProject
{
    partial class menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mngStdBtn = new System.Windows.Forms.Button();
            this.newStdBtn = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stdRpt = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chgAdmin = new System.Windows.Forms.Button();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.logoutBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mngStdBtn);
            this.panel1.Controls.Add(this.newStdBtn);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(101, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 0;
            // 
            // mngStdBtn
            // 
            this.mngStdBtn.Location = new System.Drawing.Point(103, 32);
            this.mngStdBtn.Name = "mngStdBtn";
            this.mngStdBtn.Size = new System.Drawing.Size(60, 28);
            this.mngStdBtn.TabIndex = 2;
            this.mngStdBtn.Text = "Manage";
            this.mngStdBtn.UseVisualStyleBackColor = true;
            this.mngStdBtn.Click += new System.EventHandler(this.mngStdBtn_Click);
            // 
            // newStdBtn
            // 
            this.newStdBtn.Location = new System.Drawing.Point(31, 32);
            this.newStdBtn.Name = "newStdBtn";
            this.newStdBtn.Size = new System.Drawing.Size(60, 28);
            this.newStdBtn.TabIndex = 1;
            this.newStdBtn.Text = "New";
            this.newStdBtn.UseVisualStyleBackColor = true;
            this.newStdBtn.Click += new System.EventHandler(this.newStdBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 4);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(151, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Student Management";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.stdRpt);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Location = new System.Drawing.Point(490, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 74);
            this.panel3.TabIndex = 1;
            // 
            // stdRpt
            // 
            this.stdRpt.Location = new System.Drawing.Point(67, 26);
            this.stdRpt.Name = "stdRpt";
            this.stdRpt.Size = new System.Drawing.Size(75, 34);
            this.stdRpt.TabIndex = 1;
            this.stdRpt.Text = "Student Report";
            this.stdRpt.UseVisualStyleBackColor = true;
            this.stdRpt.Click += new System.EventHandler(this.stdRpt_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(72, 4);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Reports";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chgAdmin);
            this.panel4.Controls.Add(this.materialLabel4);
            this.panel4.Location = new System.Drawing.Point(294, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 74);
            this.panel4.TabIndex = 1;
            // 
            // chgAdmin
            // 
            this.chgAdmin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.chgAdmin.Location = new System.Drawing.Point(66, 27);
            this.chgAdmin.Name = "chgAdmin";
            this.chgAdmin.Size = new System.Drawing.Size(75, 38);
            this.chgAdmin.TabIndex = 1;
            this.chgAdmin.Text = "Change Password";
            this.chgAdmin.UseVisualStyleBackColor = true;
            this.chgAdmin.Click += new System.EventHandler(this.chgAdmin_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(33, 4);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(143, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Admin Management";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Depth = 0;
            this.logoutBtn.Location = new System.Drawing.Point(358, 393);
            this.logoutBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Primary = true;
            this.logoutBtn.Size = new System.Drawing.Size(84, 33);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "LOG OUT";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 422);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(221, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "MATRIC NUMBER: 19CG026475";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mngStdBtn;
        private System.Windows.Forms.Button newStdBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button stdRpt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button chgAdmin;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton logoutBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}