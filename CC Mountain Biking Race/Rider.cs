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
                legs[legIndex].setEntered(true);
            }
        }


        //Create a method that shows a message box to the user a brief summary of what they entered
        //using a for loop (i) to check which leg is selected (true) and output as a string
        public string riderSummary()
        {
            //The summary will show the rider's name, surname, age, school and the leg(s) that the rider
            //is entering in.
            string summary = "The rider's details has been recorded \n\n" + "---- Rider Summary ---- \n" + "Name: " + 
                name + "\nSurname: " + surname + "\nAge: " + age + "\nSchool: " + school + "\n---- Legs ----\n";

            string legstatus = "";


            for (int i = 0; i<4; i++)
			{
                if (legs[i].getStatusLeg())
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
