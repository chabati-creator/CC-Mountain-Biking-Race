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

                lstRiderDetails.DisplayMember = "Name";
                lstRiderDetails.ValueMember = "Id";
                lstRiderDetails.DataSource = riderDetailsTable;
            }
        }
        private void PopulateRiderTimes()
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

                lstRiderTimes.DisplayMember = "EndTime";
                lstRiderTimes.ValueMember = "Id";
                lstRiderTimes.DataSource = riderTimesTable;
            }
        }

        private void lstRiderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateRiderTimes();
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RiderDetails VALUES (@RiderName, 'BB', 15, 'HBC',0,1,-1,3)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderName", txtRiderName.Text);

                command.ExecuteScalar();
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

                command.Parameters.AddWithValue("@RiderName", txtRiderName.Text);
                command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);
                command.ExecuteScalar();
            }

            PopulateRiders();
        }

    }
}
