﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Mountain_Biking_Race
{
    class Leg
    {
        private bool entered;
        //private int startTime;
        //private int endTime;
        //private string riderSummary;
        

        public Leg()
        {
            entered = false;
        }

        public void SetEntered(bool entered)
        {
            this.entered = entered;
        }

        public bool GetStatusLeg()
        {
            return entered;
        }

        //public string getRiderSummary()
        //{
        //    return riderSummary + "";
        //}


    }


}
