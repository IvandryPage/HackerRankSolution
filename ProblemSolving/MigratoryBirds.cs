using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class MigratoryBirds : IBaseClass
	{
		public void Invoke()
		{
			List<int> arr = new List<int>();
			migratoryBirds(arr);
		}

		public static int migratoryBirds(List<int> arr)
		{
			var distinctValue = arr.Distinct().ToList();

			int[] currentFrequent = new int[2] { 0, 0 };

			for (int i = 0; i < distinctValue.Count; i++)
			{
				int counter = 0;
				for (int j = 0; j < arr.Count; j++)
				{
					if (distinctValue[i] == arr[j])
						counter++;
				}

				if (counter > currentFrequent[1])
				{
					currentFrequent[0] = distinctValue[i];
					currentFrequent[1] = counter;
				}

				if (counter == currentFrequent[1])
				{
					if (currentFrequent[0] > distinctValue[i])
					{
						currentFrequent[0] = distinctValue[i];
					}
				}
			}

			return currentFrequent[0];
		}
	}
}
