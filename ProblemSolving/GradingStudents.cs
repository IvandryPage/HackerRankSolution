using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class GradingStudents : IBaseClass
	{
		public void Invoke()
		{
			List<int> grades = new List<int>();
			gradingStudents(grades);
		}

		public static List<int> gradingStudents(List<int> grades)
		{
			List<int> roundedGrades = new List<int>();
			foreach (int grade in grades)
			{
				if (grade < 38 || ( grade + 5 ) % 5 < 3)
				{
					roundedGrades.Add(grade);
				}
				else
				{
					int roundedGrade = grade + ( 5 - ( grade % 5 ) );
					roundedGrades.Add(roundedGrade);
				}
			}

			return roundedGrades;
		}
	}
}
