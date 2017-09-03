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
            Console.Write("Now we will look for pairs of integers (XYZ) ");
            Console.WriteLine("for which X^2 + Y^2 + Z^2 = N, where N is a known number");
            Console.WriteLine("To exit please enter `0`");
            Console.WriteLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the number N:");
                    int tempNumber = Int32.Parse(Console.ReadLine());
                    if (tempNumber == 0) break;
                    Exercise331 result = new Exercise331(tempNumber);
                    result.ShowResult(result.SumToDegreePowerXYZ());
                }
                catch (WrongNumberException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
            }
        }
    }
    class Exercise331
    {
        private const int POWER = 2;
        private int _x;
        private double _y;
        private double _z;
        private int _number;
        public Exercise331(int number) { _number = number; }
        private Exercise331(int x, double y, double z)
        {
            _x = x; _y = y; _z = z;
        }
        public List<Exercise331> result = new List<Exercise331>();
        public List<Exercise331> SumToDegreePowerXYZ()
        {
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
        public void ShowResult(List<Exercise331> temp)
        {
            if (temp.Count == 0)
                Console.WriteLine("For this number there is no one pair of numbers that would fulfill the above conditions");
            foreach (var s in temp)
            {
                Console.WriteLine(s);
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", _x, _y, _z);
        }
    }
    class WrongNumberException : Exception
    {
        public WrongNumberException() : base("Wrong number! It must be more then 1") { }
    }
}
