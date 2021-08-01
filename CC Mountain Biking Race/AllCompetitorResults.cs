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
    public partial class AllCompetitorResults : Form
    {
        RiderManager rm;
        public AllCompetitorResults(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();

            richTextBox1.ReadOnly = true;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold); //Set the font to bold
            richTextBox1.AppendText("Summary for all riders");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            //Retrives all the riders results/summary
            richTextBox1.AppendText(rm.GetRidersSummary());                           

            
        }
            
        private void BttnDismiss_Click(object sender, EventArgs e)
        {
            //AllCompetitorResults form closes and Homepage form appears when Dismiss button is clicked
            this.Hide();
            Homepage window = new Homepage(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //AllCompetitorResults form closes and Export form appears when Export button is clicked

            StreamWriter sw = new StreamWriter("AllCompetitorResults.txt", true);
            sw.WriteLine("Summary for all riders" + "\n" + rm.GetRidersSummary());
            sw.Close();

            this.Hide();
            Export window = new Export(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
