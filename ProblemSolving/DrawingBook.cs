using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class DrawingBook : IBaseClass
	{
		public void Invoke()
		{
			int n = 10;
			int p = 200;

			pageCount(n, p);
		}

		public static int pageCount(int n, int p)
		{
			int steps = 0;

			int[] currentPage;
			bool found = false;

			bool fromFront = false;
			if (n - p > p - 1)
			{
				currentPage = new int[2] { 0, 1 };
				fromFront = true;
			}
			else
			{
				if (n % 2 != 0)
					currentPage = new int[2] { n - 1, n };
				else
					currentPage = new int[2] { n, n + 1 };
			}

			while (!found)
			{
				if (p == currentPage[0] || p == currentPage[1])
					found = true;
				else
				{
					if (fromFront)
					{
						currentPage[0] += 2;
						currentPage[1] += 2;
					}
					else
					{
						currentPage[0] -= 2;
						currentPage[1] -= 2;
					}
					steps += 1;
				}
			}

			return steps;
		}
	}
}
