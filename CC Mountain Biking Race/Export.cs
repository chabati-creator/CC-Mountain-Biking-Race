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
    public partial class Export : Form
    {
        RiderManager rm;
        public Export(RiderManager rm)
        {
            this.rm = rm;
            InitializeComponent();
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
