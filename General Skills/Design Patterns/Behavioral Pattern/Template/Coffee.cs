using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
	public class Coffee : HotDrink
	{
		protected override void Brew()
		{
			Console.WriteLine("Dripping coffee through filter...");
		}

		protected override void AddExtras()
		{
			Console.WriteLine("Adding sugar and milk");
		}
	}
}
