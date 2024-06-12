using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_nSubstitute
{
	public class MyClass
	{
		private readonly ICalculator _calculator;

		public MyClass(ICalculator calculator)
		{
			_calculator = calculator;
		}

		public int Add(int x, int y)
		{
			return _calculator.Add(x, y);
		}

		public int Subtract(int? x, int? y)
		{
			return _calculator.Subtract(x, y);
		}

		public int Multiply(int x, int y)
		{
			return _calculator.Multiply(x, y);
		}
	}
}
