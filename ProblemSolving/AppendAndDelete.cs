using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class AppendAndDelete : IBaseClass
	{
		public void Invoke()
		{
			string s = "qwerasdf";
			string t = "qwerbsdf";
			int k = 6;
			string res = appendAndDelete(s, t, k);
		}


		
		public static string appendAndDelete(string s, string t, int k)
		{
			int lastIndexOfSameCharacter = 0;
			while (lastIndexOfSameCharacter < s.Length && lastIndexOfSameCharacter < t.Length)
			{
				if (s[lastIndexOfSameCharacter] == t[lastIndexOfSameCharacter])
					lastIndexOfSameCharacter++;
			}

			int sameStringLength = lastIndexOfSameCharacter * 2;
			int minimumOperation = ( s.Length + t.Length ) - sameStringLength;

			if (k < minimumOperation)
				return "No";
			if (k >= s.Length + t.Length || ( k - minimumOperation ) % 2 == 0)
				return "Yes";
			return "No";
		}
	}
}
