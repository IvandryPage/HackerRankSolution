using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class DesignerPDFViewer : IBaseClass
	{
		public void Invoke()
		{
			List<int> h = new List<int>();
			string word = "hackerrank";
			designerPdfViewer(h, word);
		}

		public static int designerPdfViewer(List<int> h, string word)
		{
			int maxHeight = 0;

			for (int i = 0; i < word.Length; i++)
			{
				int index = Convert.ToInt32(word[i]) - Convert.ToInt32('a');
				if (maxHeight < h[index])
					maxHeight = h[index];
			}

			return maxHeight * word.Length;
		}
	}
}
