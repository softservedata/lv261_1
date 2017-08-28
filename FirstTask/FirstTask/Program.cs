using System;
using System.Collections.Generic;

namespace FirstTask
{
	class Program
	{
		const string TASKINFO_MSG = "Task #{0}";
		const string ERR_MSG = "Something went wrong. MSG: {0}";

		static void Main(string[] args)
		{
			try
			{
				Task86a();
				Task178b();
				Task332();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ERR_MSG, ex.Message);
			}
		}

		#region Tasks

		static void Task86a()
		{
			Console.WriteLine(TASKINFO_MSG, "86a");
			Console.WriteLine("Enter a positive number: ");
			int number = int.Parse(Console.ReadLine());

			Console.WriteLine($"Digits: {number.ToString().Length}");
			Console.ReadLine();
		}

		static void Task178b()
		{
			Console.WriteLine(TASKINFO_MSG, "178b");
			Console.WriteLine(
				"Enter a sequence of positive numbers (divided by space): ");
			var seq = new List<int>();                  //Result sequence of integers.
			var rawSeq = Console.ReadLine().Split(' '); //Sequence of integerss as strings.
			foreach (var number in rawSeq)
			{
				seq.Add(int.Parse(number));
			}

			int count = 0;
			foreach (var number in seq)
			{
				if (number % 3 == 0 && number % 5 != 0)
					count++;
			}
			Console.WriteLine(
				$"Numbers is sequence with factor 3, not 5: {count}");
			Console.ReadLine();
		}

		static void Task332()
		{
			Console.WriteLine(TASKINFO_MSG, "332");
			Console.WriteLine("Enter a positive number: ");
			//The number to represent as a^2+b^2+c^2+d^2.
			int n = int.Parse(Console.ReadLine());

			//First result number.
			int a = (int)Math.Sqrt(n) - 1;
			while (a > 0)
			{
				//Second result number.
				int b = (int)Math.Sqrt(n - a * a) - 1;
				while (b > 0)
				{
					//Third result number.
					int c = (int)Math.Sqrt(n - a * a - b * b);
					while (c > 0)
					{
						//Fourth result number.
						int d = (int)Math.Sqrt(n - a * a - b * b - c * c);
						if (d < 1)
							c--;
						else
						{
							Console.WriteLine(
								$"{n} = {a}^2 + {b}^2 + {c}^2 + {d}^2");
							return;
						}
					}
					b--;
				}
				a--;
			}
			Console.WriteLine("No result.");
		}

		#endregion
	}
}