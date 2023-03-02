using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class SequenceEquation : IBaseClass
	{
		public void Invoke()
		{
			List<int> p = new List<int>();
			permutationEquation(p);
		}

		public static List<int> permutationEquation(List<int> p)
		{
			List<int> y = new List<int>();

			for (int x = 1; x <= p.Count; x++)
			{
				int a = p.IndexOf(x);
				int b = p.IndexOf(a + 1);

				if (p[p[b] - 1] == x)
					y.Add(b + 1);
			}

			return y;
		}
	}
}
