using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task331
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Exercise331 numb = new Exercise331();
                foreach (var s in numb.SumToDegreePowerXYZ(-34))
                {
                    Console.WriteLine(s);
                }
            }
            catch (WrongNumberException msg)
            {
                Console.WriteLine(msg.Message);
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg.Message);
            }
            Console.ReadLine();
        }
    }
    class Exercise331
    {
        private const int POWER = 2;
        private int _x;
        private double _y;
        private double _z;
        public Exercise331() { }
        private Exercise331(int x, double y, double z)
        {
            _x = x; _y = y; _z = z;
        }
        public List<Exercise331> SumToDegreePowerXYZ(int _number)
        {
            List<Exercise331> result = new List<Exercise331>();
            if (_number < 2)
            {
                throw new WrongNumberException();
            }
            for (_x = 1; _x < Math.Sqrt(_number); _x++)
            {
                for (_y = 1; _y < Math.Sqrt(_number - Math.Pow(_x, POWER)); _y++)
                {
                    _z = Math.Sqrt(_number - Math.Pow(_y, POWER) - Math.Pow(_x, POWER));
                    if (_z == 0) continue;
                    if (_z == (int)_z)
                        result.Add(new Exercise331(_x, _y, _z));
                    else continue;
                }
            }
            return result;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", _x, _y, _z);
        }
    }
    class WrongNumberException : Exception
    {
        public WrongNumberException() : base("Wrong number! It must be more then 1") { }
    }
}
