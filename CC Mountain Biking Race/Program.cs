using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mountain_Biking_Race
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //RiderManager rm = new RiderManager();
            //Load riders from a txt file to act as permanent riders
            //rm.LoadRiders();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Homepage(rm));
            Application.Run(new CCMountainBikingRaceDB());
        }
    }
}
