using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class ElectronicsShop : IBaseClass
	{
		public void Invoke()
		{
			int[] keyboards = { };
			int[] drives = { };
			int b = 50;
			getMoneySpent(keyboards, drives, b);
		}

		public static int getMoneySpent(int[] keyboards, int[] drives, int b)
		{
			int currentInBudgetPrice = 0;
			int highestPrice = 0;

			for (int i = 0; i < keyboards.Length; i++)
			{
				for (int j = 0; j < drives.Length; j++)
				{
					int price = drives[j] + keyboards[i];
					if (price <= b)
					{
						if (currentInBudgetPrice < price)
							currentInBudgetPrice = price;
					}

					if (highestPrice < price)
						highestPrice = price;
				}
			}

			if (highestPrice > b)
			{
				if (currentInBudgetPrice != 0 && currentInBudgetPrice <= b)
					return currentInBudgetPrice;
				return -1;
			}

			return currentInBudgetPrice;
		}
	}
}
