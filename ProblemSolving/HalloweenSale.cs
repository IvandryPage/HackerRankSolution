using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class HalloweenSale : IBaseClass
	{
		public void Invoke()
		{
			howManyGames(20, 3, 6, 70);
		}

		public static int howManyGames(int p, int d, int m, int s)
		{
			// Return the number of games you can buy
			int totalBoughtGame = 0;

			bool runOutOfMoney = false;
			while(!runOutOfMoney)
			{
				int price = (p - d * totalBoughtGame > m) ? p - d * totalBoughtGame : m;
				if (s - price < 0)
					break;
				s -= price;
				totalBoughtGame++;
			}

			return totalBoughtGame;
		}
	}
}
