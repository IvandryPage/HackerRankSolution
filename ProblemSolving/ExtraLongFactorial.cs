using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class ExtraLongFactorial : IBaseClass
	{
		public void Invoke()
		{
			int n = 90;
			extraLongFactorials(n);
		}

		public static void extraLongFactorials(int n)
		{
			Console.WriteLine(factorial(n));
		}

		private static BigInteger factorial(BigInteger n)
		{
			if (n <= 1)
				return 1;
			return n * factorial(n - 1);
		}
	}
}
