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
            int year = int.Parse(userInput.Substring(0, 4));

            // stop
            Console.ReadKey();
        }
        //check input length
        static void CheckLenght(string input)
        {
            if (input.Length == 12)
            {
                Console.WriteLine("your lenght is " + input.Length);
            }
            else
            {
                Console.WriteLine("Enter 12 digit");
            }
        }
        static void CheckInputs(string inputs)
        {
            CheckLenght(inputs);
        }
    }
}
