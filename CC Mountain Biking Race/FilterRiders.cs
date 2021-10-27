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
    public partial class FilterRiders : Form
    {
        public FilterRiders()
        {
            InitializeComponent();

            //Filter riders by ther name, surname, age and school
            //Extra Time: Scoreboard system
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            this.Hide();                                          //FilterRiders screen closes
            CCMountainBikingRaceDB window = new CCMountainBikingRaceDB();  //AddRider screen opens
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
