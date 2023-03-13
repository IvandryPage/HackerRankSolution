using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class EqualizeArray : IBaseClass
	{
		public void Invoke()
		{
			List<int> arr = new List<int> { 1, 2, 2, 3 };

			// expected : 2
			equalizeArray(arr);
		}

		public static int equalizeArray(List<int> arr)
		{
			List<int> numbersInArray = arr.ToHashSet().ToList();

			int mostFrequent = 0;
			foreach(int num in numbersInArray)
			{
				int count = arr.Count(x => x == num);

				if (count > mostFrequent)
					mostFrequent = count;
			}

			return arr.Count - mostFrequent; // minimum delete operation
		}
	}
}
