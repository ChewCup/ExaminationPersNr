using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Console.Write("Enter your birth Id number (12 digits): ");
            userInput = Console.ReadLine();
            // Check length, year, month and day of the input Id
            CheckInputIdNumber(userInput);
            // print gender
            CheckGender(userInput);
            // stop
            Console.ReadKey();
        }
        static void CheckInputIdNumber(string inputId)
        {
            int Year = int.Parse(inputId.Substring(0, 4));
            int Month = int.Parse(inputId.Substring(4, 2));
            int Day = int.Parse(inputId.Substring(6, 2));
            if (inputId.Length == 12 && (Year >= 1753 && Year <= 2020) && (Month >= 1 && Month <= 12) && (Day >= 1 && Day <= 31))
            {
                CheckDaysInMonth(inputId);
            }
            else
            {
                Console.WriteLine("Incorrect Id number!");
            }
        }
        static bool CheckSpecialYear(string inputYear)
        {
            int year = int.Parse(inputYear.Substring(0, 4));
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
        static void CheckDaysInMonth(string input)
        {
            
        }
        static string CheckGender(string input)
        {
            int birthNumber = int.Parse(input.Substring(8, 3));
            if (birthNumber % 2 == 0)
            {
                Console.Write("Women");
            }
            else if (birthNumber % 2 != 0)
            {
                Console.Write("Man");
            }
            return birthNumber.ToString();
        }
        /*static void CheckInputs(string inputs)
        {
            CheckLenght(inputs);
            CheckGender(inputs);
            CheckDaysInMonth(inputs);
        }*/
    }
}
