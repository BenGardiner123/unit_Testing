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
            return DateTime.Now.Year - YearofBirth;
        }

        



    }

  
}
