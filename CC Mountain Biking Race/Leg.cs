using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mountain_Biking_Race
{
    class Leg
    {
        private bool entered;
        private string startTime = "00:00:00";
        private string endTime = "00:00:00";
        private int totalTime;

        public Leg(string startTime)
        {
            //Set entered as false
            this.startTime = startTime;
            entered = false;
        }

        public void SetEntered(bool entered)
        {
            this.entered = entered;
        }

        public bool GetStatusLeg()
        {
            //Return entered as false
            return entered;
        }

        public void SetTimes(string startTime, string endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;

        }

        public string GetStartTime()
        {
            return startTime;
        }

        public string GetEndTime()
        {
            return endTime;
        }

        public int CalculateLegTimes()
        {
            string[] startTimes = startTime.Split(':');

            int startTimeHour = (Convert.ToInt32(startTimes[0])*60*60);
            int startTimeMinutes = (Convert.ToInt32(startTimes[1])*60);
            int startTimeSeconds = Convert.ToInt32(startTimes[2]);

            int finalStartTime = startTimeHour + startTimeMinutes + startTimeSeconds;

            string[] endTimes = endTime.Split(':');

            int endTimeHour = (Convert.ToInt32(endTimes[0])*60*60);
            int endTimeMinutes = (Convert.ToInt32(endTimes[1])*60);
            int endTimeSeconds = Convert.ToInt32(endTimes[2]);

            int finalEndTime = endTimeHour + endTimeMinutes + endTimeSeconds;

            totalTime = finalEndTime - finalStartTime;
            return totalTime;
        }


    }


}
