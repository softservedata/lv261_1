using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeAcademy.Net.ReverseNumber
{
    class Number
    {
        public int Reverse(int number)
        {
            if (number < 0)
                throw new LessThanZeroException("The number can't be less than zero.");

            int result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            return result;
        }
    }
}
