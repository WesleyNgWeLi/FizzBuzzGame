using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzzRulesService
    {
        FizzBuzzModelService MS = new FizzBuzzModelService();
        ConsoleService CS = new ConsoleService();
        public void StartGame()
        {            
            List<FizzBuzzRulesClassModel> rules = new List<FizzBuzzRulesClassModel>();
            //Loop to keep game going
            string input = "Y";

            Console.WriteLine("Welcome to FizzBuzzPop!");
            //Adds FizzBuzzPop(3/5/7) rules for game
            DefaultRulesSetUp(ref rules);
            while (input == "Y" || input == "y")
            {
                PlayGame(rules);
                Console.WriteLine("Do you want to play again? (Y/N)");
                input = Console.ReadLine();
            }
        }

        public void PlayGame(List<FizzBuzzRulesClassModel> rules)
        {
            int gameVal;
            //Ensures input is either R/r/number
            string input = CS.GetGameInput();

            if (CheckAddRule(input))
            {
                CustomRule(ref rules);
                gameVal = CS.GetIntInput();
            }
            else
            {
                gameVal = Convert.ToInt32(input);
            }
            string output = DoRules(gameVal, rules);
            Console.WriteLine(output);
        }
        private bool CheckAddRule(string s)
        {
            return s == "r" || s == "R";
        }

        public string DoRules(int input, List<FizzBuzzRulesClassModel> rules)
        {
            string result = "";
            
            MS.SortModel(ref rules);
            //Loops through each of the rules and appends the replacement word
            foreach(FizzBuzzRulesClassModel rule in rules)
            {
                if(input % rule.ModuloNumber == 0)
                {
                    result += rule.ReplacementWord;
                }
            }
            if (CheckIfEmptyString(result))
                return input.ToString();
            else
                return result;
        }
        private bool CheckIfEmptyString(string s)
        {
            return s == "";
        }

        public void CustomRule(ref List<FizzBuzzRulesClassModel> rules)
        {
            Console.WriteLine("To add a new rule to FizzBuzzPop:");

            int moduloNum = CS.GetIntInput();
            string replacementWord = CS.GetStringInput();
            AddRule(moduloNum, replacementWord, ref rules);

            Console.WriteLine("Would you like to enter another rule? (Y/N)");

            string input = Console.ReadLine();
            if (input == "Y" || input == "y")
            { CustomRule(ref rules); }
        }

        /// <summary>
        /// Adds a new rule to current list of rules
        /// </summary>
        /// <param name="n"></param>
        /// <param name="w"></param>
        /// <param name="rules"></param>
        public void AddRule(int n, string w, ref List<FizzBuzzRulesClassModel> rules)
        {
            rules.Add(new FizzBuzzRulesClassModel(n, w));
        }        


        public void DefaultRulesSetUp(ref List<FizzBuzzRulesClassModel> rules)
        {
            rules.Add(new FizzBuzzRulesClassModel(3, "Fizz"));
            rules.Add(new FizzBuzzRulesClassModel(5, "Buzz"));
            rules.Add(new FizzBuzzRulesClassModel(7, "Pop"));
        }
    }
}
