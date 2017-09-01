using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_561
{
    /// <summary>
    /// Executes logic of task 561
    /// </summary>
    class Executor
    {
        /// <summary>
        /// Counts dijits in number
        /// </summary>
        /// <param name="number">Natural number</param>
        /// <returns>Amount of dijits in number</returns>
        public int CountDijits(int number)
        {
            int counter = 1;
            int decade = 10;
            while (number >= decade)
            {
                decade *= 10;
                counter++;
            }
            return counter;
        }

        /// <summary>
        /// Finds numbers beetwen 1 and given number 
        /// which in pow 2 has the same last dijits as number 
        /// </summary>
        /// <param name="number">natural number</param>
        /// <returns>list of numbers that satisfy condition</returns>
        public List<int> FindMagicNumbers(int number)
        {
            List<int> magicNumbers = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                long pow = i * i;
                if ((pow - i) % Math.Pow(10, CountDijits(i)) == 0)
                {
                    magicNumbers.Add(i);
                }
            }
            return magicNumbers;
        }
    }
}
