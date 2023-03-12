using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class CutTheSticks : IBaseClass
	{
		public void Invoke()
		{
			List<int> arr = new List<int>() { 5, 4, 4, 2, 2, 8};
			cutTheSticks(arr);
		}

		public static List<int> cutTheSticks(List<int> arr)
		{
			List<int> result = new List<int>();

			while (arr.Count > 0)
			{
				result.Add(arr.Count);
				int minimum = arr.Min();

				arr.RemoveAll(x => x == minimum);
				for(int i = 0; i < arr.Count; i++)
				{
					arr[i] -= minimum;
				}
			}

			return result;
		}
	}
}
