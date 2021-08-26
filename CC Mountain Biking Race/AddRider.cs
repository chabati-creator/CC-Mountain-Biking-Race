using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mountain_Biking_Race
{
    public partial class AddRider : Form
    {
        RiderManager rm;
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
            int age = Convert.ToInt32(nudAge.Value);
            string school = txbSchool.Text;

            if (txbName.Text == "" || !Regex.IsMatch(txbName.Text, @"^[a-zA-Z]+$")) //If the Name textbox is blank then do the following
            {
                
                txbName.BackColor = Color.LightPink; //The background colour would change to light pink
                string Caption = "Error";
                string Message = "The Name textbox cannot be empty and contain integers. Please enter the rider's name";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //Displays the MessageBox showing an error message informing the user that the name textbox is blank 
                result = MessageBox.Show(Message, Caption, buttons);
                txbName.Focus();
            }
            else
            {
                txbName.BackColor = Color.White; //Will change the backgroud colour back to white when input is valid (textbox not blank)
            }
                
            if (txbSurname.Text == "" || !Regex.IsMatch(txbSurname.Text, @"^[a-zA-Z]+$"))
            {
                txbSurname.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "The Surname textbox cannot be empty and contain integers. Please enter the rider's surname";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(Message, Caption, buttons);
                txbSurname.Focus();
            }
            else
                txbSurname.BackColor = Color.White;
            if (txbSchool.Text == "" || !Regex.IsMatch(txbSchool.Text, @"^[a-zA-Z]+$"))
            {
                txbSchool.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "The School textbox cannot be empty and contain integers. Please enter the rider's school";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(Message, Caption, buttons);
                txbSchool.Focus();
            }
            else
                txbSchool.BackColor = Color.White;

            if (chlbx.CheckedItems.Count == 0) //If the user has not selected a leg(s) then do the following
            {
                chlbx.BackColor = Color.LightPink;
                string Caption = "Error";
                string Message = "Please select which leg(s) the rider is entering in.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                //Display a message box showing an error message informing the user that they have not selected a leg(s)
                result = MessageBox.Show(Message, Caption, buttons);
            }
            else
                chlbx.BackColor = Color.White;


            if (txbName.Text != "" && Regex.IsMatch(txbName.Text, @"^[a-zA-Z]+$") 
                && txbSurname.Text != "" && Regex.IsMatch(txbSurname.Text, @"^[a-zA-Z]+$") 
                && txbSchool.Text != "" && Regex.IsMatch(txbSchool.Text, @"^[a-zA-Z]+$") 
                &&
                chlbx.CheckedItems.Count !=0)      // if all the textboxes are not blank and
                                                   // the user has selected a leg(race) the program continues
            {
                

                List<int> enteredLegIndices = new List<int>();

                foreach (int legIndex in chlbx.CheckedIndices)
                {
                    enteredLegIndices.Add(legIndex);
                }
                //name[0]. = Char.ToUpper(name[0]);
                rm.AddRider(rm.UppercaseFirst(name), rm.UppercaseFirst(surname), age, rm.UppercaseFirst(school), enteredLegIndices);

                //Shows the user True/False depending if the check box is checked or not
                //MessageBox.Show(r.legStatusChecked());

                //Shows the user a rider summary including the rider's name, surname, age, school and selected legs
                //string message = rm.LastRiderSummary();
                //string caption = "AddRider";
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //DialogResult result;
                //// Displays the MessageBox which inlcudes the message and caption. 
                //result = MessageBox.Show(message, caption, buttons);

                StreamWriter sw = new StreamWriter("Riders.txt", true);
                sw.WriteLine(rm.GetRecentlyAddedRider().GetRiderID() + "," +rm.GetRecentlyAddedRider().GetName() + "," + rm.GetRecentlyAddedRider().GetSurname() 
                    + "," + rm.GetRecentlyAddedRider().GetAge() + "," + rm.GetRecentlyAddedRider().GetSchool() + "," + rm.GetRecentlyAddedRider().GetLegStatus());
                sw.Close();

                this.Hide();                                          //AddRider screen closes
                RiderSummary window = new RiderSummary(rm);           //RiderSummary screen opens passing the ...
                window.FormClosed += (s, args) => this.Close();
                window.Show();


            }
        }
    }
}
