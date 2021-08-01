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
    public partial class ResultsSummary : Form
    {
        RiderManager rm;
        private string summary;
        public ResultsSummary(RiderManager rm, string summary)
        {
            this.rm = rm;
            this.summary = summary;
            InitializeComponent();

            richTextBox1.ReadOnly = true;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold); //Set the font to bold
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            //Retrives a rider's result summary
            richTextBox1.AppendText(summary);


        }

        private void bttnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //RiderResults screen closes
            Homepage window = new Homepage(rm);                   //Homepage screen opens passing the rm
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
