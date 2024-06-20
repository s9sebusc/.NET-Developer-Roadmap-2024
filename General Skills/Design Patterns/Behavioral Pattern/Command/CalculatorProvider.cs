using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	internal class CalculatorProvider
	{
		private ICommand _command;

		public void SetCommand(ICommand command)
		{
			_command = command;
		}

		public void ExecuteCommand()
		{
			_command.Execute();
		}

		public void UndoCommand()
		{
			_command.Undo();
		}
	}
}
