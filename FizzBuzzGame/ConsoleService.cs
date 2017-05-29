using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class ConsoleService
    {
        public int GetIntInput()
        {
            int returnVal;
            Console.WriteLine("Please input a positive number:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out returnVal) && ValidatePositiveInt(returnVal))
            {
                return returnVal;
            }
            else
            {
                Console.WriteLine("Invalid Input entered! Please enter a positive number.");
                return GetIntInput();
            }
        }

        public bool ValidatePositiveInt(int n)
        {
            return n > 0;
        }

        public string GetStringInput()
        {
            Console.WriteLine("Please input a word:");
            string input = Console.ReadLine();
            if (ValidateIsAlphabets(input))
                return input;
            else
            {
                Console.WriteLine("Invalid word entered! Please enter only alphabets.");
                return GetStringInput();
            }
        }

        public bool ValidateIsAlphabets(string input)
        {
            foreach(char c in input)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public string GetGameInput()
        {
            Console.WriteLine("Please enter a number to play or R to add a rule");
            string input =  Console.ReadLine();
            if (ValidateGameInput(input))
                return input;
            else
            {
                Console.WriteLine("Please enter a number to play or R to add a rule");
                return GetGameInput();
            }
        }
        /// <summary>
        /// Checks if string is R/r/int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool ValidateGameInput(string input)
        {
            int n;
            if (input == "R" || input == "r")
                return true;
            else if (int.TryParse(input, out n))
                return ValidatePositiveInt(n);
            else
                return false;
        }
    }
}
