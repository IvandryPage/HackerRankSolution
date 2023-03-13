using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class JumpingOnClouds : IBaseClass
	{
		public void Invoke()
		{
			List<int> c = new List<int>() { 0, 0, 0, 0, 1, 0 };

			//expected : 4
			jumpingOnClouds(c);
		}

		public static int jumpingOnClouds(List<int> c)
		{
			int stepCounter = 0;

			int currentCloudPosition = 0;

			while(currentCloudPosition != c.Count - 1)
			{
				if (currentCloudPosition != c.Count - 2 && c[currentCloudPosition + 2] == 0)
					currentCloudPosition += 2;
				else
					currentCloudPosition += 1;

				stepCounter++;
			}

			return stepCounter;
		}
	}
}
