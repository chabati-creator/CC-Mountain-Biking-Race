using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mountain_Biking_Race
{
    public partial class AddRider : Form
    {
        readonly RiderManager rm;
        public AddRider(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();
        }

        private void BttnDismiss_Click(object sender, EventArgs e)
        {   
            //Add Rider Screen closes and Homepage opens
            this.Hide();
            Homepage window = new Homepage(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void BttnDetails_Click(object sender, EventArgs e) // Add Rider Button
        {

            string name = txbName.Text;
            string surname = txbSurname.Text;
            string school = txbSchool.Text;

            if (txbName.Text == "") //If the Name textbox is blank then do the following
            {
                txbName.BackColor = Color.LightPink; //The background colour would change to light pink
                string caption = "Error";
                string message = "The Name textbox cannot be empty. Please enter the rider's name";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //Displays the MessageBox showing an error message informing the user that the name textbox is blank 
                result = MessageBox.Show(message, caption, buttons);
                txbName.Focus();
            }
            else
                txbName.BackColor = Color.White; //Will change the backgroud colour back to white when input is valid (textbox not blank)
            if (txbSurname.Text == "")
            {
                txbSurname.BackColor = Color.LightPink;
                string caption = "Error";
                string message = "The Surname textbox cannot be empty. Please enter the rider's surname";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                txbSurname.Focus();
            }
            else
                txbSurname.BackColor = Color.White;
            if (txbSchool.Text == "")
            {
                txbSchool.BackColor = Color.LightPink;
                string caption = "Error";
                string message = "The School textbox cannot be empty. Please enter the rider's school";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                txbSchool.Focus();
            }
            else
                txbSchool.BackColor = Color.White;

            if (chlbx.CheckedItems.Count == 0) //If the user has not selected a leg(s) then do the following
            {
                string caption = "Error";
                string message = "Please select which leg(s) the rider is entering in.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                //Display a message box showing an error message informing the user that they have not selected a leg(s)
                result = MessageBox.Show(message, caption, buttons);
            }


            if (txbName.Text != "" && txbSurname.Text != "" && txbSchool.Text != "" &&
                chlbx.CheckedItems.Count !=0)      // if all the textboxes are not blank and
                                                   // the user has selected a leg(race) the program continues
            {

                int age = Convert.ToInt32(nudAge.Value);

                List<int> enteredLegIndices = new List<int>();

                foreach (int legIndex in chlbx.CheckedIndices)
                {
                    enteredLegIndices.Add(legIndex);
                }

                rm.AddRider(name, surname, age, school, enteredLegIndices);

                //Shows the user True/False depending if the check box is checked or not
                //MessageBox.Show(r.legStatusChecked());

                //Shows the user a rider summary including the rider's name, surname, age, school and selected legs
                string message = rm.LastRiderSummary();
                string caption = "AddRider";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox which inlcudes the message and caption. 
                result = MessageBox.Show(message, caption, buttons);

                StreamWriter sw = new StreamWriter("Riders.txt", true);
                sw.WriteLine("\n" + rm.GetRecentlyAddedRider().GetName() + "," + rm.GetRecentlyAddedRider().GetSurname() 
                    + "," + rm.GetRecentlyAddedRider().GetAge() + "," + rm.GetRecentlyAddedRider().GetSchool() + "," + rm.GetRecentlyAddedRider().GetLegStatus());
                sw.Close();
                Console.WriteLine("Game Statistics Exported Successfully");

                this.Hide();                                        //AddRider screen closes
                Homepage window = new Homepage(rm);                   //Homepage screen opens passing the ...
                window.FormClosed += (s, args) => this.Close();
                window.Show();


            }
        }
    }
}
