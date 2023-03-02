using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class ViralAdvertising : IBaseClass
	{
		public void Invoke()
		{
			viralAdvertising(5);
		}

		public static int viralAdvertising(int n)
		{
			double liked = 2;
			int cumulative = Convert.ToInt32(liked);

			for (int i = 1; i < n; i++)
			{
				double shared = liked * 3;
				liked = Math.Floor((double)( shared / 2 ));
				cumulative += Convert.ToInt32(liked);
			}

			return cumulative;
		}
	}
}
