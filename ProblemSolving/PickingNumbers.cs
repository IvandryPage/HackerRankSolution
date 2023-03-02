using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class PickingNumbers : IBaseClass
	{
		public void Invoke()
		{
			List<int> a = new List<int>();
			pickingNumbers(a);
		}

		public static int pickingNumbers(List<int> a)
		{
			a.Sort();
			List<List<int>> subarray = new List<List<int>>();
			List<int> numbers = a.Distinct().ToList();
			List<int> aSubstitute = a;

			foreach (int number in numbers)
			{
				List<int> arr = new List<int>();

				int i = 0;
				while (i < a.Count)
				{
					if (number == aSubstitute[i] || number - aSubstitute[i] == 1)
					{
						arr.Add(aSubstitute[i]);
					}

					i++;
				}

				subarray.Add(arr);
			}

			int longestSubarray = 2;
			for (int i = 0; i < subarray.Count; i++)
			{
				if (subarray[i].Count > longestSubarray)
					longestSubarray = subarray[i].Count;
			}

			return longestSubarray;
		}
	}
}
