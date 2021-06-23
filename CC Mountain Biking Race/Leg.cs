using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Mountain_Biking_Race
{
    class Leg
    {
        private bool entered;
        public int startTime;
        public int endTime;

        public Leg()
        {
            //Set entered as false
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

        //public string getRiderSummary()
        //{
        //    return riderSummary + "";
        //}


    }


}
