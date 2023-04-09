using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class ChocolateFeast : IBaseClass
	{
		public void Invoke()
		{
			int n = 0;
			int c = 0;
			int m = 0;
			chocolateFeast(n, c, m);
		}

		public static int chocolateFeast(int n, int c, int m)
		{
			int totalChocolate = n / c;
			int wrapper = totalChocolate;

			while(wrapper >= m)
			{
				int exchangedChocolate = wrapper / m;
				totalChocolate += exchangedChocolate;
				wrapper = wrapper % m + exchangedChocolate;
			}

			return totalChocolate;
		}
	}
}
