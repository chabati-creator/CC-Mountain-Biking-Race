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
using System.Text.RegularExpressions;
//using MySql.Data.MySqlClient;

namespace CC_Mountain_Biking_Race
{
    public partial class DBAddRider : Form
    {
        private static int riderID = -1;

        SqlConnection connection;
        string connectionString;

        public DBAddRider()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CC_Mountain_Biking_Race.Properties.Settings.CCMountainBikingDBConnectionString"].ConnectionString;

            //Listview Properties
            lvRiderDetails.View = View.Details;
            lvRiderDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add Columns
            lvRiderDetails.Columns.Add("Name");
            lvRiderDetails.Columns.Add("Surname", 75);
            lvRiderDetails.Columns.Add("Age", 50);
            lvRiderDetails.Columns.Add("School", 75);
            lvRiderDetails.Columns.Add("Leg 1", 80);
            lvRiderDetails.Columns.Add("Leg 2", 80);
            lvRiderDetails.Columns.Add("Leg 3", 80);
            lvRiderDetails.Columns.Add("Leg 4", 80);

        }
        
        private void CCMountainBikingRaceDB_Load(object sender, EventArgs e)
        {
            PopulateRiders();
        }

        private void PopulateRiders()
        {
            lvRiderDetails.Items.Clear();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM RiderDetails", connection))
            {
                DataTable riderDetailsTable = new DataTable();
                adapter.Fill(riderDetailsTable);

                //Loop through the DataTable.
                foreach (DataRow row in riderDetailsTable.Rows)
                {
                    //Add Item to ListView.
                    ListViewItem item = new ListViewItem(row[1].ToString());
                    item.SubItems.Add(row[2].ToString());
                    item.SubItems.Add(row[3].ToString());
                    item.SubItems.Add(row[4].ToString());
                    item.SubItems.Add(row[5].ToString());
                    item.SubItems.Add(row[6].ToString());
                    item.SubItems.Add(row[7].ToString());
                    item.SubItems.Add(row[8].ToString());
                    lvRiderDetails.Items.Add(item);
                }

                //lvRiderDetails.View = View.List;

            }
            connection.Close();
        }

