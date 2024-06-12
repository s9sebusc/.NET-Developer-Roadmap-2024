using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	internal class TunaPizza : IPizza
	{
		public void Bake()
		{
			Console.WriteLine("Bake Tuna Pizza");
		}

		public void Cut()
		{
			Console.WriteLine("Cut Tuna Pizza");
		}

		public void Pack()
		{
			Console.WriteLine("Pack Tuna Pizza");
		}

		public void Prepare()
		{
			Console.WriteLine("Prepare Tuna Pizza");
		}
	}
}
