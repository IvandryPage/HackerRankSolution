using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class MinMaxSum : IBaseClass
	{
		public void Invoke()
		{
			List<int> arr = new List<int>() { 1, 2, 3, 4, 5 };
			minMaxSum(arr);
		}

		public static void minMaxSum(List<int> arr)
		{
			long min = 0;
			long max = 0;

			arr.Sort();

			for (int i = 0; i < 4; i++)
				min += arr[i];

			for (int i = arr.Count - 4; i <= 4; i++)
				max += arr[i];

			Console.WriteLine($"{min} {max}");
		}
	}
}
