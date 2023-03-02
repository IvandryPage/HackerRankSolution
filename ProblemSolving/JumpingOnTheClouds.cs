using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class JumpingOnTheClouds : IBaseClass
	{
		public void Invoke()
		{
			int[] c = { 0, 0, 0, 1, 1, 0, 1, 0 };
			int k = 5;
			jumpingOnClouds(c, k);
		}

		static int jumpingOnClouds(int[] c, int k)
		{
			int energy = 100;
			int energyConsumption = 0;

			int position = 0;
			do
			{
				energyConsumption += 1;

				if (c[position] == 1)
					energyConsumption += 2;

				if (position + k >= c.Length)
					position = position + k - c.Length;
				else
					position += k;
			} while (position != 0);

			return energy - energyConsumption;
		}
	}
}
