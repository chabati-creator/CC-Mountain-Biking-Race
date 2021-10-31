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
    public partial class DBAddRiderTimes : Form
    {

        //private DataTable riderDetailsTable;
        private DataView dv;
        //private string endTime = "00:00:00";
        private static int riderID = -1;


        SqlConnection connection;
        string connectionString;

        public DBAddRiderTimes()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CC_Mountain_Biking_Race.Properties.Settings.CCMountainBikingDBConnectionString"].ConnectionString;


            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm:ss";
            dtpEndTime.Text = "11:00:00";

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
            //lvRiderTimes.View = View.Details;
            //lvRiderTimes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ////Add Columns
            ////lvRiderTimes.Columns.Add("StartTime", 80);
            //lvRiderTimes.Columns.Add("EndTime", 75);

            //Fill Datatable
 
            PopulateRiders();

        }

        private void CCMountainBikingRaceDBAddRiderTimes_Load(object sender, EventArgs e)
        {
            //PopulateTimes();
        }

        //Method for original dataview populated directly from the database
        private void PopulateRiders()
        {
            lvRiderDetails.Items.Clear();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM RiderDetails", connection))
            {
                DataTable riderDetailsTable = new DataTable();
                adapter.Fill(riderDetailsTable);
                dv = new DataView(riderDetailsTable);
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
        
        //Method that first clears the listview then creates a duplicate of the original dataview and depending on the
        //input on txtbox it filters the listview 
        private void PopulateListView(DataView dvw)
        {
            lvRiderDetails.Items.Clear();
            foreach (DataRow row in dvw.ToTable().Rows)
            {
                lvRiderDetails.Items.Add(new ListViewItem(new String[] {row[1].ToString(), row[2].ToString(),
                    row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString()}));
            }

        }
        //Method for filtering riders depending on their FirstName
        private void FilterTxt_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("FirstName Like '%{0}%'", txbRiderSearch.Text); // Code from https://www.youtube.com/watch?v=cycavkXug5U
            PopulateListView(dv);
        }

        private void btnAddEndTime_Click(object sender, EventArgs e)
        {
            
            string leg;

            if (rbttn1.Checked)
            {
                leg = "1";
            }
            else if (rbttn2.Checked)
            {
                leg = "2";
            }
            else if (rbttn3.Checked)
            {
                leg = "3";
            }
            else
            {
                leg = "4";
            }

            string query = "INSERT INTO RiderTimes VALUES ('11:00:00', @RiderEndTime, @Leg)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderEndTime", dtpEndTime.Text);
                command.Parameters.AddWithValue("@Leg", leg);


                command.ExecuteScalar();
            }

            string query2 = "SELECT Id FROM RiderTimes ORDER BY Id DESC";
            int TimesId;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderEndTime", dtpEndTime.Text);
                TimesId = (int)command.ExecuteScalar();

                //command.ExecuteScalar();
            }

            string query3 = "INSERT INTO DetailsTimes VALUES (@RiderId, @TimesId) ";
            

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query3, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RiderId", riderID);
                command.Parameters.AddWithValue("@TimesId", TimesId);


                command.ExecuteScalar();
            }


            PopulateRiders();
        }

        private void lvRiderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            riderID = (lvRiderDetails.FocusedItem.Index + 1);
            //MessageBox.Show(""+riderID);   
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //AddRiderTimes screen closes
            DBAddRider window = new DBAddRider();  //AddRider screen opens
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        //private void PopulateTimes()
        //{
        //    lvRiderTimes.Items.Clear();
        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM RiderTimes", connection))
        //    {
        //        DataTable riderTimesTable = new DataTable();
        //        adapter.Fill(riderTimesTable);

        //        //Loop through the DataTable.
        //        foreach (DataRow row in riderTimesTable.Rows)
        //        {
        //            //Add Item to ListView.
        //            ListViewItem item = new ListViewItem(row[2].ToString());
        //            lvRiderTimes.Items.Add(item);
        //        }
        //    }
        //    connection.Close();
        //}


        //private void PopulateTimes()
        //{
        //    string query = "SELECT a.EndTime FROM RiderTimes a " +
        //                   "INNER JOIN DetailsTimes b ON a.Id = b.TimesId " +
        //                    "WHERE b.RiderId = @RiderId";

        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //    {
        //        command.Parameters.AddWithValue("@RiderId", riderID);

        //        DataTable riderTimesTable = new DataTable();
        //        adapter.Fill(riderTimesTable);

        //    }
        //}


    }
}
