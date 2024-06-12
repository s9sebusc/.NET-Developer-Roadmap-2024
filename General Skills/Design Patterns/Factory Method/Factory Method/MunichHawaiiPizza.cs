using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	public class MunichHawaiiPizza : IPizza
	{
		public void Bake()
		{
			Console.WriteLine("Bake Hawaii Pizza in Munich style");
		}

		public void Cut()
		{
			Console.WriteLine("Cut Hawaii Pizza in Munich style");
		}

		public void Pack()
		{
			Console.WriteLine("Pack Hawaii Pizza in Munich style");
		}

		public void Prepare()
		{
			Console.WriteLine("Prepare Hawaii Pizza in Munich style");
		}
	}
}
