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
        public RiderTimes()
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
    }
}
