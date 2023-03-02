using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class SolveMeFirst : IBaseClass
	{
		static int solveMeFirst(int a, int b)
		{
			return a + b;
		}

		public void Invoke()
		{
			solveMeFirst(2, 3);
		}
	}
}
