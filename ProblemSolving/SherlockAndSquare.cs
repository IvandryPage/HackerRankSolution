using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class SherlockAndSquare : IBaseClass
	{
		public void Invoke()
		{
			int a = 0;
			int b = 2;
			squares(a, b);
		}

		public static int squares(int a, int b)
		{
			int counter = 0;
			for (int i = 1; i * i <= b; i++)
			{
				if (i * i >= a)
					counter++;
			}
			return counter;
		}
	}
}
