using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationPersNr
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare
            string userInput;
            // user input
            Console.Write("Enter your birth ID: ");
            userInput = Console.ReadLine();
            CheckInputs(userInput);
            // convert input
           
            // stop
            Console.ReadKey();
        }
        static void CheckLenght(string input)
        {
            if (input.Length == 12)
            {
                //Console.WriteLine("your lenght is " + input.Length);
            }
            else
            {
                Console.WriteLine("Enter 12 digit");
            }
        }
        static bool CheckSpecialYear(string input)
        {
            int year = int.Parse(input.Substring(0, 4));
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           

        }
        static string CheckGender(string input)
        {
            int birthNr = int.Parse(input.Substring(8, 3));
            if (birthNr % 2 == 0)
            {
                Console.WriteLine("kvinna");
            }
            else if (birthNr % 2 != 0)
            {
                Console.WriteLine("man");
            }
            return birthNr.ToString();
        }
        static void CheckInputs(string inputs)
        {
            CheckLenght(inputs);
            CheckSpecialYear(inputs);
            CheckGender(inputs);
        }
    }
}
