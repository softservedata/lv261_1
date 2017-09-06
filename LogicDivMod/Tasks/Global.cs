using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicDivMod.Data;

namespace LogicDivMod.Tasks
{
    class Global
    {
        public interface IPrinter
        {
            void Print(List<Number> numbers);
        }
        public class ConsolePrinter : IPrinter
        {
            public void Print(List<Number> numbers)
            {
                foreach (Number a in numbers)
                {
                    Console.WriteLine("Number =  " + a.Q + "  has been found!");
                }
            }
        }

        public interface IValidator
        {
            bool IsValid(DataN n);
            bool IsValid(DataNM n);
        }
        public class GeneralValidator : IValidator
        {
            public bool IsValid(DataN n)
            {
                try
                {
                    if (n.N > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public bool IsValid(DataNM n)
            {
                try
                {
                    if (n.N > 0 && n.M > 0 && Math.Sqrt(n.M) % 1 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public interface IReader<T>
        {
            T GetInputData();
        }
        public class ConsoleReader : IReader<DataN>, IReader<DataNM>
        {
            DataN IReader<DataN>.GetInputData()
            {
                while (true)
                {
                    Console.WriteLine("Please, enter any positive integer/natural number : ");
                    int temp;
                    if (int.TryParse(Console.ReadLine(), out temp))
                    {
                        return new DataN { N = temp };
                    }
                    else
                    {
                        Console.WriteLine("Wrong data! Please, try again.");
                    }
                }
            }
            DataNM IReader<DataNM>.GetInputData()
            {
                while (true)
                {
                    Console.WriteLine("Please, enter any positive integer/natural numbers where [m] is square of some number : ");
                    Console.WriteLine("n, m :");
                    int tempn;
                    int tempm;
                    if (int.TryParse(Console.ReadLine(), out tempn) && int.TryParse(Console.ReadLine(), out tempm))
                    {
                        return new DataNM { N = tempn, M = tempm };
                    }
                    else
                    {
                        Console.WriteLine("Wrong data! Please, try again.");
                    }
                }
            }
        }        
    }
}
