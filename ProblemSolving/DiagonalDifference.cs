using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class DiagonalDifference : IBaseClass
	{
		public void Invoke()
		{
			List<List<int>> arr = new List<List<int>>();
			diagonalDifference(arr);
		}

		public static int diagonalDifference(List<List<int>> arr)
		{
			int result = 0;
			for (int i = 0; i < arr.Count; i++)
			{
				result += ( arr[i][i] - arr[i][arr.Count - i - 1] );
			}

			return Math.Abs(result);
		}
	}
}