        //When checking if a rider has been added (data inserted), rider updated or deleted then check using Bin/Debug SQLQuery as the Program.exe runs in Debug folder
        //Work on this one using the YT tutorial
        //Create another form for Add Rider Times and a form for category-filter search
        private void btnAddRider_Click(object sender, EventArgs e)
        {

            if (txbName.Text == "" || !Regex.IsMatch(txbName.Text, @"^[a-zA-Z]+$")) //If the Name textbox is blank then do the following
            {
                txbName.BackColor = Color.LightPink; //The background colour would change to light pink
                string Caption = "Error";
                string Message = "The Name textbox cannot be empty and contain integers. Please enter the rider's name";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //Displays the MessageBox showing an error message informing the user that the name textbox is blank 
                result = MessageBox.Show(Message, Caption, buttons);
                txbName.Focus();
            }
            else
            {
                txbName.BackColor = Color.SeaShell; //Will change the backgroud colour back to white when input is valid (textbox not blank)
            }

            if (txbSurname.Text == "" || !Regex.IsMatch(txbSurname.Text, @"^[a-zA-Z]+$"))
            {
                txbSurname.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "The Surname textbox cannot be empty and contain integers. Please enter the rider's surname";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(Message, Caption, buttons);
                txbSurname.Focus();
            }
            else
                txbSurname.BackColor = Color.SeaShell;
            if (txbSchool.Text == "" || !Regex.IsMatch(txbSchool.Text, @"^[a-zA-Z]+$"))
            {
                txbSchool.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "The School textbox cannot be empty and contain integers. Please enter the rider's school";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(Message, Caption, buttons);
                txbSchool.Focus();
            }
            else
                txbSchool.BackColor = Color.SeaShell;
            if (!chbLeg1.Checked && !chbLeg2.Checked && !chbLeg3.Checked && !chbLeg4.Checked)
            {
                chbLeg1.BackColor = Color.LightPink;
                chbLeg2.BackColor = Color.LightPink;
                chbLeg3.BackColor = Color.LightPink;
                chbLeg4.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "All checkboxes are unselected. Please select the legs the rider is entering in";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(Message, Caption, buttons);
            }
            else
            {
                chbLeg1.BackColor = Color.SeaShell;
                chbLeg2.BackColor = Color.SeaShell;
                chbLeg3.BackColor = Color.SeaShell;
                chbLeg4.BackColor = Color.SeaShell;
            }

            //string query = "INSERT INTO RiderDetails (FirstName,Surname,Age,School,[Leg 1],[Leg 2],[Leg 3],[Leg 4]) VALUES (@RiderName, 'BB', 15, 'HBC',0,1,-1,3)";
            string query = "INSERT INTO RiderDetails VALUES ('"+this.txbName.Text+"','"+this.txbSurname.Text+"',@RiderAge,'"+this.txbSchool.Text+"',@Leg1,@Leg2,@Leg3,@Leg4)";

            if (txbName.Text != "" && Regex.IsMatch(txbName.Text, @"^[a-zA-Z]+$")
                && txbSurname.Text != "" && Regex.IsMatch(txbSurname.Text, @"^[a-zA-Z]+$")
                && txbSchool.Text != "" && Regex.IsMatch(txbSchool.Text, @"^[a-zA-Z]+$")
                && chbLeg1.Checked || chbLeg2.Checked || chbLeg3.Checked || chbLeg4.Checked)
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    //command.Parameters.AddWithValue("@RiderName", txbName.Text);
                    command.Parameters.AddWithValue("@RiderAge", nudAge.Value);

                    //Note that '0' is false (Not Entered) and '1' is true (Entered)
                    command.Parameters.AddWithValue("@Leg1", chbLeg1.Checked);
                    command.Parameters.AddWithValue("@Leg2", chbLeg2.Checked);
                    command.Parameters.AddWithValue("@Leg3", chbLeg3.Checked);
                    command.Parameters.AddWithValue("@Leg4", chbLeg4.Checked);

                    //command.Parameters.AddWithValue("@RiderLeg 1", chlbx.);
                    //MessageBox.Show(query);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            PopulateRiders();
        }

