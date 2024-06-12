using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	internal class BerlinTunaPizza : IPizza
	{
		public void Bake()
		{
			Console.WriteLine("Bake Tuna Pizza in Berlin Style");
		}

		public void Cut()
		{
			Console.WriteLine("Cut Tuna Pizza in Berlin Style");
		}

		public void Pack()
		{
			Console.WriteLine("Pack Tuna Pizza in Berlin Style");
		}

		public void Prepare()
		{
			Console.WriteLine("Prepare Tuna Pizza in Berlin Style");
		}
	}
}
