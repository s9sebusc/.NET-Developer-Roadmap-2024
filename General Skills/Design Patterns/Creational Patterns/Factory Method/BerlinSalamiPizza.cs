using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	public class MunichSalamiPizza : IPizza
	{
		public void Bake()
		{
			Console.WriteLine("Bake Salami Pizza in Munich style");
		}

		public void Cut()
		{
			Console.WriteLine("Cut Salami Pizza in Munich style");
		}

		public void Pack()
		{
			Console.WriteLine("Pack Salami Pizza in Munich style");
		}

		public void Prepare()
		{
			Console.WriteLine("Prepare Salami Pizza in Munich style");
		}
	}
}
