using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class CircularArrayRotation : IBaseClass
	{
		public void Invoke()
		{
			List<int> a = new List<int>();
			int k = 5;
			List<int> queries = new List<int>();
			circularArrayRotation(a, k, queries);
		}

		public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
		{
			List<int> result = new List<int>();

			int rotations = k % a.Count;

			List<int> rotated = a.GetRange(a.Count - rotations, rotations);
			rotated.AddRange(a.GetRange(0, a.Count - rotations));

			for (int i = 0; i < queries.Count; i++)
			{
				result.Add(rotated[queries[i]]);
			}

			return result;
		}
	}
}
