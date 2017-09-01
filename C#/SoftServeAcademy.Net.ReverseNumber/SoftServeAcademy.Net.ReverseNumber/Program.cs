using System;


namespace SoftServeAcademy.Net.ReverseNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number:");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    Number numberOperations = new Number();
                    Console.WriteLine("result: " + numberOperations.Reverse(number).ToString());

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

                    char key=Console.ReadKey().KeyChar;
                    if (key == 'q')
                        Environment.Exit(0);
                    else Console.Clear();

                }
            }
        }
    }
}
