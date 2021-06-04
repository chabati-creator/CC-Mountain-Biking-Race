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
        readonly RiderManager rm;
        public RiderTimes(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();
        }

        private void BttnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage window = new Homepage(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void BttnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
