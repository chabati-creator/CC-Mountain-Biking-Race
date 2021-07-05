using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mountain_Biking_Race
{
    public partial class RiderTimes : Form
    {
        private RiderManager rm;
        private DataTable dt;
        private DataView dv;
        private static int riderID = -1;
        


        public RiderTimes(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();

            //Disable all the radiobuttons, datetimepickers and update button
            //to prevent user from clicking it when they have not selected a rider
            rbttn1.Enabled = false;
            rbttn2.Enabled = false;
            rbttn3.Enabled = false;
            rbttn4.Enabled = false;
            bttnUpdate.Enabled = false;
            dtpStartTime.Enabled = false;
            dtpEndTime.Enabled = false;

            //Formatting the datetimepickers
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm:ss";
            dtpStartTime.Text = "00:00:00";

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm:ss";
            dtpEndTime.Text = "00:00:00";

            //Listview Properties
            listvSearch.View = View.Details;
            listvSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add Columns
            listvSearch.Columns.Add("ID");
            listvSearch.Columns.Add("Name");
            listvSearch.Columns.Add("Surname", 75);
            listvSearch.Columns.Add("Age", 50);
            listvSearch.Columns.Add("School", 75);
            listvSearch.Columns.Add("Leg 1", 80);
            listvSearch.Columns.Add("Leg 2", 80);
            listvSearch.Columns.Add("Leg 3", 80);
            listvSearch.Columns.Add("Leg 4", 80);

            //Initialise Datatable and add Columns
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            dt.Columns.Add("School");
            dt.Columns.Add("Leg 1");
            dt.Columns.Add("Leg 2");
            dt.Columns.Add("Leg 3");
            dt.Columns.Add("Leg 4");

            //Getting DataList from Rider Manager
            List<Rider> riders = this.rm.GetRiders();
             
            foreach (var rider in riders)
            {
                string[] entryData = rider.GetLegStatus().Split('#');

                string[] entryStatus = new string[4];

                int innerLoop = 0;
                for (int entryDataIndex = 0; entryDataIndex < entryData.Length; entryDataIndex++)
                {
                    for (int entryStatusIndex = innerLoop; entryStatusIndex < 4; entryStatusIndex++)
                    {
                        if (entryData[entryDataIndex] == "" + entryStatusIndex)
                        {
                            entryStatus[entryStatusIndex] = "Entered";
                            //When the leg is entered, add 1 to the leg entered index which makes the innerLoop
                            //This is so that the for loop starts at the next index
                            innerLoop = entryStatusIndex + 1;
                            entryStatusIndex = 4;
                        }
                        else
                        {
                            entryStatus[entryStatusIndex] = "Not Entered";
                            
                            
                        }
                    }
                }

                dt.Rows.Add(rider.GetRiderID(), rider.GetName(), rider.GetSurname(), rider.GetAge(), rider.GetSchool(), entryStatus[0], entryStatus[1], entryStatus[2], entryStatus[3]);

                
            }

            //Fill Datatable
            dv = new DataView(dt);

            PopulateListView(dv);
        }

        //Fill Listview from dataviwew
        private void PopulateListView(DataView dv)
        {
            listvSearch.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listvSearch.Items.Add(new ListViewItem(new String[] {row[0].ToString(), row[1].ToString(), row[2].ToString(),
                    row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString()}));
            }

        }

        //Perform the filter of riders
        private void FilterTxt_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Name Like '%{0}%'", txbSearch .Text);
            PopulateListView(dv);
        }

        private void BttnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage window = new Homepage(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            int legIndex;
            //MessageBox.Show(dtpStartTime.Value.ToString());

            if (rbttn1.Checked)
            {
                legIndex = (int)Char.GetNumericValue(rbttn1.Text[rbttn1.Text.Length - 1]) - 1;  //convert a character to an integer
                //MessageBox.Show(legIndex + "");

            }
            else if (rbttn2.Checked)
            {
                legIndex = (int)Char.GetNumericValue(rbttn2.Text[rbttn2.Text.Length - 1]) - 1;
            }
            else if (rbttn3.Checked)
            {
                legIndex = (int)Char.GetNumericValue(rbttn3.Text[rbttn3.Text.Length - 1]) - 1;
            }
            else
            {
                legIndex = (int)Char.GetNumericValue(rbttn4.Text[rbttn4.Text.Length - 1]) - 1;
            }


            //dtpStartTime.Text = rm.GetStartTime(riderID, legIndex);
            string startTime = dtpStartTime.Text;
            string endTime = dtpEndTime.Text;
            rm.SetRidersLegResults(riderID,legIndex,startTime,endTime);
            //rm.GetLegIndex(riderID, legIndex);

            string message = "------------------------ Start / End Times Summary ------------------------ \n\n"
                                + "Competitor ID: "+ riderID + ", Name: " + rm.GetRider(rm.SearchRiderIndex(riderID)).GetSurname() 
                                + ", " + rm.GetRider(rm.SearchRiderIndex(riderID)).GetName() 
                                + "\nLeg: " + (legIndex+1) + " Start Time: " + startTime 
                                + " \tEnd Time: " + endTime + "    Total Time: " + rm.GetTotalTime(riderID,legIndex);
            string caption = "AddRider";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            this.Hide();                                          //AddRider screen closes
            Homepage window = new Homepage(rm);                   //Homepage screen opens passing the ...
            window.FormClosed += (s, args) => this.Close();
            window.Show();

        }

        //Uses the SelectedItems property to retrievethe selected menu items.
        private void ListvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Rider Selected");
            //ListView.SelectedListViewItemCollection name = this.listvSearch.SelectedItems;

            Rider foundRider;

            if (listvSearch.SelectedItems.Count == 1)
            {
                riderID = int.Parse(listvSearch.SelectedItems[0].Text);

                // fetch data for that rider
                foundRider = rm.GetRider(rm.SearchRiderIndex(riderID));
                //MessageBox.Show("Rider Found:" + foundRider.GetName());

                if (foundRider != null)
                {
                    //dtpStartTime.Enabled = true;
                    //dtpEndTime.Enabled = true;
                    //bttnUpdate.Enabled = true;
                    List<bool> rbttnvalues;
                    rbttnvalues = foundRider.GetEntryValue();

                    rbttn1.Enabled = rbttnvalues[0];
                    //MessageBox.Show(rbttn1.Enabled + "");     outputs True/Flase if leg entered or not
                    rbttn2.Enabled = rbttnvalues[1];        //If leg entered enable the button if not remain disabled
                    rbttn3.Enabled = rbttnvalues[2];
                    rbttn4.Enabled = rbttnvalues[3];

                }
            }

        }

        private void Bttn_CheckedChanged(object sender, EventArgs e)
        {
            int legIndex = (int)Char.GetNumericValue(rbttn1.Text[rbttn1.Text.Length - 1]) - 1;  //convert a character to an integer
                                                                                            //MessageBox.Show(legIndex + "");
            dtpStartTime.Text = rm.GetStartTime(riderID, legIndex);
            //MessageBox.Show(rm.GetStartTime(riderID, legIndex));

            bttnUpdate.Enabled = true;
            dtpStartTime.Enabled = true;
            dtpEndTime.Enabled = true;
        }

        private void DtpValueChanged(object sender, EventArgs e)
        {

            dtpEndTime.MinDate = dtpStartTime.Value;
        }
    }

}
