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
    public partial class Help : Form
    {
        RiderManager rm;
        public Help(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();
        }

        private void bttnDismiss_Click(object sender, EventArgs e)
        {
            //Help form closes and Homepage form appears when Dismiss button clicked
            this.Hide();
            Homepage window = new Homepage(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
