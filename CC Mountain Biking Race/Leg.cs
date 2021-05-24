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
        private int startTime;
        private int endTime;
        

        public Leg()
        {
            entered = false;
        }

        public void setEntered(bool entered)
        {
            this.entered = entered;
        }

        //public string getStatusLeg()
        //{
        //    return statusLeg;
        //}
    }


}
