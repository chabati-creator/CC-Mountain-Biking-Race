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
        SqlConnection connection;
        string connectionString;

        public CCMountainBikingRaceDB()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CC_Mountain_Biking_Race.Properties.Settings.CCMountainBikingDBConnectionString"].ConnectionString;
        }

        private void CCMountainBikingRaceDB_Load(object sender, EventArgs e)
        {
            PopulateRiders();
        }
       
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
        private void PopulateEndTimes()
        {
            string query = "SELECT a.EndTime FROM RiderTimes a " +
                           "INNER JOIN DetailsTimes b ON a.Id = b.TimesId " +
                            "WHERE b.RiderId = @RiderId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);

                DataTable riderTimesTable = new DataTable();
                adapter.Fill(riderTimesTable);

                lstEndTimes.DisplayMember = "EndTime";
                lstEndTimes.ValueMember = "Id";
                lstEndTimes.DataSource = riderTimesTable;
            }
        }
        private void PopulateStartTimes()
        {
            string query = "SELECT a.StartTime FROM RiderTimes a " +
                           "INNER JOIN DetailsTimes b ON a.Id = b.TimesId " +
                            "WHERE b.RiderId = @RiderId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);

                DataTable riderTimesTable = new DataTable();
                adapter.Fill(riderTimesTable);

                lstStartTimes.DisplayMember = "StartTime";
                lstStartTimes.ValueMember = "Id";
                lstStartTimes.DataSource = riderTimesTable;
            }
        }

        private void lstRiderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateEndTimes();
            PopulateStartTimes();
        }
        //When checking if a rider has been added (data inserted), rider updated or deleted then check using Bin/Debug SQLQuery as the Program.exe runs in Debug folder
        //Work on this one using the YT tutorial
        private void btnAddRider_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RiderDetails VALUES (@RiderName, 'BB', 15, 'HBC',0,1,-1,3)";
            //string query = "INSERT INTO RiderDetails (FirstName,Surname,Age,School,[Leg 1],[Leg 2],[Leg 3],[Leg 4]) VALUES ('" + this.txbName.Text+"','"+this.txbSurname.Text+"',15,'"+this.txbSchool.Text+"',0,1,2,3)";
            

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderName", txbName.Text);
                MessageBox.Show(query);
                command.ExecuteNonQuery();
                connection.Close();
            }

            PopulateRiders();
        }

        private void btnUpdateRiderName_Click(object sender, EventArgs e)
        {
            string query = "UPDATE RiderDetails SET Name = @RiderName WHERE Id = @RiderId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderName", txbName.Text);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteScalar();
            }

            PopulateRiders();
        }

        private void btnDeleteRider_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM RiderDetails WHERE Id = @RiderId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);

                command.ExecuteScalar();
            }

            PopulateRiders();
        }

        private void btnAddEndTime_Click(object sender, EventArgs e)
        {
        //    string query = "INSERT INTO RiderTimes VALUES (39600, @RiderEndTime)";

        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        connection.Open();

        //        command.Parameters.AddWithValue("@RiderEndTime", txtRiderName.Text);

        //        command.ExecuteScalar();
        //    }

        //    PopulateRiders();
        }
    }
}
