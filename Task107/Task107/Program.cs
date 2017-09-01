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
            try
            {
                while (true)
                {
                    Console.WriteLine("If you want to exit pres 'Q' else input a number:");
                    var st = Console.ReadLine();
                    int number = Int32.Parse(st);
                    Exercise107 rez = new Exercise107(number);
                    Console.WriteLine(rez.MaxPossibleValue());
                }
            }
            catch (WrongNumberException msg)
            {
                Console.WriteLine(msg.Message);
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
            }
            Console.ReadLine();
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
    }
    class WrongNumberException : Exception
    {
        public WrongNumberException() : base(" Wrong number! ")
        {

        }
    }
}
