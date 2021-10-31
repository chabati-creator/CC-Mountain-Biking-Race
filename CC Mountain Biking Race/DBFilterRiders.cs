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
    public partial class DBFilterRiders : Form
    {
        private DataView dv;

        SqlConnection connection;
        string connectionString;
        public DBFilterRiders()
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

            //Filter riders by ther name, surname, age and school
        }

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

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //FilterRiders screen closes
            DBAddRider window = new DBAddRider();  //AddRider screen opens
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void DBFilterRiders_Load(object sender, EventArgs e)
        {
            PopulateRiders();
        }

        private void PopulateListView(DataView dvw)
        {
            lvRiderDetails.Items.Clear();
            foreach (DataRow row in dvw.ToTable().Rows)
            {
                lvRiderDetails.Items.Add(new ListViewItem(new String[] {row[1].ToString(), row[2].ToString(),
                    row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString()}));
            }

        }

        private void FilterTxt_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("FirstName Like '%{0}%'", txbRiderSearch.Text); // Code from https://www.youtube.com/watch?v=cycavkXug5U
            PopulateListView(dv);
        }
    }
}
