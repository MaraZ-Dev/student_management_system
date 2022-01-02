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
    public partial class newStud : MaterialSkin.Controls.MaterialForm
    {
        public newStud()
        {
            InitializeComponent();
        }

        private void addStdBtn_Click(object sender, EventArgs e)
        {
            // Declaring the Variables
            string fname = stdFname.Text;
            string lname = stdLname.Text;
            string state = stdState.Text;
            string country = stdCountry.Text;
            string address = stdAddress.Text;
            string email  = stdEmail.Text;
            string mobile = stdMobile.Text;
            string stdClass = this.stdClass.SelectedItem.ToString();
            string sex;
            if (stdSexMale.Checked == true)
            {
                sex = stdSexMale.Text;
            }
            else
            {
                sex = stdSexFemale.Text;
            }
            DateTime dob = stdDOB.Value;
            string dobFinal = dob.ToString("yyyy-MM-dd");
            // Connection...
            string connectionString = (@"Data Source=localhost;port=3306;Initial Catalog=schooldata;User Id=root;password='';SSL Mode=None");
            string query = "INSERT INTO student VALUES('','" + fname + "', '" + lname + "', '" + dobFinal + "' , '" + sex + "' , '" + stdClass + "' , '" + state + "' , '" + country + "' , '" + address + "' , '" + mobile + "' , '" + email + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = cmd.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Student Added Successfully.");
                stdFname.Clear();
                stdLname.Clear();
                stdCountry.Clear();
                stdAddress.Clear();
                stdEmail.Clear();
                stdMobile.Clear();
                stdState.Clear();
                nokFname.Clear();
                nokLname.Clear();
                nokStdEmail.Clear();
                nokStdMobile.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
