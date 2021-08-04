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
        private DataTable dts;
        private DataView dvs;
        private static int riderID = -1;
        public Homepage(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();

            

            //Retrives all the riders results/summary
            //rtbIndScoreboard.AppendText(rm.GetIndividualScore());

            //ListView Scoreboard Properties
            listvScoreBoard.View = View.Details;
            listvScoreBoard.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
            //Add Columns
            listvScoreBoard.Columns.Add("Position");
            listvScoreBoard.Columns.Add("ID");
            listvScoreBoard.Columns.Add("Name", 70);
            listvScoreBoard.Columns.Add("Surname", 75);
            listvScoreBoard.Columns.Add("Total Time", 95);

            //Initialise Datatable and add Columns
            dts = new DataTable();
            dts.Columns.Add("Position");
            dts.Columns.Add("ID");
            dts.Columns.Add("Name");
            dts.Columns.Add("Surname");
            dts.Columns.Add("Total Time");

            //Getting DataList from Rider Manager
            List<Rider> riders = this.rm.GetRiders();

            //Listview Rider Search Properties
            listvRiderSearch.View = View.Details;
            listvRiderSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add Columns
            listvRiderSearch.Columns.Add("ID");
            listvRiderSearch.Columns.Add("Name" , 64);

            //Initialise Datatable and add Columns
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            

            foreach (var rider in riders)
            {
                dt.Rows.Add(rider.GetRiderID(), rider.GetName());

            }

            //Fill Datatable
            dv = new DataView(dt);
            PopulateListView(dv);

            //Fill Datatable
            dvs = new DataView(dts);
            PopulateListViewScoreboard(dvs);
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

        private void PopulateListViewScoreboard(DataView dvs)
        {
            //Populating the ListView with all the rider's details
            listvScoreBoard.Items.Clear();
            foreach (DataRow row in dvs.ToTable().Rows)
            {
                listvScoreBoard.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() }));
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
            //MessageBox.Show(rm.GetRiderSummary(riderID));

            this.Hide();                                                                           //Homepage screen closes
            ResultsSummary window = new ResultsSummary(rm, rm.GetRiderSummary(riderID));           //ResultsSummary screen opens passing the ...
            window.FormClosed += (s, args) => this.Close();
            window.Show();

        }

        private void AddRiderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Homepage form closes and AddRider form appears when Dismiss button clicked
            this.Hide();
            AddRider window = new AddRider(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void AddRaceTimesToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void CbxLegs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int legIndex = (int)Char.GetNumericValue(cbxLegs.Text[4]) - 1; ;
            //MessageBox.Show(legIndex + "");
            listvScoreBoard.Items.Clear();
            dts.Clear();
            List<Rider> raceEntries = rm.GetRaceEntries(legIndex);

            int posCounter = 1;

            foreach (var rider in raceEntries)
            {
                int calcTime = rider.CalculateLegTime(legIndex);
                //MessageBox.Show(rider.CalculateLegTime(legIndex) + "");
                string calcTimeText;
                string posCounterText;

                if (calcTime <= 0)
                {
                    calcTimeText = "NA";
                    posCounterText = "NA";
                }
                else
                {
                    calcTimeText = "" + calcTime;
                    posCounterText = "" + posCounter;
                }
                 
                //MessageBox.Show(calcTimeText);
                dts.Rows.Add(posCounterText, rider.GetRiderID(), rider.GetName(), rider.GetSurname(), calcTimeText);
                posCounter++;
                //listvScoreBoard.Items.Clear();

            }

            //dvs = new DataView(dts);
            PopulateListViewScoreboard(dvs);
        }

    }
}
