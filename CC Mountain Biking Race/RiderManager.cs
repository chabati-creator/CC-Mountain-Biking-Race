using System;
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
        List<string> riderData = new List<string>();
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
                    MessageBox.Show(line);

                    //riderData = lines;
                    //List<string> dataList = lines.Split();
                    //List<string> legData = dataList[5].Split('#');
                    //List<int> legsEntered = new List<int> { Convert.ToInt32(legData[0]) };
                    //List<Rider> r = new Rider(riderData[0], riderData[1], riderData[2], riderData[3]);



            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        

    }
}
