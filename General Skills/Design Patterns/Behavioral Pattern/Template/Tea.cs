using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
	public class Tea : HotDrink
	{
		protected override void Brew()
		{
			Console.WriteLine("Steeping the tea...");
		}

		protected override void AddExtras()
		{
			Console.WriteLine("Adding lemon...");
		}
	}
}
