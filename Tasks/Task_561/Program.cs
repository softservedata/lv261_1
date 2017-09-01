using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_561
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isNumber = false;

            string inputMessage = "Please, input the number: ";
            string outputMessage = "Magic numbers are: ";
            string wrongInputMessage = "It is not a natural number! Try again.";

            Executor executor = new Executor();
            while (!isNumber)
            {
                Console.Write(inputMessage);
                if ( UInt32.TryParse(Console.ReadLine(), out number) == true)
                {
                    Console.WriteLine(outputMessage);
                    foreach (var magicNumber in executor.FindMagicNumbers(number))
                    {
                        Console.WriteLine( "{0} ^ 2 = {1}", 
                            magicNumber,
                            (long) magicNumber * magicNumber);
                    }
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine(wrongInputMessage);
                }
            }

            Console.ReadLine();
        }
    }
}
