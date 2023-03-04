using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class ClimbingTheLeaderboard : IBaseClass
	{
		public void Invoke()
		{
			List<int> leaderboardScores = new List<int>() { 100, 100, 50, 40, 40, 20, 10 };
			List<int> player = new List<int>() { 5, 25, 50, 105 };
			climbingLeaderboard(leaderboardScores, player);
		}

		public static List<int> climbingLeaderboard(List<int> leaderboardScores, List<int> player)
		{
			List<int> rankResult = new List<int>();
			List<int> noDuplicateLeaderboardScores = leaderboardScores.ToHashSet().ToList();

			int rankIndex = noDuplicateLeaderboardScores.Count - 1;
			for(int i = 0; i < player.Count; i++)
			{
				bool rankFound = false;
				for (; rankIndex >= 0; rankIndex--)
				{
					if (player[i] < noDuplicateLeaderboardScores[rankIndex])
					{
						rankResult.Add(rankIndex + 2);
						rankFound = true;
						break;
					}
					else if (player[i] == noDuplicateLeaderboardScores[rankIndex])
					{
						rankResult.Add(rankIndex + 1);
						rankFound = true;
						break;
					}
				}

				if (!rankFound)
				{
					rankResult.Add(1);
				}
			}

			// Expected : 6 4 2 1
			return rankResult;
		}
	}
}
