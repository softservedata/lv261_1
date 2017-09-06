using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicDivMod.Data;

namespace LogicDivMod.Tasks
{    
    class First 
    {
        public List<Number> Algorithm(DataN data)
        {
            int q = 1;
            List<Number> numbers = new List<Number>();
            while (data.N >= Math.Pow(q, 2))
            {
                if (data.N % Math.Pow(q, 2) == 0 && data.N % Math.Pow(q, 3) != 0)
                {
                    numbers.Add(new Number { Q = q });
                }
                q++;
            }
            return numbers;
        }
    }
}
