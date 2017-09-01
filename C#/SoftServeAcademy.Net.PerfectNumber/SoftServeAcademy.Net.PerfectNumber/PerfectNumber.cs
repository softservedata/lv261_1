using System;
using System.Collections.Generic;


namespace SoftServeAcademy.Net.PerfectNumber
{
    class PerfectNumber
    {
        
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number:");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    Number perfectNumber = new Number();
                    List<int> perfectNumbers = perfectNumber.GetAllPerfectNumbers(number);

                    if (perfectNumbers.Count > 0)
                    {
                        foreach (var oneNumber in perfectNumbers)
                        {
                            Console.Write(oneNumber.ToString() + " ");
                        }
                        Console.WriteLine();
                    }
                    else Console.WriteLine("No perfect numbers in such number");


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! " + e.Message);
                }
                finally
                {
                    Console.WriteLine("===========================================");
                    Console.WriteLine(@"If you want exit from programm press 'q'.");
                    Console.WriteLine("To continue press any other key.");

                    char key = Console.ReadKey().KeyChar;
                    if (key == 'q')
                        Environment.Exit(0);
                    else Console.Clear();

                }
            }
        }
    }
}
