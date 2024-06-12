using FluentAssertions;
using FluentAssertions.Execution;

namespace Test_Project_FluentAssertion
{
	[TestClass]
	public class PersonTests
	{
		[TestMethod]
		[DataRow("Gerhard", "Schröder", "Gerhard Schröder")]
		[DataRow("Donald", "Trump", "Donald Trump")]
		public void ShouldBe(string firstName, string lastName, string fullName)
		{
			Person sut = new Person(fullName);

			sut.FirstName.Should().Be(firstName);
			sut.LastName.Should().Be(lastName);
			sut.FullName.Should().Be(fullName);
		}

		[TestMethod]
		public void ShouldAndTests()
		{
			const string FullName = "TestFirstName TestLastName";
			Person sut = new Person(FullName);

			sut.FullName.Should()
				.StartWith("T")
				.And
				.EndWith("e")
				.And
				.Contain(" ");
		}

		[TestMethod]
		public void ShouldBeNull()
		{
			Person sut = new Person(null);

			sut.FullName.Should().BeNull();
		}

		[TestMethod]
		public void ShouldHaveLength()
		{
			Person sut = new Person("A B");

			sut.FullName.Should().HaveLength(3); 
		}

		[TestMethod]
		public void ShouldContain()
		{
			Person sut = new Person("AAAAAAA BBBxxxBBBB");

			sut.FullName.Should().Contain("xxx");
			sut.FullName.Should().Contain("xxx", Exactly.Once());
		}
	}
}