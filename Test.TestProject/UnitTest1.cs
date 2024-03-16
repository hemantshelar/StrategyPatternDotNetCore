using TestProject;

namespace Test.TestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void when_dad_is_passed_to_IsPalindrom_it_should_return_true()
		{
			// Arrange
			var predictor = new Predictor();
			var input = "DAD";
			bool expected = true;


			// Act
			var actualValue = predictor.IsPalindrom(input);

			// Assert
			Assert.AreEqual(expected, actualValue);
		}
	}
}