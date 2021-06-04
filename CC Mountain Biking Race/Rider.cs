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
        public int RiderID;
        public string name;
        public string surname;
        public int age;
        public string school;
        public int SchoolID;
        public int points;
        readonly List<Leg> legs = new List<Leg>();

        public Rider(string n, string s, int a, string l, List<int> legEntered)
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


        //Create a method that shows a message box to the user a brief summary of what they entered
        //using a for loop (i) to check which leg is selected (true) and output as a string
        public string RiderSummary()
        {
            //The summary will show the rider's name, surname, age, school and the leg(s) that the rider
            //is entering in.
            string summary = "The rider's details has been recorded \n\n" + "---- Rider Summary ---- \n" + "Name: " + 
                name + "\nSurname: " + surname + "\nAge: " + age + "\nSchool: " + school + "\n---- Legs ----\n";

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

        public string GetLegStatus()
        {
            string LegStatus = "";

            int legCounter = 0;
            foreach (var leg in legs)
            {
                MessageBox.Show(legCounter +" ");
                if (leg.GetStatusLeg())
                {
                    LegStatus += legCounter + "#";
                }
                legCounter ++;
            }
            LegStatus = LegStatus.Remove(LegStatus.Length - 1, 1);
            MessageBox.Show(LegStatus);

            return LegStatus;
        }

        //A method that gets generates True or False string which correspond to if the check box is checked
        //public string legStatusChecked()
        //{
        //    string legstatus = "";

        //    for (int i = 0; i < 4; i++)
        //    {
        //        legstatus += legs[i].getStatusLeg() + " ";
        //    }

        //    return legstatus;
        //}
    }
}
