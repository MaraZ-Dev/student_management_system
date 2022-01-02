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
    public partial class adminLogin : MaterialSkin.Controls.MaterialForm
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=schooldata;User Id=root;password='';SSL Mode=None");
        int i;
        
        public adminLogin()
        {
            InitializeComponent();
        }
        public static string welcomeUser = "";
        private void loginBtn_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM admin_login WHERE username = '"+userBox.Text+"' and password = '"+passwordBox.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if(i == 0 || userBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Invalid Username or Password");
            }
            else
            {
                welcomeUser = userBox.Text;
                this.Hide();
                menu obj = new menu();
                obj.Show();
            }

            con.Close();
        }

    }
}
