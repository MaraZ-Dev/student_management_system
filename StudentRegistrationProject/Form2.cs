using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentRegistrationProject
{
    public partial class menu : MaterialSkin.Controls.MaterialForm
    {
        
        public menu()
        {
            InitializeComponent();
        }

        private void newStdBtn_Click(object sender, EventArgs e)
        {
            newStud obj = new newStud();
            obj.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin logout = new adminLogin();
            logout.Show();

        }

        private void chgAdmin_Click(object sender, EventArgs e)
        {
            adminChangPassword adminChangePassword = new adminChangPassword();
            adminChangePassword.Show();
        }

        private void stdRpt_Click(object sender, EventArgs e)
        {
            stdReport report = new stdReport();
            report.Show();
        }

        private void mngStdBtn_Click(object sender, EventArgs e)
        {
            manageStd search = new manageStd();
            search.Show();
        }
    }
}
