using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class ModifiedKaprekarNumber : IBaseClass
	{
		public void Invoke()
		{
			int p = 1;
			int q = 100;
			// Expected Result : 1 9 45 55 99
			KaprekarNumbers(p, q);
		}

		public static void KaprekarNumbers(int p, int q)
		{
			bool FoundAtleastOneKaprekar = false;
			for(int i = p; i <= q; i++)
			{
				int d = i.ToString().Length;
				string squaredNum = Math.Pow(i, 2).ToString();
				string l = squaredNum.Substring(0, squaredNum.Length - d);
				string r = squaredNum.Substring(squaredNum.Length - d);

				int lNum = ( !string.IsNullOrEmpty(l) ) ? Convert.ToInt32(l) : 0;
				int rNum = ( !string.IsNullOrEmpty(r) ) ? Convert.ToInt32(r) : 0;

				if ( lNum + rNum == i )
				{
					if (!FoundAtleastOneKaprekar)
						FoundAtleastOneKaprekar = true;
					Console.Write($"{i} ");
				}
			}

			if (!FoundAtleastOneKaprekar)
				Console.WriteLine("INVALID RANGE");
		}
	}
}
