using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class PlusMinus : IBaseClass
	{
		public void Invoke()
		{
			List<int> arr = new List<int>();
			plusMinus(arr);
		}

		public static void plusMinus(List<int> arr)
		{
			List<int> counter = new List<int>() { 0, 0, 0 }; // positive, negative, zero

			for (int i = 0; i < arr.Count; i++)
			{
				if (arr[i] == 0)
					counter[2] += 1;
				else if (arr[i] < 0)
					counter[1] += 1;
				else
					counter[0] += 1;
			}

			foreach (int num in counter)
			{
				decimal result = (decimal)num / arr.Count;
				Console.WriteLine(result.ToString("N6"));

			}
		}
	}
}
