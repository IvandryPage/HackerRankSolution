using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class BreakingTheRecords : IBaseClass
	{
		public void Invoke()
		{
			List<int> scores = new List<int>();
			breakingRecords(scores);
		}

		public static List<int> breakingRecords(List<int> scores)
		{
			int[] countMaxMin = new int[2] { 0, 0 };

			int min, max;
			min = max = scores[0];

			foreach (int score in scores)
			{
				if (score > max)
				{
					max = score;
					countMaxMin[0] += 1;
				}

				if (score < min)
				{
					min = score;
					countMaxMin[1] += 1;
				}
			}

			return countMaxMin.ToList();
		}
	}
}
