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
    public partial class Homepage : Form
    {
        Rider r;
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void addRiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                     //The Homepage screen closes
            //Play window = new Play(p, 0);                    //addRider screen opens passing the n(name and surname) and the leg = 0 for Low stake
            AddRider window = new AddRider();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        
        private void addRaceTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                                     //The Homepage screen closes
            RiderTimes window = new RiderTimes();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
