using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	public class MunichPizzaFactory : PizzaFactory
	{
		public override IPizza CreatePizza(string type)
		{
			return type switch
			{
				"Salami" => new BerlinSalamiPizza(),
				"Hawaii" => new BerlinHawaiiPizza(),
				"Tuna" => new BerlinTunaPizza(),
				_ => throw new ArgumentOutOfRangeException(nameof(type), type, "Invalid pizza type"),
			};
		}
	}
}
