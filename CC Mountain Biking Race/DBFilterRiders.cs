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
            cbxSchool.Items.Clear();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT School FROM RiderDetails ORDER BY School ASC", connection))
            {
                DataTable riderDetailsTable = new DataTable();
                adapter.Fill(riderDetailsTable);

                //Loop through the DataTable.
                foreach (DataRow row in riderDetailsTable.Rows)
                {
                    //Add Item to ComboBox.
                    cbxSchool.Items.Add(row["School"].ToString());
                    //ComboBoxItem item = new ComboBoxItem(row[1].ToString());
                    //item.SubItems.Add(row[2].ToString());
                    //cbxSchool.Items.Add(item);
                }

            }
            connection.Close();

            cbxAge.Items.Add("Greater than");
            cbxAge.Items.Add("Less than");

            PopulateRiders();

            nudAge.Enabled = false;
            btnFilterRiders.Enabled = false;
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

        private void btnFilterRiders_Click(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM RiderDetails WHERE School = '" + cbxSchool.SelectedItem.ToString() + "'";

            //lvRiderDetails.Items.Clear();

            //using (connection = new SqlConnection(connectionString))
            //using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            //{
            //    DataTable riderDetailsTable = new DataTable();
            //    adapter.Fill(riderDetailsTable);

            //    //Loop through the DataTable.
            //    foreach (DataRow row in riderDetailsTable.Rows)
            //    {
            //        //Add Item to ListView.
            //        ListViewItem item = new ListViewItem(row[1].ToString());
            //        item.SubItems.Add(row[2].ToString());
            //        item.SubItems.Add(row[3].ToString());
            //        item.SubItems.Add(row[4].ToString());
            //        item.SubItems.Add(row[5].ToString());
            //        item.SubItems.Add(row[6].ToString());
            //        item.SubItems.Add(row[7].ToString());
            //        item.SubItems.Add(row[8].ToString());
            //        lvRiderDetails.Items.Add(item);
            //    }

            //}
            //connection.Close();


            string query = "SELECT * FROM RiderDetails WHERE ";

            if (!cbxAge.Text.Equals("Select Option"))
            {
                if (cbxAge.Text == "Greater than")
                {
                    query += "Age > '" + nudAge.Value + "'";
                }
                else
                {
                    query += "Age < '" + nudAge.Value + "'";
                }

                if (!cbxSchool.Text.Equals("Select Option"))
                {
                    query += " AND School = '" + cbxSchool.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                query += "School = '" + cbxSchool.SelectedItem.ToString() + "'";
            }
            
            //query += "School = '" + cbxSchool.SelectedItem.ToString() + "'";

            //string query1 = "SELECT * FROM RiderDetails WHERE Age > '" + nudAge.Value + "'";

            lvRiderDetails.Items.Clear();

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
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

            }
            connection.Close();

        }

        private void cbxAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudAge.Enabled = true;
            btnFilterRiders.Enabled = true;
        }

        private void cbxSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFilterRiders.Enabled = true;
        }
    }
}
