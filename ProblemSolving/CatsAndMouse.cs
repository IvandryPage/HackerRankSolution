using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class CatsAndMouse : IBaseClass
	{
		public void Invoke()
		{
			int catAPosition = 5;
			int catBPosition = 1;
			int mousePosition = 10;
			catAndMouse(catAPosition, catBPosition, mousePosition);
		}

		static string catAndMouse(int catAPosition, int catBPosition, int mousePosition)
		{
			int diffA = Math.Abs(catAPosition - mousePosition);
			int diffB = Math.Abs(catBPosition - mousePosition);

			if (diffA > diffB)
				return "Cat B";
			if (diffA < diffB)
				return "Cat A";
			return "Mouse C";
		}
	}
}
