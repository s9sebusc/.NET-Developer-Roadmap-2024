namespace Test_Project_nSubstitute
{
	public class Calculator : ICalculator
	{
		public int Add(int x, int y)
		{
			return x + y;
		}

		public int Subtract(int? x, int? y)
		{
			if (x == null) throw new ArgumentNullException(nameof(x), "Mustn't be null");
			if (y == null) throw new ArgumentNullException(nameof(y), "Mustn't be null");

			return x.Value - y.Value;
		}

		public int Multiply(int x, int y)
		{
			return x * y;
		}
	}
}
