using FirstTask.BLL;
using System;

namespace FirstTask
{
	class Program
	{
		static void Main(string[] args)
		{
			const string firstTaskInfo = "Enter a positive number: ";
			const string firstTaskAnswer 
				= "Number of digits: {0}";
			const string secondTaskInfo 
				= "Enter a sequence of positive numbers (divided by space): ";
			const string secondTaskAnswer 
				= "Numbers is sequence with factor 3, not 5: {0}";
			const string thirdTaskInfo = "Enter a positive number: ";
			const string thirdTaskAnswer
				= "Your number = {0}^2 + {1}^2 + {2}^2 + {3}^2";
			try
			{
				var taskRunner = new TaskRunner();
				var consoleReader = new ConsoleReader();
				var consoleWriter = new ConsoleWriter();

				consoleWriter.WriteLine(ConsoleWriter.TASKINFO_MSG, "86a");
				consoleWriter.WriteLine(firstTaskInfo);
				consoleWriter.WriteLine(
					firstTaskAnswer, 
					taskRunner.GetNumberOfDigits(consoleReader.ReadNumber()).ToString());
				
				consoleWriter.WriteLine(ConsoleWriter.TASKINFO_MSG, "178b");
				consoleWriter.WriteLine(secondTaskInfo);
				consoleWriter.WriteLine(
					secondTaskAnswer,
					taskRunner.GetNumberOfAliquotThreeNotFive(
						consoleReader.ReadSequenceOfNumbers()).ToString());

				consoleWriter.WriteLine(ConsoleWriter.TASKINFO_MSG, "332");
				consoleWriter.WriteLine(thirdTaskInfo);
				consoleWriter.WriteLine(
					thirdTaskAnswer,
					taskRunner.SplitIntoFourSquares(
						consoleReader.ReadNumber()).ToString());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}