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
            riders.Add(new Rider(n, s, a, l, legEntered));
        }

        public string lastRiderSummary()
        {
            return riders[riders.Count - 1].riderSummary();
        }

        public void loadRiders()
        {
            if (File.Exists("Rider.txt"))
            {
                //MessageBox.Show("File found");

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines("Rider.txt");

                foreach (string line in lines)
                {
                    //MessageBox.Show(line);
                    string[] riderData = line.Split();

                    string[] legData = riderData[4].Split('#');
                    List<int> legsEntered = new List<int>();
                    for (int i = 0; i < 4; i++)
                    {
                        int leg = Convert.ToInt32(legData[i]);
                        legsEntered.Add(leg);
                    }
                    
                    riders.Add(new Rider(riderData[0], riderData[1], Convert.ToInt32(riderData[2]), riderData[3], legsEntered));
                    MessageBox.Show(riders[riders.Count - 1].riderSummary());
                }
                    



            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        

    }
}
