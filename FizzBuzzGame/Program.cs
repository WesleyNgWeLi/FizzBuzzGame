using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzRulesService RS = new FizzBuzzRulesService();
            RS.StartGame();
        }
    }
}
