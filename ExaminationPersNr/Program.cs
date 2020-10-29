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
            string userInputIdNumber;
            // user input
            Console.Write("Enter your Id number (12 digits): ");
            userInputIdNumber = Console.ReadLine();
            // Check length, year, month and day of user input
            CheckInputIdNumber(userInputIdNumber);
            // stop
            Console.ReadKey();
        }
        static void CheckInputIdNumber(string userinputId)
        {

            if (CheckIdLength(userinputId))
            {
                int year = int.Parse(userinputId.Substring(0, 4));
                int month = int.Parse(userinputId.Substring(4, 2));
                int day = int.Parse(userinputId.Substring(6, 2));
                if (year >= 1753 && year <= 2020 && month >= 1 && month <= 12 && day >= 1 && day <= 31)
                {
                    CheckDaysInMonth(userinputId);
                }
                if (year < 1753 || year > 2020)
                {
                    Console.WriteLine("Year is incorrect");
                }
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Month is incorrect");
                }
                if (day < 1 || day > 31)
                {
                    Console.WriteLine("Day is incorrect");
                }
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
        static void CheckDaysInMonth(string userinputId)
        {
            int maxDays;
            string year = userinputId.Substring(0, 4);
            int month = int.Parse(userinputId.Substring(4, 2));
            int day = int.Parse(userinputId.Substring(6, 2));
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
                        Console.WriteLine("Wrong date in the month");
                    }
                    else
                    {
                        Console.WriteLine("Your Id number is correct");
                        CheckGender(userinputId);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDays = 30;
                    if (day > maxDays)
                    {
                        Console.WriteLine("Wrong date in the month");
                    }
                    else
                    {
                        Console.WriteLine("Your Id number is correct");
                        CheckGender(userinputId);
                    }
                    break;
                case 2:
                    maxDays = 28;
                    if (CheckSpecialYear(year))
                    {
                        maxDays = 29;
                        if (day > maxDays)
                        {
                            Console.WriteLine("Your Id number is incorrect");
                        }
                        else
                        {
                            Console.WriteLine("Your Id number is correct");
                            CheckGender(userinputId);
                        }
                        break;
                    }
                    else if (day > maxDays)
                    {
                        Console.WriteLine("Is not a special year (Inte skottår)");
                    }
                    else
                    {
                        Console.WriteLine("Your Id number is correct");
                        CheckGender(userinputId);
                    }
                    break;
            }
        }
        static string CheckGender(string inputBirthNumber)
        {
            int birthNumber = int.Parse(inputBirthNumber.Substring(8, 3));
            if (birthNumber % 2 == 0)
            {
                Console.Write("You are a woman");
            }
            else if (birthNumber % 2 != 0)
            {
                Console.Write("You are a man");
            }
            return birthNumber.ToString();
        }
        static bool CheckIdLength(string InputId)
        {
            if (InputId.Length == 12)
            {
                return true;
            }
            else if (InputId.Length != 12)
            {
                Console.WriteLine("Length of your Id number is incorrect");
            }
            return false;
        }
    }
}
