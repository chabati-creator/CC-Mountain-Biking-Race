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
        List<int> legs = new List<int>();

        public Rider(string n, string s, int a, string l)
        {
            name = n;
            surname = s;
            age = a;
            school = l;
        }

        public void Riders(int t)
        { 
        
            
        }

    }
}
