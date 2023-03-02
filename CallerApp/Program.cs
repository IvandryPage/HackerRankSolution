using ProblemSolving;

namespace Caller
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var problemSolver = new ElectronicsShop();
			problemSolver.Invoke();

			Console.ReadKey(true);
		}
	}
}