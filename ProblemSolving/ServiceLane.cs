using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class ServiceLane : IBaseClass
	{
		public void Invoke()
		{
			List<int> width = new List<int>()
			{
				2, 3, 1, 2, 3, 2, 3, 3 
			};

			List<List<int>> cases = new List<List<int>>()
			{
				new List<int>() { 0, 3 }, 
				new List<int>() { 4, 6 }, 
				new List<int>() { 6, 7 }, 
				new List<int>() { 3, 5 }, 
				new List<int>() { 0, 7 }
			};

			serviceLane(width, cases);
		}

		public static List<int> serviceLane(List<int> width, List<List<int>> cases)
		{
			List<int> maxWidths = new();

			for(int i = 0; i < cases.Count; i++)
			{
				List<int> laneWidths = new List<int>();
				for(int j = cases[i][0]; j <= cases[i][1]; j++)
				{
					laneWidths.Add(width[j]);
				}
				laneWidths.Sort();
				maxWidths.Add(laneWidths[0]);
			}

			return maxWidths;
		}
	}
}
