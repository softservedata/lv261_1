using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_325
{
    /// <summary>
    /// Executes logic of task 325
    /// </summary>
    class Executor
    {
        /// <summary>
        /// Checks that number is prime
        /// </summary>
        /// <param name="number">natural number</param>
        /// <returns>true if number is prime</returns>
        public bool IsPrime(int number)
        {
            bool isPrime = number == 1 ? false : true;
            int i = 2;
            while (isPrime == true && i <= Math.Sqrt(number))
            {
                isPrime = (number % i == 0) ? false : true;
                i++;
            }
            return isPrime;
        }

        /// <summary>
        /// Finds prime dividers of number
        /// </summary>
        /// <param name="number">natural number</param>
        /// <returns>list of prime dividers of number</returns>
        public List<int> FindPrimeDividers(int number)
        {
            List<int> dividers = new List<int>();
            int divider = 1;
            while (divider < Math.Sqrt(number))
            {
                if (number % divider == 0)
                {
                    if (IsPrime(divider))
                    {
                        dividers.Add(divider);
                    }
                    if (IsPrime(number / divider))
                    {
                        dividers.Add(number / divider);
                    }
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
