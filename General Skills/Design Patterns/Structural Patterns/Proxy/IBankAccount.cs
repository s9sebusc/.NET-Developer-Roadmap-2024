using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	internal interface IBankAccount
	{
		void PayIn(decimal amount);
		void PayOut(decimal amount);
		void GetBalance();
	}
}
