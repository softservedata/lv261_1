using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Сonditions conditions = new Сonditions();
            Helper helper = new Helper();
            Tasks tasks = new Tasks();

            Console.WriteLine("Яку задачу будемо вирішувати?\n");

            Console.WriteLine(conditions.Get87Сondition());
            Console.WriteLine(conditions.Get226Сondition());
            Console.WriteLine(conditions.Get559Сondition() + "\n");

            bool flag = false;
            do
            {
                int taskNumber;
                helper.SelectTaskNumber(out taskNumber);
                if(taskNumber == 0)
                {
                    helper.MainError();
                    flag = true;
                }
                else
                {
                    switch (taskNumber)
                    {
                        case 87:
                            {
                                int n;
                                int m;

                                helper.GetDataForTask87(out n, out m);
                                if(n > 0 && m > 0)
                                {
                                    int result = tasks.GetSum_87(n, m);
                                    Console.WriteLine("\nРезультат: " + result);
                                    flag = false;
                                }
                                else
                                {
                                    helper.AdditionalError();
                                    flag = true;
                                }
                            };break;
                        case 226:
                            {
                                int n;
                                int m;

                                helper.GetDataForTask226(out n, out m);
                                if (n != 0 && m != 0)
                                {
                                    List<double> result = tasks.GetAllCommonDivisors_226(n, m);
                                    if (result.Count == 0)
                                    {
                                        if (m < 0 || n < 0)
                                        {
                                            Console.WriteLine("Ви ввели від'ємне число. Припустимі лише натуральні.");
                                            flag = true;
                                            continue;
                                        }
                                        Console.WriteLine("Числа {0} та {1} не мають " +
                                            "спільних дільників до {2}", n, m, n * m);
                                    }
                                    else
                                    {
                                        string strResult = string.Empty;

                                        foreach (double number in result)
                                        {
                                            strResult += number.ToString() + ", ";
                                        }

                                        strResult = strResult.Remove(strResult.LastIndexOf(','));
                                        Console.WriteLine("\nРезультат: " + strResult);
                                    }
                                    flag = false;
                                }
                                else
                                {
                                    helper.AdditionalError();
                                    flag = true;
                                }
                            }; break;
                        case 559:
                            {
                                int m;
                                helper.GetDataForTask559(out m);
                                if (m != 0)
                                {
                                    List<int> result = tasks.GetPrimeMersonNumbers_559(m);

                                    if (result.Count == 0)
                                    {
                                        if (m < 0)
                                        {
                                            Console.WriteLine("Ви ввели від'ємне число. Припустимі лише натуральні.");
                                            flag = true;
                                            continue;
                                        }
                                        Console.WriteLine("від 0 до {0} немає жодного " +
                                            "простого числа Мерсенна", m);
                                    }
                                    else
                                    {
                                        string strResult = string.Empty;
                                        foreach (int number in result)
                                        {
                                            strResult += number.ToString() + ", ";
                                        }

                                        strResult = strResult.Remove(strResult.LastIndexOf(','));
                                        Console.WriteLine("\nРезультат: " + strResult);
                                    }
                                    flag = false;
                                }
                                else
                                {
                                    helper.AdditionalError();
                                    flag = true;
                                }
                            }; break;
                        default:
                            {
                                helper.MainError();
                                flag = true;
                            }; break;
                    }
                }
            } while (flag);
            
            Console.ReadKey();
        }
    }
    public class Сonditions
    {
        public string Get87Сondition()
        {
            string number = "87. ";
            string condition = number + "Дано натуральні n, m. " +
                "Отримати суму m останніх цифр числа n.";
            return condition;
        }
        public string Get226Сondition()
        {
            string number = "226. ";
            string condition = number + "Дано натуральні числа m, n. " +
                "Отримати всі їхні натуральні спільні кратні, \nменші mn.";
            return condition;
        }
        public string Get559Сondition()
        {
            string number = "559. ";
            string condition = number + "Дано натуральне число n. " +
                "Знайти всі менші n прості числа Мерсенна. \n" +
                "(Просте число називається числом Мерсенна, " +
                "якщо воно може бути представлено \nу вигляді " +
                "2^p - 1, де p - також просте число.)";
            return condition;
        }
    }
    public class Helper
    {
        public void MainError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Некоректне значення. " +
                "Допустимі чила: 87, 226, 559");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void AdditionalError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Дані не коректні. " +
                "не вводьте числа < 1 та числа понад 2 147 483 647!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void SelectTaskNumber(out int taskNumber)
        {
            Console.WriteLine("\nВведіть номер задачі і " +
                "натисніть клавішу Enter:");
            int.TryParse(Console.ReadLine(), out taskNumber);
        }
        public void GetDataForTask87(out int n, out int m)
        {
            Console.WriteLine("Введіть натуральне число і " +
                                    "натисніть Enter:");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Скільни останніх цифр " +
                "введеного числа потрібно додати? \n" +
                "Вкінці натисніть Enter:");
            int.TryParse(Console.ReadLine(), out m);
        }
        public void GetDataForTask226(out int n, out int m)
        {
            Console.WriteLine("Введіть перше натуральне число i " +
                                    "натисніть Enter:");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Введіть друге натуральне число i " +
                "натисніть Enter:");
            int.TryParse(Console.ReadLine(), out m);
        }
        public void GetDataForTask559(out int m)
        {
            Console.WriteLine("Введіть натуральне число, " +
                                    "до якого будемо шукати прості числа Мерсенна  i \n" +
                                   "натисніть Enter:");
            int.TryParse(Console.ReadLine(), out m);
        }
    }
}
