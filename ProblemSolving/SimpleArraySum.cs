using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class SimpleArraySum : IBaseClass
	{
		public static int simpleArraySum(List<int> ar)
		{
			int result = 0;
			foreach (int number in ar)
			{
				result += number;
			}

			return result;
		}

		public void Invoke()
		{
			List<int> ar = new List<int>() { 1, 2, 3, 4, 10, 11 };
			simpleArraySum(ar);
		}
	}
}
