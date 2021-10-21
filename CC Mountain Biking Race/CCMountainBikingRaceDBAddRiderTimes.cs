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
    public partial class CCMountainBikingRaceDBAddRiderTimes : Form
    {
        SqlConnection connection;
        string connectionString;

        public CCMountainBikingRaceDBAddRiderTimes()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CC_Mountain_Biking_Race.Properties.Settings.CCMountainBikingDBConnectionString"].ConnectionString;
        }



        //private void PopulateEndTimes()
        //{
        //    string query = "SELECT a.EndTime FROM RiderTimes a " +
        //                   "INNER JOIN DetailsTimes b ON a.Id = b.TimesId " +
        //                    "WHERE b.RiderId = @RiderId";

        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //    {
        //        command.Parameters.AddWithValue("@RiderId", lstRiderDetails.SelectedValue);

        //        DataTable riderTimesTable = new DataTable();
        //        adapter.Fill(riderTimesTable);

        //        lstEndTimes.DisplayMember = "EndTime";
        //        lstEndTimes.ValueMember = "Id";
        //        lstEndTimes.DataSource = riderTimesTable;
        //    }
        //}
        
        private void lstRiderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PopulateEndTimes();
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
