using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Mountain_Biking_Race
{
    public class Rider
    {
        public int RiderID;
        public string name;
        public string surname;
        public int age;
        public string school;
        public int SchoolID;
        public int points;
        List<Leg> legs = new List<Leg>();

        public Rider(string n, string s, int a, string l, List<int> legEntered )
        {
            name = n;
            surname = s;
            age = a;
            school = l;
            for (int i = 0; i < 4; i++)
            {
                legs.Add(new Leg());                    //Add 4 legs to the list
            }

            foreach (int legIndex in legEntered)
            {
                legs[legIndex].setEntered(true);
            }
        }

        //Make a method that gets the list

        public bool legStatusChecked()
        {
        }


    }
}
