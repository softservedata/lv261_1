using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
	public class ConsoleWriter
	{
		public const string TASKINFO_MSG = "Task #{0}";
		public const string ERR_MSG = "Something went wrong. MSG: {0}";

		public void WriteLine(string message, string parameter)
		{
			System.Console.WriteLine(message, parameter);
		}

		public void WriteLine(string message)
		{
			System.Console.WriteLine(message);
		}
	}
}
