using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class FindDigits : IBaseClass
	{
		public void Invoke()
		{
			int n = 1000;
			findDigits(n);
		}

		public static int findDigits(int n)
		{
			List<int> divisor = new List<int>();

			int i = 0;
			int tempNum = n;
			while (tempNum > 0)
			{
				divisor.Add(tempNum % 10);
				tempNum = tempNum / 10;
				i++;
			}

			int counter = 0;
			for (i = 0; i < divisor.Count; i++)
			{
				if (divisor[i] != 0 && ( n % divisor[i] ) == 0)
					counter++;
			}

			return counter;
		}
	}
}
