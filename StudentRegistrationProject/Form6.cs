using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationProject
{
    public partial class stdReport : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=schooldata;username=root;password='';SSL Mode=None");
        public DataTable getStdReport()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM student", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void showStudentReport()
        {
            dataStdReport.DataSource = getStdReport();
            dataStdReport.RowTemplate.Height = 50;
        }
        public stdReport()
        {
            InitializeComponent();
        }

        private void stdReport_Load(object sender, EventArgs e)
        {
            showStudentReport();
        }

        
    }
}
