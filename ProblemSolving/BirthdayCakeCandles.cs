using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class BirthdayCakeCandles : IBaseClass
	{
		public void Invoke()
		{
			List<int> candles = new List<int>();
			birthdayCakeCandles(candles);
		}

		public static int birthdayCakeCandles(List<int> candles)
		{
			candles.Sort();
			int counter = 0;

			for (int i = 0; i < candles.Count; i++)
			{
				if (candles[i] == candles[candles.Count - 1])
					counter++;
			}
			return counter;
		}
	}
}
