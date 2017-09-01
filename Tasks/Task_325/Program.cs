using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_325
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isNumber = false;

            string inputMessage = "Please, input the number: ";
            string outputMessage = "Dividers are: ";
            string wrongInputMessage = "It is not a natural number! Try again.";

            Executor executor = new Executor();
            while (!isNumber)
            {
                Console.Write(inputMessage);
                if (Int32.TryParse(Console.ReadLine(), out number) == true)
                {
                    Console.WriteLine(outputMessage);
                    foreach (var divider in executor.FindPrimeDividers(number))
                    {
                        Console.WriteLine(divider);
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
