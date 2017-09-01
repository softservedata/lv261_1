using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeAcademy.Net.PerfectNumber
{
    class Number
    {
        public List<int> GetAllPerfectNumbers(int number)
        {
            if (number < 0)
                throw new LessThanZeroException("The number can't be less than zero.");

            List<int> perfectNymbers = new List<int>();
            int sum;
            for (int i = 6; i < number; i++)
            {
                sum = 0;
                if (i % 2 == 0)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                            sum += j;
                    }
                }
                if (sum == i)
                    perfectNymbers.Add(i);
            }

            return perfectNymbers;
        }
    }
}
