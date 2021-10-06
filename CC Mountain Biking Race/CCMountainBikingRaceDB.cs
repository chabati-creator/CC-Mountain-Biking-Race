using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CC_Mountain_Biking_Race
{
    public partial class CCMountainBikingRaceDB : Form
    {
        string connectionString;

        public CCMountainBikingRaceDB()
        {
            InitializeComponent();

        //connectionString = ConfigurationManager.ConnectionStrings[]
        }

        private void CCMountainBikingRaceDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cCMountainBikingDBDataSet.RiderDetails' table. You can move, or remove it, as needed.
            this.riderDetailsTableAdapter.Fill(this.cCMountainBikingDBDataSet.RiderDetails);

        }

        private void riderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.riderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cCMountainBikingDBDataSet);

        }
    }
}
