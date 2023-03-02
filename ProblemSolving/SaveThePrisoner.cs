using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class SaveThePrisoner : IBaseClass
	{
		public void Invoke()
		{
			int n = 1;
			int m = 1;
			int s = 1;

			saveThePrisoner(n, m, s);
		}

		public static int saveThePrisoner(int n, int m, int s)
		{
			int result = ( s + m - 1 ) % n;
			return ( result != 0 ) ? result : n;
		}
	}
}
