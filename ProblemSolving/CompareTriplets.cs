using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class CompareTriplets : IBaseClass
	{
		public static List<int> compareTriplets(List<int> a, List<int> b)
		{
			List<int> result = new List<int>() { 0, 0 };
			for (int i = 0; i < a.Count && i < b.Count; i++)
			{
				if (a[i] > b[i])
					result[0] += 1;
				if (a[i] < b[i])
					result[1] += 1;
			}

			return result;
		}

		public void Invoke()
		{
			List<int> a = new List<int>() { 5, 6, 7};
			List<int> b = new List<int>() { 3, 6, 10 };

			compareTriplets(a, b);
		}
	}
}
