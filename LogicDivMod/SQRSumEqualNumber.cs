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
    class SQRSumEqualNumber
    {
        List<Number> numbers = new List<Number>();

        public IValidator Validator { get; set; }
        public IReader<DataNM> Reader { get; set; }
        public IPrinter Printer { get; set; }

        public SQRSumEqualNumber(IReader<DataNM> reader, IValidator validator, IPrinter printer)
        {
            this.Reader = reader;
            this.Validator = validator;
            this.Printer = printer;
        }

        public void Method()
        {            
            DataNM data = Reader.GetInputData();

            if (Validator.IsValid(data))
            {
                numbers = new Second().Algorithm(data);
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
