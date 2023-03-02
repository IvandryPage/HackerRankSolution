using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class BetweenTwoSets : IBaseClass
	{
		public void Invoke()
		{
			List<int> a = new List<int>();
			List<int> b = new List<int>();
			getTotalX(a, b);
		}

		public static int getTotalX(List<int> a, List<int> b)
		{
			int counter = 0;
			for (int consideredInteger = 1; consideredInteger <= 100; consideredInteger++)
			{
				bool isFactor = true;
				for (int index = 0; index < a.Count; index++)
				{
					if (consideredInteger % a[index] != 0)
					{
						isFactor = false;
						break;
					}
				}

				if (isFactor)
				{
					for (int index = 0; index < b.Count; index++)
					{
						if (b[index] % consideredInteger != 0)
						{
							isFactor = false;
							break;
						}
					}
				}

				if (isFactor)
					counter++;
			}
			return counter;
		}
	}
}
