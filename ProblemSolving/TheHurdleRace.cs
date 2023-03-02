using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class TheHurdleRace : IBaseClass
	{
		public void Invoke()
		{
			int k = 0;
			List<int> height = new List<int>();
			hurdleRace(k, height);
		}

		public static int hurdleRace(int k, List<int> height)
		{
			int maxHurdle = 0;

			for (int i = 0; i < height.Count; i++)
			{
				if (maxHurdle < height[i])
					maxHurdle = height[i];
			}

			// Or simply use maxHurdle = height.Max();

			return ( k < maxHurdle ) ? maxHurdle - k : 0;
		}
	}
}
