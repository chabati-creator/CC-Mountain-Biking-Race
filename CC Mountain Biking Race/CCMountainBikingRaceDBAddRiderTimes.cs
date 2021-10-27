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

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm:ss";
            dtpEndTime.Text = "00:00:00";

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
            
            //Listview Properties
            lvRiderTimes.View = View.Details;
            lvRiderTimes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add Columns
            lvRiderTimes.Columns.Add("StartTime", 80);
            lvRiderTimes.Columns.Add("EndTime", 75);
        }
        
        private void lstRiderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PopulateEndTimes();
        }

        private void CCMountainBikingRaceDBAddRiderTimes_Load(object sender, EventArgs e)
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

        private void FilterTxt_TextChanged(object sender, EventArgs e)
        {
            //.RowFilter = string.Format("Name Like '%{0}%'", txbRiderSearch.Text); // Code from https://www.youtube.com/watch?v=cycavkXug5U
            //PopulateRiders();
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //AddRiderTimes screen closes
            CCMountainBikingRaceDB window = new CCMountainBikingRaceDB();  //AddRider screen opens
            window.FormClosed += (s, args) => this.Close();
            window.Show();
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

        private void btnUpdateEndTime_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRider_Click(object sender, EventArgs e)
        {

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
    }
}
