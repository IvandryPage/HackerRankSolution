using NUnit.Framework;

namespace UnitTestSolution
{
	public class ProblemSolvingTests
	{

		[Test]
		public void Same_Value_As_Expected()
		{
			//ARRANGE
			var param1 = new List<string>() {
				"10101",
				"11100",
				"11010",
				"00101",
				"11111"
			};

			var expected = new List<int>() { 5, 6 };

			//ACT
			var actual = AcmIcpcTeam.acmTeam(param1);

			// ASSERT
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		[TestCase(10, 2, 5, 6)]
		[TestCase(12, 4, 4, 3)]
		[TestCase(6, 2, 2, 5)]
		public void Same_Value_As_Expected_Using_TestCases_Parameter(int n, int c, int m, int expected)
		{
			//ARRANGE

			//ACT
			int actual = ChocolateFeast.chocolateFeast(n, c, m);

			//ASSERT
			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}