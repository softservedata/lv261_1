using System;
using System.Collections.Generic;

namespace FirstTask
{
	public class ConsoleReader
	{
		public int ReadNumber()
		{
			if (int.TryParse(Console.ReadLine(), out int number) == false)
			{
				throw new ArgumentException("Couldn't parse number.");
			}
			return number;
		}

		public int[] ReadSequenceOfNumbers()
		{
			var seq = new List<int>();                  //Result sequence of integers.
			var rawSeq = Console.ReadLine().Split(' '); //Sequence of integerss as strings.
			foreach (var number in rawSeq)
			{
				seq.Add(int.Parse(number));
			}
			return seq.ToArray();
		}
	}
}
