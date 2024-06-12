using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

/// <summary>
/// Die Factory ist bei Factory Method pattern immer abstract
/// </summary>
	public abstract class PizzaFactory
	{ 
		public abstract IPizza CreatePizza(string type);
	}
}
