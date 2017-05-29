using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzzModelService
    {
        /// <summary>
        /// Sorts list into ascending order by ModuloNumber
        /// </summary>
        /// <param name="m"></param>
        public void SortModel(ref List<FizzBuzzRulesClassModel> m)
        {
            m = m.OrderBy(o => o.ModuloNumber).ToList();
        }
    }
}
