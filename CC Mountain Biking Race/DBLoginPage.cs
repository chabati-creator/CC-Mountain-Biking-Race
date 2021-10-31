using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CC_Mountain_Biking_Race
{
    public partial class DBLoginPage : Form
    {

        SqlConnection connection;
        string connectionString;

        public DBLoginPage()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CC_Mountain_Biking_Race.Properties.Settings.CCMountainBikingDBConnectionString"].ConnectionString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string query = "SELECT COUNT(*) FROM Login " +
                           "WHERE Password = @Password AND Username = @Username";
            int count;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Password", txbPassword.Text);
                command.Parameters.AddWithValue("@Username", txbUsername.Text);
                count = (int)command.ExecuteScalar();

                if (count == 1)
                {
                    txbUsername.BackColor = Color.SeaShell;
                    txbPassword.BackColor = Color.SeaShell;
                    MessageBox.Show("Login Successful");

                    this.Hide();                                          //LoginPage form closes
                    DBAddRider window = new DBAddRider();  //AddRider form opens
                    window.FormClosed += (s, args) => this.Close();
                    window.Show();
                }
                else
                {
                    txbUsername.BackColor = Color.LightPink;
                    txbPassword.BackColor = Color.LightPink;
                    MessageBox.Show("Login Failed: " + "\n" +
                        "The username or password that you have entered is incorrect. \n" +
                        "Please enter the correct username or password.");
                }
                connection.Close();
            }
        }
    }
}
