using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzzRulesClassModel
    {
        public int ModuloNumber { get; set; }
        public string ReplacementWord { get; set; }
        public FizzBuzzRulesClassModel(int _moduloNumber, string _replacementWord)
        {
            this.ModuloNumber = _moduloNumber;
            this.ReplacementWord = _replacementWord;
        }
    }
}
