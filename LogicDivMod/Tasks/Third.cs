using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicDivMod.Data;

namespace LogicDivMod.Tasks
{
    class Third
    {
        public List<Number> Algorithm(DataN data)
        {
            int q = 10;
            List<Number> numbers = new List<Number>();
            while (q <= data.N)
            {
                int temp = q;
                List<int> chysla = new List<int>();
                while (temp / 10 != 0)
                {
                    chysla.Add(temp % 10);
                    temp = temp / 10;
                }
                chysla.Add(temp);
                temp = 0;
                foreach (int n in chysla)
                {
                    temp += (int)Math.Pow(n, chysla.Count);
                }
                if (temp == q)
                {
                    numbers.Add(new Number { Q = q });
                }
                q++;
            }
            return numbers;
        }
    }
}
