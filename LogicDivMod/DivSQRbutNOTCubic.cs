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
    class DivSQRbutNOTCubic
    {
        List<Number> numbers = new List<Number>();

        public IValidator Validator { get; set; }
        public IReader<DataN> Reader { get; set; }
        public IPrinter Printer { get; set; }

        public DivSQRbutNOTCubic(IReader<DataN> reader, IValidator validator, IPrinter printer)
        {
            this.Reader = reader;            
            this.Validator = validator;
            this.Printer = printer;
        }

        public void Method()
        {            
            DataN data = Reader.GetInputData();
            
            if (Validator.IsValid(data))
            {
                numbers = new First().Algorithm(data);
                Printer.Print(numbers);
                
                Console.WriteLine("Successfully completed!");
            }
            else
            {
                Console.WriteLine("Invalid data!");
            }            
        }                
    }
}
