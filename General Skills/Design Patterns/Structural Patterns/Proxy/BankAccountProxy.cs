using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	internal class BankAccountProxy : IBankAccount
	{
		private readonly BankAccount _bankAccount; // The real bank account instance is hidden
		private readonly string _user;
		private readonly string _password;

		public BankAccountProxy(string user, string password)
		{
			_bankAccount = new BankAccount();
			_user = user;
			_password = password;
		}

		private bool IsAuthenticatedAccount => _user == "admin" && _password == "password";

		public void PayIn(decimal amount)
		{
			if (IsAuthenticatedAccount)
			{
				_bankAccount.PayIn(amount);
			}
		}

		public void PayOut(decimal amount)
		{
			if (IsAuthenticatedAccount)
			{
				_bankAccount.PayOut(amount);
			}
		}

		public void GetBalance()
		{
			if (IsAuthenticatedAccount)
			{
				_bankAccount.GetBalance();
			}
		}
	}
}
