using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class VeryBigSum : IBaseClass
	{
		public void Invoke()
		{
			List<long> ar = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
			aVeryBigSum(ar);
		}

		public static long aVeryBigSum(List<long> ar)
		{
			long result = 0;
			foreach (long num in ar)
				result += num;
			return result;
		}
	}
}
