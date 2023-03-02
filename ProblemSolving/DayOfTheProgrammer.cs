using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class DayOfTheProgrammer : IBaseClass
	{
		public void Invoke()
		{
			int year = 2023;
			dayOfProgrammer(year);
		}

		public static string dayOfProgrammer(int year)
		{
			int day = 0, month = 0, programmerDay = 256;
			bool isLeap = false;
			bool isTransition = false;

			if (year < 1918)
			{
				if (year % 4 == 0)
					isLeap = true;
			}
			else if (year > 1918)
			{
				if (year % 400 == 0 || ( year % 4 == 0 && year % 100 != 0 ))
					isLeap = true;
			}
			else
			{
				isTransition = true;
				programmerDay -= 17;
			}

			int sum = 0;
			for (int i = 1; i <= 12; i++)
			{
				int totalDaysInMonth = 0;

				if (i % 2 != 0)
					totalDaysInMonth = 31;
				else if (i != 2 && i % 2 == 0)
					totalDaysInMonth = 30;
				else if (i == 2)
					totalDaysInMonth = ( isLeap ) ? 29 : 28;

				if (sum + totalDaysInMonth >= programmerDay)
				{
					day = programmerDay - sum - 1;
					if (isTransition)
						month = i + 1;
					else
						month = i;
					break;
				}

				sum += totalDaysInMonth;
			}

			return $"{day.ToString("00")}.{month.ToString("00")}.{year.ToString("0000")}";
		}
	}
}
