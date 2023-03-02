using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class BeautifulDaysMovies : IBaseClass
	{
		public void Invoke()
		{
			int i = 9;
			int j = 10;
			int k = 10;
			beautifulDays(i, j, k);
		}

		public static int beautifulDays(int i, int j, int k)
		{
			int beautifulDayCounter = 0;
			for (int iteration = i; iteration <= j; iteration++)
			{
				int difference = Math.Abs(iteration - ReverseNumber(iteration));
				double n = difference / (double)k;
				if (n % 1 == 0)
					beautifulDayCounter += 1;
			}

			return beautifulDayCounter;
		}

		public static int ReverseNumber(int i)
		{
			int reversed = 0;
			do
			{
				int tempNum = i % 10;
				reversed = reversed * 10 + tempNum;
				i /= 10;
			} while (i > 0);
			return reversed;
		}
	}
}
