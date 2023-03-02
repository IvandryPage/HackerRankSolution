using ProblemSolving;

namespace Caller
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var problemSolver = new DiagonalDifference();
			problemSolver.Invoke();

			Console.ReadKey(true);
		}
	}
}