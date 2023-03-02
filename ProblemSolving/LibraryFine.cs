using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class LibraryFine : IBaseClass
	{
		public void Invoke()
		{
			int d1 = 1;
			int m1 = 12;
			int y1 = 98;
			int d2 = 2;
			int m2 = 11;
			int y2 = 99;
			libraryFine(d1, m1, y1, d2, m2, y2);
		}

		public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
		{
			DateTime expectedReturnDate = new DateTime(y2, m2, d2);
			DateTime returnedDate = new DateTime(y1, m1, d1);

			if (expectedReturnDate >= returnedDate)
				return 0;
			else if (expectedReturnDate.Month == returnedDate.Month && expectedReturnDate.Year == returnedDate.Year)
				return 15 * ( (int)returnedDate.Day - (int)expectedReturnDate.Day );
			else if (expectedReturnDate.Year == returnedDate.Year)
				return 500 * ( (int)returnedDate.Month - (int)expectedReturnDate.Month );

			return 10000;
		}
	}
}
