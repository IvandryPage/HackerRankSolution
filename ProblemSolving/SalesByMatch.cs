using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class SalesByMatch : IBaseClass
	{
		public void Invoke()
		{
			int n = 20;
			List<int> ar = new List<int>();
			sockMerchant(n, ar);
		}
		public static int sockMerchant(int n, List<int> ar)
		{
			List<int> arr = ar.Distinct().ToList();
			ar.Sort();

			int pairsCounter = 0;
			for (int i = 0; i < arr.Count; i++)
			{
				int totalMatchedNumber = 0;
				for (int j = 0; j < ar.Count; j++)
				{
					if (arr[i] == ar[j])
						totalMatchedNumber += 1;
				}

				if (totalMatchedNumber % 2 == 0)
					pairsCounter += totalMatchedNumber / 2;
				else
					pairsCounter += Convert.ToInt16(Math.Floor((double)totalMatchedNumber / 2));
			}

			return pairsCounter;
		}
	}
}
