using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class SubarrayDivision : IBaseClass
	{
		public void Invoke()
		{
			List<int> segment = new List<int>();
			int day = 1;
			int month = 1;
			birthday(segment, day, month);
		}

		public static int birthday(List<int> segment, int day, int month)
		{
			int counter = 0;

			int index = 0;
			do
			{
				int sum = 0;

				for (int iteration = index; iteration < index + month; iteration++)
				{
					sum += segment[iteration];
				}

				if (sum == day)
					counter++;

				index++;
			} while (index < segment.Count - month + 1);

			return counter;
		}
	}
}
