using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_224
{
    /// <summary>
    /// Executes logic of task 224
    /// </summary>
    class Executor
    {
        /// <summary>
        /// Finds dividers of number
        /// </summary>
        /// <param name="number">Natural number</param>
        /// <returns>list of dividers of given number</returns>
        public List<int> FindDividers(int number)
        {
            List<int> dividers = new List<int>();
            int divider = 1;
            while (divider < Math.Sqrt(number))
            {
                if (number % divider == 0)
                {
                    dividers.Add(divider);
                    dividers.Add(number / divider);
                }
                divider++;
            }
            if (number / divider == divider)
            {
                dividers.Add(divider);
            }
            return dividers;
        }

    }
}
