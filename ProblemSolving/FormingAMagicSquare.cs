using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class FormingAMagicSquare : IBaseClass
	{
		public void Invoke()
		{
			List<List<int>> userMagicSquare = new List<List<int>>();
			formingMagicSquare(userMagicSquare);
		}

		public static readonly int[,,] magicSquareData = {
			{
				{ 6, 1, 8 },
				{ 7, 5, 3 },
				{ 2, 9, 4 }
			},
			{
				{ 2, 7, 6 },
				{ 9, 5, 1 },
				{ 4, 3, 8 }
			},
			{
				{ 4, 9, 2 },
				{ 3, 5, 7 },
				{ 8, 1, 6 }
			},
			{
				{ 8, 3, 4 },
				{ 1, 5, 9 },
				{ 6, 7, 2 }
			},
			{
				{ 2, 9, 4 },
				{ 7, 5, 3 },
				{ 6, 1, 8 }
			},
			{
				{ 6, 7, 2 },
				{ 1, 5, 9 },
				{ 8, 3, 4 }
			},
			{
				{ 8, 1, 6 },
				{ 3, 5, 7 },
				{ 4, 9, 2 }
			},
			{
				{ 4, 3, 8 },
				{ 9, 5, 1 },
				{ 2, 7, 6 }
			}
		};

		public static int formingMagicSquare(List<List<int>> userMagicSquare)
		{
			int actualCost = 0;

			for (int index = 0; index < magicSquareData.GetLength(0); index++)
			{
				int cost = 0;
				for (int y = 0; y < magicSquareData.GetLength(1); y++)
				{
					for (int x = 0; x < magicSquareData.GetLength(2); x++)
					{
						if (userMagicSquare[y][x] != magicSquareData[index, y, x])
						{
							cost += Math.Abs(userMagicSquare[y][x] - magicSquareData[index, y, x]);
						}
					}
				}

				if (index == 0 || actualCost > cost)
					actualCost = cost;
			}

			return actualCost;
		}
	}
}
