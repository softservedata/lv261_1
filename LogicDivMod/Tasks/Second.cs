using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicDivMod.Data;

namespace LogicDivMod.Tasks
{
    class Second
    {
        public List<Number> Algorithm(DataNM data)
        {
            int q = 1;
            List<Number> numbers = new List<Number>();
            while (data.N > q)
            {
                int s = 0;
                int temp = q;
                while (temp / 10 != 0)
                {
                    s += temp % 10;
                    temp = temp / 10;

                }
                s += temp;
                if (Math.Pow(s, 2) == data.M)
                {
                    numbers.Add(new Number { Q = q });
                }
                q++;
            }
            return numbers;
        }
    }
}
