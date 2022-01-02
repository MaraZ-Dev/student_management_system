
namespace StudentRegistrationProject
{
    partial class stdReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataStdReport = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataStdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStdReport
            // 
            this.dataStdReport.AllowUserToAddRows = false;
            this.dataStdReport.AllowUserToDeleteRows = false;
            this.dataStdReport.AllowUserToResizeColumns = false;
            this.dataStdReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataStdReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStdReport.BackgroundColor = System.Drawing.Color.White;
            this.dataStdReport.ColumnHeadersHeight = 24;
            this.dataStdReport.GridColor = System.Drawing.Color.White;
            this.dataStdReport.Location = new System.Drawing.Point(9, 70);
            this.dataStdReport.Name = "dataStdReport";
            this.dataStdReport.ReadOnly = true;
            this.dataStdReport.RowHeadersVisible = false;
            this.dataStdReport.RowTemplate.Height = 40;
            this.dataStdReport.Size = new System.Drawing.Size(1110, 524);
            this.dataStdReport.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 612);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(221, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "MATRIC NUMBER: 19CG026475";
            // 
            // stdReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 640);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataStdReport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stdReport";
            this.Text = "Student Report";
            this.Load += new System.EventHandler(this.stdReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStdReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStdReport;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}