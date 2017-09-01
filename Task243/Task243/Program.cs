using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task243
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Exersice243 temp = new Exersice243();
                foreach (Exersice243 s in temp.SumValuePowerXY(125))
                {
                    Console.WriteLine(s);
                }
            }
            catch(WrongNumberException msg)
            {
                Console.WriteLine(msg.Message);
            }
            Console.ReadLine();
        }
    }
    class Exersice243
    {
        private const int POWER = 2;
        private int _x;
        private double _y;
        public Exersice243() { }
        private Exersice243(int x, double y)
        {
            _x = x;
            _y = y;
        }
        public List<Exersice243> SumValuePowerXY(int number)
        {
            List<Exersice243> result = new List<Exersice243>();
            if (number < 2) throw new WrongNumberException();
            for (_x = 1; _x < Math.Sqrt(number); _x++)
            {
                _y = Math.Sqrt(number - Math.Pow(_x, POWER));
                if (_y == (int)_y)
                {
                    _y = (int)_y;
                }
                else continue;
                result.Add(new Exersice243(_x, _y));
            }
            return result;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", _x, _y);
        }
    }
    class WrongNumberException: Exception
    {
        public WrongNumberException(): base("Wrong number!") { }
    }
}
