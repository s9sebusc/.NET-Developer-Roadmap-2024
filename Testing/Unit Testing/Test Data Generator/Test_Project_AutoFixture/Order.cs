using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_AutoFixture
{
	internal class Order
	{
		public Guid Id { get; set; }

		public decimal Price { get; set; }

		public string Currency { get; set; }

		public string Comment { get; set; }

		public BillingDetails BillingDetails { get; set; }	
	}
}
