using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mountain_Biking_Race
{

    public class RiderManager
    {

        List<Rider> riders = new List<Rider>();

        public RiderManager()
        {
        }

        public void AddRider(string n, string s, int a, string l, List<int> legEntered)
        {
            riders.Add(new Rider(riders.Count + 1,n, s, a, l, legEntered));
        }

        public string LastRiderSummary()
        {
            return riders[riders.Count - 1].RiderSummary();
        }



        public void LoadRiders()
        {
            if (File.Exists("Riders.txt"))
            {
                //MessageBox.Show("File found");

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines("Riders.txt");


                foreach (string line in lines)
                {
                    //MessageBox.Show(line);
                    string[] riderData = line.Split(',');

                    string[] legData = riderData[5].Split('#');
                    List<int> legsEntered = new List<int>();
                    for (int i = 0; i < legData.Length; i++)
                    {
                        int leg = Convert.ToInt32(legData[i]);
                        if (leg != -1)
                        {
                            legsEntered.Add(leg);
                        }
                        
                    }
                    string legcheck = "";
                    foreach (var item in legsEntered)
                    {
                        legcheck += item;
                    }

                    //To check which index contains true/Entered (Index 0,1,2,or 3)
                    //MessageBox.Show(legcheck);

                    riders.Add(new Rider(Convert.ToInt32(riderData[0]), riderData[1], riderData[2], Convert.ToInt32(riderData[3]), riderData[4], legsEntered));
                  
                    //When an index (0,1,2,3) is checked if it contains Entered
                    //then use 1's and 0's to assign 1 - Entered and 2 - Not Entered
                    //Then message box shows the rider summary which shows the legs they have entered or not

                    //MessageBox.Show(riders[riders.Count - 1].RiderSummary());
                    
                }

            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        public Rider GetRecentlyAddedRider()
        {
            return riders[riders.Count - 1];
            
        }

        //Returning all the riders details
        public List<Rider> GetRiders()
        {   
            return riders;
        }

        //Retrieves the rider's ID and get the legs entered
        //Searches the ID of all the riders
        public int SearchRiderIndex(int riderID)
        {
            int i = 0;
            int riderIndex = -1;
            bool flag = false;
            while (i < riders.Count && flag == false )
            {
                if (riderID == riders[i].GetRiderID())
                {
                    flag = true;
                    riderIndex = i;
                }
                i++;
            }
            return riderIndex ;
        }

        //Return rider object
        public Rider GetRider(int riderIndex)
        {
            return riders[riderIndex];
        }

        public void SetRidersLegResults(int riderID, int legIndex, string startTime, string endTime)
        {
            int riderIndex = SearchRiderIndex(riderID);
            riders[riderIndex].SetLegResults(legIndex, startTime, endTime);
        }

        public int GetTotalTime(int riderID, int legIndex)
        {
            int riderIndex = SearchRiderIndex(riderID);
            return riders[riderIndex].CalculateLegTime(legIndex);
        }
        public string GetRiderSummary(int riderID)
        {
            int riderIndex = SearchRiderIndex(riderID);
            string ridersSummary = "Rider Summary\n";

            
            ridersSummary += riders[riderIndex].RiderResults();
            
            return ridersSummary;
        }

        //I made a global string variable that displays the rider's times summary and passed it in the TimesSummary constructor
        //public string RiderTimesSummary(int riderID)
        //{
        //    int riderIndex = SearchRiderIndex(riderID);
        //    string timesSummary = "";

        //    timesSummary += riders[riderIndex].TimesSummary();

            
        //    return timesSummary;


        //}
        public string GetRidersSummary()
        {
            string ridersSummary = "\n\n";

            foreach (var rider in riders)
            {
                ridersSummary += rider.RiderResults() + "\n";
            }
            return ridersSummary;
        }

        //public string GetIndividualScore()
        //{
        //    string individualScore = "";

        //    foreach (var rider in riders)
        //    {
        //        individualScore += rider.IndividualResults() + "\n";
        //    }
        //    return individualScore;
        //}

        public string GetStartTime(int riderID, int legIndex)
        {
            int riderIndex = SearchRiderIndex(riderID);
            return riders[riderIndex].GetStartTime(legIndex);
        }

        public List<Rider> GetRaceEntries(int legIndex)
        {
            List<Rider> raceEntries = new List<Rider>();
            foreach (var rider in riders)
            {
                if (rider.GetLegStatus(legIndex) == true)
                {
                    raceEntries.Add(rider);
                }
            }

            //Sort Riders by Race Times ascending

            for (int i = 0; i < raceEntries.Count - 1; i++)
            {
                // pos will be used store the index of the highest value greather than the value referenced by index
                //  it will start start by storing i as i potentially could be the highest value 
                int pos = i;

                // inner loop will loop through the all elemnts after i and store the index of the highest value
                for (int j = i + 1; j < raceEntries.Count; j++)
                {
                    if (raceEntries[pos].CalculateLegTime(legIndex) > raceEntries[j].CalculateLegTime(legIndex))
                    {
                        pos = j;
                    }
                }
                //swoping logic to swop cost[i] with the highest found cost i.e cost[pos]
                Rider riderTemp = raceEntries[i];
                raceEntries[i] = raceEntries[pos];
                raceEntries[pos] = riderTemp;
            }

            int indexCounter = 0;
            int indexFound = -1;
            while (indexFound == -1 && indexCounter < raceEntries.Count)
            {
                if (raceEntries[indexCounter].CalculateLegTime(legIndex) > 0)
                {
                    indexFound = indexCounter;
                }
                indexCounter++;
            }

            if (indexFound > 0)
            {
                for (int i = 0; i < indexFound; i++)
                {
                    raceEntries.Add(raceEntries[i]);
                }


                raceEntries.RemoveRange(0, indexFound);
            }
            


            return raceEntries;
        }

        public string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
