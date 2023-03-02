using ProblemSolving;

namespace Caller
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var problemSolver = new PlusMinus();
			problemSolver.Invoke();

			Console.ReadKey(true);
		}
	}
}