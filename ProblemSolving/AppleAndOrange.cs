using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class AppleAndOrange : IBaseClass
	{
		public void Invoke()
		{
			int s = 5;
			int t = 5;
			int a = 2;
			int b = 3;
			List<int> apples = new List<int>();
			List<int> oranges = new List<int>();
			countApplesAndOranges(s, t, a, b, apples, oranges);
		}

		public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
		{
			int distanceFromTree;
			int appleCounter = 0;
			int orangeCounter = 0;

			for (int i = 0; i < apples.Count; i++)
			{
				distanceFromTree = a + apples[i];

				if (distanceFromTree >= s && distanceFromTree <= t)
					appleCounter++;
			}

			for (int i = 0; i < oranges.Count; i++)
			{
				distanceFromTree = b + oranges[i];

				if (distanceFromTree >= s && distanceFromTree <= t)
					orangeCounter++;
			}

			Console.WriteLine($"{appleCounter}\n{orangeCounter}");
		}
	}
}
