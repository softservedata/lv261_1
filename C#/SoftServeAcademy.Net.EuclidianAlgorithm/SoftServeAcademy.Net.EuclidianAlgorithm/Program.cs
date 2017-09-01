using System;


namespace SoftServeAcademy.Net.EuclidianAlgorithm
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number m:");
                try
                {
                    int numberM = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the number n:");
                    int numberN = int.Parse(Console.ReadLine());

                    Fraction fraction = new Fraction();
                    fraction.GetFractionWithGretestCommonDivisor(numberM, numberN);
                    Console.WriteLine("result: p="+ fraction.Numerator.ToString() + " q=" + fraction.Denominator.ToString());


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
