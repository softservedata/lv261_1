using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task107
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("If you want to exit pres '0' else input a number:");
                    int temp = Int32.Parse(Console.ReadLine());
                    if (temp == 0) break;
                    Exercise107 result = new Exercise107(temp);
                    result.ShowRezult();
                }
                catch(WrongNumberException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch(Exception msg)
                {
                    Console.WriteLine(msg.Message);
                }
            }
                  
        }
    }
    class Exercise107
    {
        private int _number;
        private double _max;
        private const int POWER = 4;
        public Exercise107(int number)
        {
            _number = number;
        }
        public int MaxPossibleValue()
        {
            if (_number <= 1)
            {
                throw new WrongNumberException();
            }
            _max = Math.Log(_number, POWER);
            if (_max == (int)_max)
            {
                return (int)_max - 1;
            }
            else
            {
                return (int)_max;
            }
        }
        public void ShowRezult()
        {
            Console.WriteLine(MaxPossibleValue());
        }
    }
    class WrongNumberException : Exception
    {
        public WrongNumberException() : base(" Wrong number! It must be graiter then 1 ") { }
    }
}
