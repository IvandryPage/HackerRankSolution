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
		public void Same_Value_As_Expected_Using_TestCases_Parameter()
		{
			//ARRANGE

			//ACT

			//ASSERT

		}
	}
}