using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class AngryProcessor : IBaseClass
	{
		public void Invoke()
		{
			int k = 0;
			List<int> a = new List<int>();
			angryProfessor(k, a);
		}

		public static string angryProfessor(int k, List<int> a)
		{
			int onTimeStudentCounter = 0;
			for (int i = 0; i < a.Count; i++)
			{
				if (a[i] <= 0)
					onTimeStudentCounter++;
			}

			return ( onTimeStudentCounter < k ) ? "YES" : "NO";
		}
	}
}
