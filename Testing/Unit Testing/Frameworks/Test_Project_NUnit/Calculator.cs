using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_NUnit
{
	public class Calculator
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
