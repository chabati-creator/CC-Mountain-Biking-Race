using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mountain_Biking_Race
{
    public class Rider
    {
        private int riderID;
        private string name;
        private string surname;
        private int age;
        private string school;
        public int endTime;
        public int totalTime;
        public int legIndex;

        List<Leg> legs = new List<Leg>();

        public Rider(int ID, string n, string s, int a, string l, List<int> legEntered)
        {
            riderID = ID;
            name = n;
            surname = s;
            age = a;
            school = l;
            for (int i = 0; i < 4; i++)
            {
                legs.Add(new Leg("11:00:00"));                    //Add 4 legs to the list
            }

            foreach (int legIndex in legEntered)
            {
                legs[legIndex].SetEntered(true);
            }

            //When an index (0,1,2,3) is checked if it contains Entered
            //then use 1's and 0's to assign 1 - Entered and 2 - Not Entered
            //for example 02 is index 0 and 2, therefore 1010
            string boolCheck = "";
            for (int i = 0; i < 4; i++)
            {
                boolCheck += Convert.ToInt32(legs[i].GetStatusLeg());
            }

            //MessageBox.Show(boolCheck);
        }

        //Instead of doing this, I just need to pass the 'message' which contains the rider's times summary
        //and pass it in the constructor to be used in the TimesSummary form
        //public string TimesSummary()
        //{
        //    string summary = "Competitor ID:" + riderID + ", Name: " + surname + ", " + name + ":";

        //    string legstimes = "";

        //    return summary + legstimes;
        //}

        //Create a method that shows a message box to the user a brief summary of what they entered
        //using a for loop (i) to check which leg is selected (true) and output as a string
        public string RiderSummary()
        {
            //The summary will show the rider's name, surname, age, school and the leg(s) that the rider
            //is entering in.
            string summary = "Name: " + 
                name + "\nSurname: " + surname + "\nAge: " + age + "\nSchool: " + school + "\n" + "\n---- Legs ----\n";

            string legstatus = "";


            for (int i = 0; i<4; i++)
			{
                if (legs[i].GetStatusLeg())
                {
                    legstatus += $"Leg {i + 1}: Entered \n"; //If the rider is entering a leg then it will show "Entered"
                }
               else
                {
                    legstatus += $"Leg {i + 1}: Not Entered \n"; //If the rider is not entering a leg then it will show "Not Entered"
                }
  
            }

            return summary + legstatus;
        }

        public int GetRiderID()
        {
            return riderID;
        }
       public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetSchool()
        {
            return school;
        }

        //Getting the index of the legs that the rider is entering in
        public string GetLegStatus()
        {
            string LegStatus = "";

            int legCounter = 0;
            foreach (var leg in legs)
            {
                //MessageBox.Show(legCounter +" ");
                if (leg.GetStatusLeg())
                {
                    LegStatus += legCounter + "#";
                }
                else
                {
                    LegStatus += "-1#";
                }
                legCounter ++;
            }
            LegStatus = LegStatus.Remove(LegStatus.Length - 1, 1);
            //MessageBox.Show(LegStatus);

            return LegStatus;
        }

        public List<bool> GetEntryValue()
        {
            List<bool> entries = new List<bool>();

            for (int i = 0; i < 4; i++)
            {
                entries.Add(legs[i].GetStatusLeg());

            }
            return entries;
        }

        //Get the rider start times and end times
        public void SetLegResults(int legIndex, string startTime, string endTime)
        {
            legs[legIndex].SetTimes(startTime, endTime);
        }

        //public int GetStartTime(int startTime)
        //{
        //    legs[legIndex].;
        //}

        public int CalculateLegTime(int legIndex)
        {
            return legs[legIndex].CalculateLegTimes();
        }

        public string RiderResults()
        {

            string summary = "Competitor ID:" + riderID + ", Name: " + surname + ", " + name + ":";

            string legstatus = "";

            for (int i = 0; i < 4; i++)
            {

                if (legs[i].GetStatusLeg())
                {
                    legstatus += $"Leg {i + 1}: Start Time: " + legs[i].GetStartTime()
                                + " EndTime: ";

                    if (legs[i].GetEndTime().Equals("00:00:00"))
                    {
                        legstatus += "NA " + "Total Time: NA\n"; 
                    }
                    else 
                    {
                        legstatus += legs[i].GetEndTime()
                                + " Total Time: " + legs[i].CalculateLegTimes() + "s\n";
                    }

                    
                }
                else
                {
                    legstatus += $"Leg {i + 1}: *** Not Entered ***\n";
                    
                }

            }

            return summary + "\n" + legstatus;

        }

        //public string IndividualResults()
        //{
        //    string summary = "Competitor ID:" + riderID + ", Name: " + surname + ", " + name + ":";

        //    return summary;
        //}

        public string GetStartTime(int legIndex)
        {
            return legs[legIndex].GetStartTime();
            
        }

        public bool GetLegStatus(int legIndex)
        {
            return legs[legIndex].GetStatusLeg();
        }
    }
}
