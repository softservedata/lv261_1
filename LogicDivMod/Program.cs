using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicDivMod.Data;
using LogicDivMod.Tasks;
using static LogicDivMod.Tasks.Global;

namespace LogicDivMod
{
    class Program
    {
        static void Main(string[] args)
        {
            //**************************************************************************************************************

            //DivSQRbutNOTCubic d = new DivSQRbutNOTCubic(new ConsoleReader(), new GeneralValidator(), new ConsolePrinter());
            //d.Method();

            //SQRSumEqualNumber s = new SQRSumEqualNumber(new ConsoleReader(), new GeneralValidator(), new ConsolePrinter());
            //s.Method();

            ArmstrongNumbers a = new ArmstrongNumbers(new ConsoleReader(), new ConsolePrinter());
            a.Method();

            Console.ReadKey();
        }
    }
}
