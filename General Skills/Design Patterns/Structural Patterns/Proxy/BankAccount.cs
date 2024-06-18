using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	internal class BankAccount : IBankAccount
	{
		private decimal _balance; 

		public void PayIn(decimal amount)
		{
			_balance += amount;
			Console.WriteLine($"Deposited {amount} euro.");
		}

		public void PayOut(decimal amount)
		{
			_balance -= amount;
			Console.WriteLine($"Withdrew {amount} euro.");
		}

		public void GetBalance()
		{
			Console.WriteLine($"Your balance is {_balance} euro.");
		}
	}
}
