using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class NumberLineJumps : IBaseClass
	{
		public void Invoke()
		{
			int x1 = 0;
			int v1 = 3;
			int x2 = 4;
			int v2 = 2;
			kangaroo(x1, v1, x2, v2);
		}

		public static string kangaroo(int x1, int v1, int x2, int v2)
		{
			if (v1 > v2 && ( x1 - x2 ) % ( v1 - v2 ) == 0)
				return "YES";
			else
				return "NO";
		}
	}
}