        private void btnUpdateRiderName_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "" || !Regex.IsMatch(txbName.Text, @"^[a-zA-Z]+$")) //If the Name textbox is blank then do the following
            {
                txbName.BackColor = Color.LightPink; //The background colour would change to light pink
                string Caption = "Error";
                string Message = "The Name textbox cannot be empty and contain integers. Please enter the rider's name";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //Displays the MessageBox showing an error message informing the user that the name textbox is blank 
                result = MessageBox.Show(Message, Caption, buttons);
                txbName.Focus();
            }
            else
            {
                txbName.BackColor = Color.SeaShell; //Will change the backgroud colour back to white when input is valid (textbox not blank)
            }

            if (txbSurname.Text == "" || !Regex.IsMatch(txbSurname.Text, @"^[a-zA-Z]+$"))
            {
                txbSurname.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "The Surname textbox cannot be empty and contain integers. Please enter the rider's surname";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(Message, Caption, buttons);
                txbSurname.Focus();
            }
            else
                txbSurname.BackColor = Color.SeaShell;
            if (txbSchool.Text == "" || !Regex.IsMatch(txbSchool.Text, @"^[a-zA-Z]+$"))
            {
                txbSchool.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "The School textbox cannot be empty and contain integers. Please enter the rider's school";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(Message, Caption, buttons);
                txbSchool.Focus();
            }
            else
                txbSchool.BackColor = Color.SeaShell;
            if (!chbLeg1.Checked && !chbLeg2.Checked && !chbLeg3.Checked && !chbLeg4.Checked)
            {
                chbLeg1.BackColor = Color.LightPink;
                chbLeg2.BackColor = Color.LightPink;
                chbLeg3.BackColor = Color.LightPink;
                chbLeg4.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "All checkboxes are unselected. Please select the legs the rider is entering in";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(Message, Caption, buttons);
            }
            else
            {
                chbLeg1.BackColor = Color.SeaShell;
                chbLeg2.BackColor = Color.SeaShell;
                chbLeg3.BackColor = Color.SeaShell;
                chbLeg4.BackColor = Color.SeaShell;
            }


            string query1 = "UPDATE RiderDetails SET FirstName = @RiderName WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query1, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderName", txbName.Text);
                command.Parameters.AddWithValue("@RiderId", riderID);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query2 = "UPDATE RiderDetails SET Surname = @RiderSurname WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderSurname", txbSurname.Text);
                command.Parameters.AddWithValue("@RiderId", riderID);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query3 = "UPDATE RiderDetails SET Age = @RiderAge WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query3, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderAge", nudAge.Value);
                command.Parameters.AddWithValue("@RiderId", riderID);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query4 = "UPDATE RiderDetails SET School = @RiderSchool WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query4, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderSchool", txbSchool.Text);
                command.Parameters.AddWithValue("@RiderId", riderID);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query5 = "UPDATE RiderDetails SET [Leg 1] = @Leg1 WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query5, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Leg1", chbLeg1.Checked);
                command.Parameters.AddWithValue("@RiderId", riderID);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query6 = "UPDATE RiderDetails SET [Leg 2] = @Leg2 WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query6, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Leg2", chbLeg2.Checked);
                command.Parameters.AddWithValue("@RiderId", riderID);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query7 = "UPDATE RiderDetails SET [Leg 3] = @Leg3 WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query7, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Leg3", chbLeg3.Checked);
                command.Parameters.AddWithValue("@RiderId", riderID);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query8 = "UPDATE RiderDetails SET [Leg 4] = @Leg4 WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query8, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Leg4", chbLeg4.Checked);
                command.Parameters.AddWithValue("@RiderId", riderID);
                command.ExecuteNonQuery();
                connection.Close();
            }

            PopulateRiders();
        }

        //Create 4 of these; SELECT then DELETE from joining table then DELETE RiderTimes table, and RiderDetails table
        //This is because it can only run 1 query at a time not multiple
        //Declare an int variable to store the RiderTimes id to be used later
        
        private void btnDeleteRider_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT TimesID FROM DetailsTimes " +
                           "WHERE RiderId = @RiderId ";
            int TimesId;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query1, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderId", riderID);
                //MessageBox.Show(""+riderID);
                TimesId = (int)command.ExecuteScalar();
                //MessageBox.Show("" + TimesId);
                connection.Close();
            }

            string query2 = "DELETE FROM DetailsTimes " +
                          "WHERE RiderId = @RiderId ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderId", riderID);
                //MessageBox.Show(query2);
                command.ExecuteScalar();
                connection.Close();
            }

            string query3 = "DELETE FROM RiderTimes " +
                          "WHERE Id = @TimesId ";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query3, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("TimesId", TimesId);
                //MessageBox.Show(query3);
                command.ExecuteScalar();
                connection.Close();
            }

            string query4 = "DELETE FROM RiderDetails " +
                          "WHERE Id = @RiderId ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query4, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderId", riderID);
                //MessageBox.Show(query4);
                command.ExecuteScalar();
                connection.Close();
            }

            PopulateRiders();
        }

        private void btnAddRiderTimes_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //AddRider screen closes
            DBAddRiderTimes window = new DBAddRiderTimes();  //AddRiderTimes screen opens
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void lvRiderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            riderID = (lvRiderDetails.FocusedItem.Index + 1);
            //MessageBox.Show(""+riderID);   
        }

        private void btnFilterRiders_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //AddRider screen closes
            DBFilterRiders window = new DBFilterRiders();  //FilterSearch screen opens
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
