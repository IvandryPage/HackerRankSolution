using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class NonDivisibleSubset : IBaseClass
	{
		public void Invoke()
		{
			int k = 3;
			List<int> s = new List<int>() { 1, 7, 2, 4 };
			nonDivisibleSubset(k, s);
		}

		public static int nonDivisibleSubset(int k, List<int> s)
		{
			int count = 0;
			int[] possibleIndexRemainders = new int[k];
			List<int> distinctNumbers = s.ToHashSet().ToList();

			for(int i = 0; i < distinctNumbers.Count; i++)
			{
				int remainder = distinctNumbers[i] % k;
				possibleIndexRemainders[remainder] += 1;
			}


			return count;

			//var remainders = new int[k];
			//int count = 0;

			//s.ForEach(x => remainders[x % k]++);

			//for (var j = 1; j <= ( k / 2 ); j++)
			//{
			//	if (j == k - j)
			//		count++;
			//	else
			//		count += Math.Max(remainders[j], remainders[k - j]);
			//}

			//if (remainders[0] > 0)
			//	count++;

			//return count;
		}
	}
}