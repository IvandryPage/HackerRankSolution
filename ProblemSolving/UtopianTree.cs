using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class UtopianTree : IBaseClass
	{
		public void Invoke()
		{
			int n = 5;
			utopianTree(n);
		}

		public static int utopianTree(int n)
		{
			int initialHeight = 1;

			for (int i = 1; i <= n; i++)
			{
				if (i % 2 == 1)
				{
					initialHeight *= 2;
					continue;
				}

				initialHeight += 1;
			}

			return initialHeight;
		}
	}
}
