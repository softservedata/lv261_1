using System;

namespace FirstTask.BLL
{
	public class TaskRunner
	{
		public int GetNumberOfDigits(int number)
		{
			if(number <= 0)
			{
				throw new ArgumentException("The number must be positive.");
			}
			return number.ToString().Length;
		}

		public int GetNumberOfAliquotThreeNotFive(int[] numbers)
		{
			int count = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] % 3 == 0 && numbers[i] % 5 != 0)
					count++;
			}
			return count;
		}

		public int[] SplitIntoFourSquares(int number)
		{
			int[] result = new int[4];

			//First result number.
			int a = (int)Math.Sqrt(number) - 1;
			while (a > 0)
			{
				//Second result number.
				int b = (int)Math.Sqrt(number - a * a) - 1;
				while (b > 0)
				{
					//Third result number.
					int c = (int)Math.Sqrt(number - a * a - b * b);
					while (c > 0)
					{
						//Fourth result number.
						int d = (int)Math.Sqrt(number - a * a - b * b - c * c);
						if (d < 1)
							c--;
						else
						{
							result[0] = a;
							result[1] = b;
							result[2] = c;
							result[3] = d;
							return result;
						}
					}
					b--;
				}
				a--;
			}
			throw new ArgumentException("Cannot split into 4 squares.");
		}
	}
}
