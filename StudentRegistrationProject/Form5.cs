using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class adminChangPassword : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=schooldata;User Id=root;password='';SSL Mode=None");
        int i;
        public adminChangPassword()
        {
            InitializeComponent();
        }

        private void chngPassBtn_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM admin_login WHERE username = '" + adminLogin.welcomeUser + "' and password = '" + currentPass.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Invalid Password......Please Try Again.");
            }
            else
            {
                if(newPass.Text == confirmNewPass.Text)
                {
                    string sqlQuery = "UPDATE admin_login SET password = '" + newPass.Text + "' WHERE username = '" + adminLogin.welcomeUser + "'";
                    MySqlCommand command = new MySqlCommand(sqlQuery, con);
                    MySqlDataAdapter sda = new MySqlDataAdapter(command);
                    DataTable dt2 = new DataTable();
                    da.Fill(dt2);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Password Changed Successfully.");
                }
                else
                {
                    MessageBox.Show("Password does not match.");
                }
            }
            con.Close();
        }
    }
}
