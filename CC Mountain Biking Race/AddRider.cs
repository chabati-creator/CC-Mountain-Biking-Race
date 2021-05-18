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
    public partial class AddRider : Form
    {
        public AddRider()
        {
            InitializeComponent();
        }

        private void bttnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage window = new Homepage();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void bttnDetails_Click(object sender, EventArgs e) // Add Rider Button
        {
            string name = txbName.Text;

            if (txbName.Text == "")
            {
                txbName.BackColor = Color.LightPink; // The background colour would change to light pink when the text box is blank
                string caption = "Error";
                string message = "The Name textbox cannot be empty. Please enter the rider's name";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //Displays the MessageBox which inlcudes the message and caption. 
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
            {
                int age = Convert.ToInt32(nudAge.Value);

                string message = "The rider's details has been recorded";
                string caption = "AddRider";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox which inlcudes the message and caption. 
                result = MessageBox.Show(message, caption, buttons);
                this.Hide();                                        //AddRider screen closes
                Homepage window = new Homepage();                   //Homepage screen opens passing the ...
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }
        }
    }
}
