using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	public class BerlinHawaiiPizza : IPizza
	{
		public void Bake()
		{
			Console.WriteLine("Bake Hawaii Pizza in Berlin style");
		}

		public void Cut()
		{
			Console.WriteLine("Cut Hawaii Pizza in Berlin style");
		}

		public void Pack()
		{
			Console.WriteLine("Pack Hawaii Pizza in Berlin style");
		}

		public void Prepare()
		{
			Console.WriteLine("Prepare Hawaii Pizza in Berlin style");
		}
	}
}
