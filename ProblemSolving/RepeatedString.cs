using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class RepeatedString : IBaseClass
	{
		public void Invoke()
		{
			string s = "bcbccacaacbbacabcabccacbccbababbbbabcccbbcbcaccababccbcbcaabbbaabbcaabbbbbbabcbcbbcaccbccaabacbbacbc";
			long n = 649606239668;

			// expected : 162401559918
			repeatedString(s, n);
		}

		public static long repeatedString(string s, long n)
		{
			long aCharacter = s.Count(x => x == 'a');

			long loop = n / s.Length;
			long left = n % s.Length;

			aCharacter *= loop;
			aCharacter += s.Substring(0, Convert.ToInt32(left))
				.Count(x => x == 'a');

			return aCharacter;
		}
	}
}
