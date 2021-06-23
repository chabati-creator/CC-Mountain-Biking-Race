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
                    string[] riderData = line.Split(','); //not string[] riderData = line.Split();

                    string[] legData = riderData[5].Split('#');
                    List<int> legsEntered = new List<int>();
                    for (int i = 0; i < legData.Length; i++)
                    {
                        int leg = Convert.ToInt32(legData[i]);
                        legsEntered.Add(leg);
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

        public List<Rider> GetRiders()
        {   
            //Returning all the riders details
            return riders;
        }

        //Create a method that retrieves the rider's ID and get the legs entered
        //A method that searches the ID of all the riders
        public int SearchID(int riderID)
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
            return riderIndex;

        }
        //Return rider object
        public Rider GetRider(int riderIndex)
        {
            return riders[riderIndex];
        }

    }
}
