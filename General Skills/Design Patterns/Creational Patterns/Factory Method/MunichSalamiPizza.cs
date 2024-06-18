using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	internal class BerlinSalamiPizza : IPizza
	{
		public void Bake()
		{
			Console.WriteLine("Bake Salami Pizza in Berlin style");
		}

		public void Cut()
		{
			Console.WriteLine("Cut Salami Pizza in Berlin style");
		}

		public void Pack()
		{
			Console.WriteLine("Pack Salami Pizza in Berlin style");
		}

		public void Prepare()
		{
			Console.WriteLine("Prepare Salami Pizza in Berlin style");
		}
	}
}
