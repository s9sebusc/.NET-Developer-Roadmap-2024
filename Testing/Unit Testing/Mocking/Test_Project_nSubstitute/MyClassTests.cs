using NSubstitute;

namespace Test_Project_nSubstitute
{
	[TestClass]
	public class MyClassTests
	{
		[TestMethod]
		public void MockAdd()
		{
			// ARRANGE
			const int ExpectedValue = 99;
			ICalculator? calculatorMock = Substitute.For<ICalculator, IDummyInterface>();
			calculatorMock.Add(Arg.Any<int>(), Arg.Any<int>()).Returns(ExpectedValue);

			// ACT
			MyClass sut = new MyClass(calculatorMock);
			int result = sut.Add(default, default);

			// ASSERT
			Assert.AreEqual(ExpectedValue, result, "Invalid value");
		}

		[TestMethod]
		public void MultipleMocks()
		{
			// ARRANGE
			ICalculator? calculatorMock = Substitute.For<ICalculator, IDummyInterface>();
			IDummyInterface dummyInterfaceMock = (IDummyInterface)calculatorMock;
		}


		[TestMethod]
		public void MultipleReturn()
		{
			// ARRANGE
			ICalculator? calculatorMock = Substitute.For<ICalculator>();
			calculatorMock.Add(Arg.Any<int>(), Arg.Any<int>()).Returns(1, 2, 3); // 1. Run: returns 1, 2. Run: returns 2...

			Assert.AreEqual(1, calculatorMock.Add(default, default));
			Assert.AreEqual(2, calculatorMock.Add(default, default));
			Assert.AreEqual(3, calculatorMock.Add(default, default));
		}
	}
}