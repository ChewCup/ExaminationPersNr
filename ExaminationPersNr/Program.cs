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
            int year = int.Parse(inputId.Substring(0, 4));
            int month = int.Parse(inputId.Substring(4, 2));
            int day = int.Parse(inputId.Substring(6, 2));
            if (inputId.Length == 12 && (year >= 1753 && year <= 2020) && (month >= 1 && month <= 12) && (day >= 1 && day <= 31))
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
        static void CheckDaysInMonth(string inputId)
        {
            int maxDays;
            string year = inputId.Substring(0, 4);
            int month = int.Parse(inputId.Substring(4, 2));
            int day = int.Parse(inputId.Substring(6, 2));
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    maxDays = 31;
                    if (day > maxDays)
                    {
                        Console.WriteLine("Wrong date in month");
                    }
                    else
                    {
                        Console.WriteLine("Correct date");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDays = 30;
                    if (day > maxDays)
                    {
                        Console.WriteLine("Wrong date in month");
                    }
                    else
                    {
                        Console.WriteLine("correct date");
                    }
                    break;

                case 2:
                    maxDays = 28;
                    if (CheckSpecialYear(year))
                    {
                        maxDays = 29;
                        if (day > maxDays)
                        {
                            Console.WriteLine("Wrong date in month");
                        }
                        else
                        {
                            Console.WriteLine("correct");
                        }
                        break;
                    }
                    else if (day > maxDays)
                    {
                        Console.WriteLine("Wrong date in month");
                    }
                    else
                    {
                        Console.WriteLine("correct date");
                    }
                    break;
            }
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
