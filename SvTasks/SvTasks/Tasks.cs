using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvTasks
{
    public class Tasks
    {
        /// <summary>
        /// returns a sum of m last digits n
        /// </summary>
        /// <param name="n">base number</param>
        /// <param name="m">quantity of last digits n</param>
        /// <returns></returns>
        public int GetSum_87(int n, int m)
        {
            if (m > 0 && n > 0)
            {
                // finish result (retuned value)
                int result = 0;
                // remainder of the division by 10
                int rest = 0;
                // quantity of iterations. It must be equal m
                byte iteration = 0;

                bool flag = true;
                do
                {
                    iteration++;
                    rest = n % 10;
                    result += rest;
                    n /= 10;

                    if (iteration == m || n == 0)
                    {
                        flag = false;
                    }
                }
                while (flag);

                // return -1 if quantity of digits in n is less than m
                if (iteration < m)
                {
                    return -1;
                }

                return result;
            }
            return -1;
        }

        /// <summary>
        /// returns List of all common divisors n and m up to n*m
        /// </summary>
        /// <param name="n">first number</param>
        /// <param name="m">second number</param>
        /// <returns></returns>
        public List<double> GetAllCommonDivisors_226(int n, int m)
        {
            List<double> commonDividers = new List<double>();
            if (m > 0 && n > 0)
            {
                int biggerNumber = m > n ? m : n;
                int smallerNumber = m > n ? n : m;
                double i = biggerNumber;
                do
                {
                    if (i % smallerNumber == 0)
                    {
                        commonDividers.Add(i);
                    }
                    i += biggerNumber;
                }
                while (m * n > i);
            }
            return commonDividers;
        }

        /// <summary>
        /// returns all prime Merson Numbers up to n
        /// </summary>
        /// <param name="n">end of search</param>
        /// <returns></returns>
        public List<int> GetPrimeMersonNumbers_559(int n)
        {
            List<int> mersonNumbers = new List<int>();
            if (n > 0)
            {
                List<int> primeNumbers = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };
                int mersonNumber;

                foreach (int pn in primeNumbers)
                {
                    mersonNumber = (int)Math.Pow(2, pn) - 1;

                    if (mersonNumber < n)
                    {
                        if (IsSimple(mersonNumber))
                        {
                            mersonNumbers.Add(mersonNumber);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return mersonNumbers;
        }

        /// <summary>
        /// Determines whether number is simple
        /// </summary>
        /// <param name="number">number for testing on simplicity</param>
        /// <returns></returns>
        private static bool IsSimple(int number)
        {
            bool tf = false;
            if(number == 2 || number == 3 || number == 5)
            {
                return true;
            }
            for (int i = 2; i < (int)(number / 2); i++)
            {
                if (number % i == 0)
                {
                    tf = false;
                    break;
                }
                else
                {
                    tf = true;
                }
            }
            return tf;
        }
    }
}
