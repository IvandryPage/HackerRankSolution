using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class AcmIcpcTeam : IBaseClass
	{
		public void Invoke()
		{
			List<string> topics = new List<string>
			{
				"10101",
				"11100",
				"11010",
				"00101",
				"11111"
			};

			acmTeam(topics);
		}

		public static List<int> acmTeam(List<string> topic)
		{
			//result[0]:maxTopic, result[1]:teamCounter
			List<int> result = new List<int>() { 0, 0 };

			for(int i = 0; i < topic.Count - 1; i++)
			{
				for (int j = i + 1; j < topic.Count; j++)
				{
					int knownTopic = 0;
					for(int k = 0; k < topic[i].Length || k < topic[j].Length; k++)
					{
						if (topic[i][k] == '1' || topic[j][k] == '1')
							knownTopic++;
					}

					if (result[0] < knownTopic)
					{
						result[0] = knownTopic;
						result[1] = 0;
					}

					if (j != 1 && result[0] == knownTopic)
						result[1]++;
				}
			}

			return result;
		}
	}
}
