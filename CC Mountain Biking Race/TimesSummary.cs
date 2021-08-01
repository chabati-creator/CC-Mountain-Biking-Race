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
    public partial class TimesSummary : Form
    {
        RiderManager rm;
        private string message;
        public TimesSummary(RiderManager rm, string message)
        {
            this.rm = rm;
            this.message = message;
            InitializeComponent();

            richTextBox1.ReadOnly = true;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold); //Set the font to bold
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            //Retrives a rider's start / end times summary
            richTextBox1.AppendText(message);
             
        }

        private void bttnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //TimesSummary screen closes
            Homepage window = new Homepage(rm);                   //Homepage screen opens passing the rm
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
