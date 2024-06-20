using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	internal class MinusCommand : ICommand
	{
		private readonly Calculator _calculator;
		private readonly int _numberToSubtract;

		public MinusCommand(Calculator calculator, int numberToSubtract)
		{
			_calculator = calculator;
			_numberToSubtract = numberToSubtract;
		}

		public void Execute()
		{
			_calculator.SubtractNumber(_numberToSubtract);
		}

		public void Undo()
		{
			_calculator.AddNumber(_numberToSubtract);
		}
	}
}
