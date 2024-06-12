using FluentAssertions;
using FluentAssertions.Execution;

namespace Test_Project_FluentAssertion
{
	[TestClass]
	public class DummyClassTests
	{
		[TestMethod]
		public void ShouldBePositiveOrNegative()
		{
			DummyClass sut = new DummyClass();

			sut.Invoking(x => x.DummyMethodThrowingException())
				.Should()
				.Throw<NotImplementedException>()
				.WithMessage("A dummy exception message");
		}
	}
}