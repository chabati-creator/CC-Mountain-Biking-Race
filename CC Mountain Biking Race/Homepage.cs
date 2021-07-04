using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mountain_Biking_Race
{
    public partial class Homepage : Form
    {
        private RiderManager rm;
        private DataTable dt;
        private DataView dv;
        private static int riderID = -1;
        public Homepage(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();

            //Listview Properties
            listvRiderSearch.View = View.Details;
            listvRiderSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add Columns
            listvRiderSearch.Columns.Add("ID");
            listvRiderSearch.Columns.Add("Name");

            //Initialise Datatable and add Columns
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            //Getting DataList from Rider Manager
            List<Rider> riders = this.rm.GetRiders();

            foreach (var rider in riders)
            {
                dt.Rows.Add(rider.GetRiderID(), rider.GetName());
            }

            //Fill Datatable
            dv = new DataView(dt);

            PopulateListView(dv);


        }

        private void PopulateListView(DataView dv)
        {
            //Populating the ListView with all the rider's details
            listvRiderSearch.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listvRiderSearch.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString() }));
            }

        }

        //Perform the filter of riders
        private void FilterName_TextChanged(object sender, EventArgs e)
        {
            //Searching for a specific rider
            dv.RowFilter = string.Format("Name Like '%{0}%'", txbRiderSearch.Text);
            PopulateListView(dv);
        }

        private void ListvRiderSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listvRiderSearch.SelectedItems.Count == 1)
            {
                riderID = int.Parse(listvRiderSearch.SelectedItems[0].Text);
            }

            //MessageBox shows a specific rider's race/leg results with their times
            MessageBox.Show(rm.GetRiderSummary(riderID));

        }

        private void AddRiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Homepage form closes and AddRider form appears when Dismiss button clicked
            this.Hide();                                 
            AddRider window = new AddRider(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        
        private void AddRaceTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Homepage form closes and RiderTimes form appears when Dismiss button clicked
            this.Hide();                                     
            RiderTimes window = new RiderTimes(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void AllCompetitorResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Homepage form closes and AllCompetitorResults form appears when Dismiss button clicked
            this.Hide();                                    
            AllCompetitorResults window = new AllCompetitorResults(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

    }
}
