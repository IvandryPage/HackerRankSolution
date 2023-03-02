using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class TimeConversion : IBaseClass
	{
		public void Invoke()
		{
			string s = "12:00PM";
			timeConversion(s);
		}

		public static string timeConversion(string s)
		{
			string period = s.Substring(8, 2);
			int h = Convert.ToInt16(s.Substring(0, 2));

			if (period.ToLower() == "pm")
			{
				if (h == 24)
					h = 0;
				else if (h != 12)
					h += 12;
			}
			else
			{
				if (h == 12)
					h = 0;
			}

			return h.ToString("00") + s.Substring(2, 6);
		}
	}
}
