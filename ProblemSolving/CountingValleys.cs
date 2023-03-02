using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class CountingValleys : IBaseClass
	{
		public void Invoke()
		{
			int steps = 8;
			string path = "UDDDUDUU";
			countingValleys(steps, path);
		}

		public static int countingValleys(int steps, string path)
		{
			char[] stepStrings = path.ToCharArray();

			int hikerPosition = 0; // sea-level = 0
			int valleyCounter = 0;
			bool isEnterValley = false;

			for (int i = 0; i < steps; i++)
			{
				if (stepStrings[i] == 'U')
					hikerPosition += 1;
				else if (stepStrings[i] == 'D')
					hikerPosition -= 1;

				if (hikerPosition < 0)
				{
					isEnterValley = true;
				}

				if (isEnterValley == true && hikerPosition >= 0)
				{
					valleyCounter += 1;
					isEnterValley = false;
				}
			}
			return valleyCounter;
		}
	}
}
