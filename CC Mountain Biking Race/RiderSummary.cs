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
    public partial class RiderSummary : Form
    {
        private RiderManager rm;
        public RiderSummary(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();

            richTextBox1.ReadOnly = true;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold); //Set the font to bold
            //richTextBox1.AppendText("Rider Summary");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            //Retrives a rider's summary
            richTextBox1.AppendText(rm.LastRiderSummary());
        }

        private void bttnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //AddRider screen closes
            Homepage window = new Homepage(rm);                   //Homepage screen opens passing the ...
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
