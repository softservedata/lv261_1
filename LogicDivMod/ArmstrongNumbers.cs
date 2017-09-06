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
    class ArmstrongNumbers
    {
        List<Number> numbers = new List<Number>();
        
        public IReader<DataN> Reader { get; set; }
        public IPrinter Printer { get; set; }

        public ArmstrongNumbers(IReader<DataN> reader, IPrinter printer)
        {
            this.Reader = reader;            
            this.Printer = printer;
        }

        public void Method()
        {            
            DataN data = new DataN
            {
                N = 999
            };
            numbers = new Third().Algorithm(data);
            Printer.Print(numbers);
            Console.WriteLine("Successfully completed!");            
        }
    }
}
