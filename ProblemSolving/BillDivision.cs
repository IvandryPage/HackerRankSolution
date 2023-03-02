using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class BillDivision : IBaseClass
	{
		public void Invoke()
		{
			List<int> bill = new List<int>();
			int k = 10;
			int b = 20;

			bonAppetit(bill, k, b);
		}

		public static void bonAppetit(List<int> bill, int k, int b)
		{
			int totalBill = 0;
			int charge = 0;

			for (int i = 0; i < bill.Count; i++)
			{
				totalBill += bill[i];
				if (i == k)
					continue;
				charge += bill[i];
			}

			if (charge / 2 == b)
				Console.WriteLine("Bon Appetit");
			else
				Console.WriteLine(Math.Abs(b - ( charge / 2 )));
		}
	}
}