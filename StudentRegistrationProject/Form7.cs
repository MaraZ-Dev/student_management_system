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
    public partial class manageStd : MaterialSkin.Controls.MaterialForm
    {
        string connectionString = (@"Data Source=localhost;port=3306;Initial Catalog=schooldata;User Id=root;password='';SSL Mode=None");
        public manageStd()
        {
            InitializeComponent();
        }
        public DataTable getStdResult()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM student", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void showStudentReport()
        {
            resultView.DataSource = getStdResult();
            resultView.RowTemplate.Height = 50;
        }

        private void resultView_Click(object sender, EventArgs e)
        {
            stdId.Text = resultView.CurrentRow.Cells[0].Value.ToString(); 
            stdFname.Text = resultView.CurrentRow.Cells[1].Value.ToString();
            stdLname.Text = resultView.CurrentRow.Cells[2].Value.ToString();
            //DateTime dateTime = (DateTime)resultView.CurrentRow.Cells[3].Value;
            //stdDOB.Value = dateTime;
            if (resultView.CurrentRow.Cells[4].Value.ToString() == "Male")
            {
                stdSexMale.Checked = true;
            }
            else
            {
                stdSexFemale.Checked = true;
            }
            stdClass.SelectedItem = resultView.CurrentRow.Cells[5].Value.ToString();
            stdState.Text = resultView.CurrentRow.Cells[6].Value.ToString();
            stdCountry.Text = resultView.CurrentRow.Cells[7].Value.ToString();
            stdAddress.Text = resultView.CurrentRow.Cells[8].Value.ToString();
            stdMobile.Text = resultView.CurrentRow.Cells[9].Value.ToString();
            stdEmail.Text = resultView.CurrentRow.Cells[10].Value.ToString();

        }

        private void manageStd_Load(object sender, EventArgs e)
        {
            showStudentReport();
        }

        private void updateStdBtn_Click(object sender, EventArgs e)
        {
            int stud_ID = int.Parse(stdId.Text);
            string fname = stdFname.Text;
            string lname = stdLname.Text;
            string state = stdState.Text;
            string country = stdCountry.Text;
            string address = stdAddress.Text;
            string email = stdEmail.Text;
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
            string query = "UPDATE `student` SET `firstName`='"+fname+ "',`lastName`='" + lname + "',`dob_final`='" + dobFinal + "',`gender`='" + sex + "',`class`='" + stdClass + "',`state`='" + state + "',`country`='" + country + "',`address`='" + address + "',`mobile`='" + mobile + "',`email`='" + email + "' WHERE stdId = '"+ stud_ID +"'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = cmd.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Student Data Updated Successfully.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

       
    }
}
