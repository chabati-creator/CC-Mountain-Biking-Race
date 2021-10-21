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
//using MySql.Data.MySqlClient;

namespace CC_Mountain_Biking_Race
{
    public partial class CCMountainBikingRaceDB : Form
    {
        private DataTable dt;
        private DataView dv;

        SqlConnection connection;
        string connectionString;

        public CCMountainBikingRaceDB()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CC_Mountain_Biking_Race.Properties.Settings.CCMountainBikingDBConnectionString"].ConnectionString;

            //Listview Properties
            lstvRiderDetails.View = View.Details;
            lstvRiderDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add Columns
            lstvRiderDetails.Columns.Add("ID");
            lstvRiderDetails.Columns.Add("Name");
            lstvRiderDetails.Columns.Add("Surname", 75);
            lstvRiderDetails.Columns.Add("Age", 50);
            lstvRiderDetails.Columns.Add("School", 75);
            lstvRiderDetails.Columns.Add("Leg 1", 80);
            lstvRiderDetails.Columns.Add("Leg 2", 80);
            lstvRiderDetails.Columns.Add("Leg 3", 80);
            lstvRiderDetails.Columns.Add("Leg 4", 80);

            //Initialise Datatable and add Columns
            //dt = new DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Surname");
            //dt.Columns.Add("Age");
            //dt.Columns.Add("School");
            //dt.Columns.Add("Leg 1");
            //dt.Columns.Add("Leg 2");
            //dt.Columns.Add("Leg 3");
            //dt.Columns.Add("Leg 4");

            //Getting DataList from RiderDetails Database
            //dt.Rows.Add(rider.GetRiderID(), rider.GetName(), rider.GetSurname(), rider.GetAge(), rider.GetSchool(), entryStatus[0], entryStatus[1], entryStatus[2], entryStatus[3]);


            //Fill Datatable
            //dv = new DataView(dt);

            //PopulateListView(dv);
        }

        //Fill Listview from dataviwew
        //private void PopulateListView(DataView dv)
        //{
        //    lstRiderDetails.Items.Clear();
        //    foreach (DataRow row in dv.ToTable().Rows)
        //    {
        //        lstRiderDetails.Items.Add(new ListViewItem(new String[] {row[0].ToString(), row[1].ToString(), row[2].ToString(),
        //            row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString()}));
        //    }

        //}

        private void CCMountainBikingRaceDB_Load(object sender, EventArgs e)
        {
            PopulateRiders();
        }

        //private void PopulateRiders()
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM RiderDetails", connection))
        //    {
        //        DataTable riderDetailsTable = new DataTable();
        //        adapter.Fill(lstvRiderDetails);


        //    }
        //    connection.Close();
        //}

        private void PopulateRiders()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM RiderDetails", connection))
            {
                DataTable riderDetailsTable = new DataTable();
                adapter.Fill(riderDetailsTable);

                lstRiderDetails.DisplayMember = "FirstName";
                lstRiderDetails.ValueMember = "Id";
                lstRiderDetails.DataSource = riderDetailsTable;
            }
            connection.Close();
        }

        //When checking if a rider has been added (data inserted), rider updated or deleted then check using Bin/Debug SQLQuery as the Program.exe runs in Debug folder
        //Work on this one using the YT tutorial
        //Create another form for Add Rider Times and a form for category-filter search
        private void btnAddRider_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO RiderDetails (FirstName,Surname,Age,School,[Leg 1],[Leg 2],[Leg 3],[Leg 4]) VALUES (@RiderName, 'BB', 15, 'HBC',0,1,-1,3)";
            string query = "INSERT INTO RiderDetails VALUES ('"+this.txbName.Text+"','"+this.txbSurname.Text+"',@RiderAge,'"+this.txbSchool.Text+"',@Leg1,@Leg2,@Leg3,@Leg4)";
            

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
                MessageBox.Show(query);
                command.ExecuteNonQuery();
                connection.Close();
            }

            PopulateRiders();
        }

        private void btnUpdateRiderName_Click(object sender, EventArgs e)
        {
            string query1 = "UPDATE RiderDetails SET FirstName = @RiderName WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query1, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderName", txbName.Text);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query2 = "UPDATE RiderDetails SET Surname = @RiderSurname WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderSurname", txbSurname.Text);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query3 = "UPDATE RiderDetails SET Age = @RiderAge WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query3, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderAge", nudAge.Value);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query4 = "UPDATE RiderDetails SET School = @RiderSchool WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query4, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderSchool", txbSchool.Text);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query5 = "UPDATE RiderDetails SET [Leg 1] = @Leg1 WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query5, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Leg1", chbLeg1.Checked);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query6 = "UPDATE RiderDetails SET [Leg 2] = @Leg2 WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query6, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Leg2", chbLeg2.Checked);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query7 = "UPDATE RiderDetails SET [Leg 3] = @Leg3 WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query7, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Leg3", chbLeg3.Checked);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            string query8 = "UPDATE RiderDetails SET [Leg 4] = @Leg4 WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query8, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Leg4", chbLeg4.Checked);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
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

                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
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

                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
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

                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                //MessageBox.Show(query4);
                command.ExecuteScalar();
                connection.Close();
            }

            PopulateRiders();
        }

        private void btnAddRiderTimes_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //AddRider screen closes
            CCMountainBikingRaceDBAddRiderTimes window = new CCMountainBikingRaceDBAddRiderTimes();  //AddRiderTimes screen opens passing the ...
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
