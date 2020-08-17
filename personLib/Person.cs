using System;
using carLib;

namespace personLib
{
    public class Person
    {
        public string Name;

        public int YearofBirth;

        public Car myCar;


        public int calcAge()
        {
            if(this.YearofBirth < 1900)
                throw new Exception("You're too old to be alive. Unless you;re James Hallinan");
            return DateTime.Now.Year - YearofBirth;
        }

        



    }

  
}
