using System;
using personLib;

namespace ConsoleProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            System.Console.WriteLine("Enter name");
            string input = Console.ReadLine();
            p.Name = input;

            System.Console.WriteLine("Enter year of brth");
            input = Console.ReadLine();
            p.YearofBirth = int.Parse(input);

            System.Console.WriteLine($"Hi {p.Name} you are {p.calcAge()} years old");
        }
    }
}
