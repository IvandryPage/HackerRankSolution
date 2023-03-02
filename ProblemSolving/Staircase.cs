using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class Staircase : IBaseClass
	{
		public void Invoke()
		{
			int n = 5;
			staircase(n);
		}

		public static void staircase(int n)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n - 1; j++)
					Console.Write(" ");
				for (int j = n - i; j <= n; j++)
					Console.Write("#");

				Console.WriteLine();
			}
		}
	}
}
