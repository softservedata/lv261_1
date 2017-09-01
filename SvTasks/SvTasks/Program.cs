using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks ts = new Tasks();

            List<int> merNums = ts.GetMersonNumbers_559(2147000000);

            Console.WriteLine("--------------------------");
            foreach(int mn in merNums)
            {
                Console.WriteLine(mn);
            }
            Console.ReadKey();
        }
    }
}
