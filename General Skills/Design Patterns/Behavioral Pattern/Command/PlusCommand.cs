using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	internal class PlusCommand : ICommand
	{
		private readonly Calculator _calculator;
		private readonly int _numberToAdd;

		public PlusCommand(Calculator calculator, int numberToAdd)
		{
			_calculator = calculator;
			_numberToAdd = numberToAdd;
		}

		public void Execute()
		{
			_calculator.AddNumber(_numberToAdd);
		}

		public void Undo()
		{
			_calculator.SubtractNumber(_numberToAdd);
		}
	}
}
