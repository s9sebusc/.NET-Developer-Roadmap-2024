using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	internal class Calculator
	{
		private int result;

		public void AddNumber(int numberToAdd)
		{
			result += numberToAdd;
		}

		public void SubtractNumber(int numberToSubtract)
		{
			result -= numberToSubtract;
		}

		public int CurrentValue => this.result;
	}
}
