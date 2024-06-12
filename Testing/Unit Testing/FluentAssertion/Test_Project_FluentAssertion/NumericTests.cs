using FluentAssertions;
using FluentAssertions.Execution;

namespace Test_Project_FluentAssertion
{
	[TestClass]
	public class NumericTests

	{
		[TestMethod]
		public void ShouldBePositiveOrNegative()
		{
			int aPositiveNumber = 1;
			int aNegativeNumber = -1;

			aPositiveNumber.Should().BePositive();
			aPositiveNumber.Should().BeNegative();
		}

		[TestMethod]
		public void a()
		{
			double result = 1.345 * 100;

			result.Should().BeApproximately(134, 1);
		}
	}
}