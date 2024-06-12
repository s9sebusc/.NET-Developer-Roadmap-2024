using Test_Project_NUnit;

namespace NUnit_Testproject
{
	public class CalculatorTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void AssertThatTest()
		{
			Calculator sut = new Calculator();

			int result = sut.Add(1, 2);

			Assert.That(result, Is.EqualTo(3), "Invalid calculation result for 1 + 2: ");
			Assert.That(result, Is.GreaterThan(2), "Invalid calculation result for 1 + 2: ");
		}

		[Test]
		public void MultipleAsserts()
		{
			Calculator sut = new Calculator();

			Assert.Multiple(() =>
			{
				Assert.DoesNotThrow(() => sut.Add(3, 3), "No exception expected for add");
				Assert.DoesNotThrow(() => sut.Multiply(1, 3), "No exception expected for multiplication");
			});

		}

		[Test]
		public void AssertCatchExceptionTest()
		{
			Calculator sut = new Calculator();

			Assert.Throws<ArgumentNullException>(() => sut.Subtract(null, null), "No exception expected for valid subtraction");
		}

		[Test]
		public void SpecialAssertPassAndFail()
		{
			Calculator sut = new Calculator();

			var result = sut.Add(0, 10);

			if (result == 10)
			{
				Assert.Pass();
			}
			else
			{
				Assert.Fail();
			}
		}

		[CancelAfter(1)]
		[Test]
		public void AttributesTest([Random(-10,10,1)] int x, [Random(-10, 10, 1)] int y)
		{
			Calculator sut = new Calculator();
			int result = sut.Add(x, y);

			Assert.That(result, Is.EqualTo(x + y), "Invalid calculation result for 1 + 2: ");
		}

		[Test]
		public void ConstraintTest()
		{
			Calculator sut = new Calculator();

			int result = sut.Add(10, 11);

			Assert.That(result, Is.AnyOf(21));
		}
	}
}