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
            Console.Write("Now we will look for pairs of integers (XY) ");
            Console.WriteLine("for which X^2 + Y^2 = N, where N is a known number");
            Console.WriteLine("To exit please enter `0`");
            Console.WriteLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the number N:");
                    int tempNumber = Int32.Parse(Console.ReadLine());
                    if (tempNumber == 0) break;
                    Exercise243 result = new Exercise243(tempNumber);
                    result.ShowResult(result.SumToDegreePowerXY());
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
    class Exercise243
    {
        private const int POWER = 2;
        private int _x;
        private double _y;
        private int _number;
        public Exercise243(int number) { _number = number; }
        private Exercise243(int x, double y)
        {
            _x = x; _y = y;
        }
        public List<Exercise243> result = new List<Exercise243>();
        public List<Exercise243> SumToDegreePowerXY()
        {
            if (_number < 2)
            {
                throw new WrongNumberException();
            }
            for (_x = 1; _x < Math.Sqrt(_number); _x++)
            {
                _y = Math.Sqrt(_number - Math.Pow(_x, POWER));
                if (_y == (int)_y)
                    result.Add(new Exercise243(_x, _y));
                else continue;
            }
            return result;
        }
        public void ShowResult(List<Exercise243> temp)
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
            return string.Format("{0} {1}", _x, _y);
        }
    }
    class WrongNumberException : Exception
    {
        public WrongNumberException() : base("Wrong number! It must be more then 1") { }
    }
}
