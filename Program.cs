using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1day3example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            string message;
            if (age < 0 || age > 100)
            {
                message = "This program is for humans";
            }
            else if (age <= 2)
            {
                message = "Still in Mama's arms";
            }
            else if (age <= 4)
            {
                message = "Preschool Maniac";
            }
            else if (age <= 11)
            {
                message = "Elementary School";
            }
            else if (age <= 14)
            {
                message = "Middle School";
            }
            else if (age <= 18)
            {
                message = "High School";
            }
            else if (age <= 22)
            {
                message = "College";
            }
            else if (age <= 65)
            {
                message = "Working for the man";
            }
            else
            {
                message = "The Golden Years";
            }
            Console.WriteLine(message);
        }
    }
}
