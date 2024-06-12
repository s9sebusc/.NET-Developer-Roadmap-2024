using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
   public class Pizzeria
   {
		private readonly PizzaFactory pizzaFactory;

		public Pizzeria(PizzaFactory pizzaFactory)
        {
			this.pizzaFactory = pizzaFactory;
		}

        public IPizza PurchasePizza(string type)
        {
			IPizza pizza = this.pizzaFactory.CreatePizza(type);

			pizza.Prepare();
            pizza.Bake();  
            pizza.Cut();
            pizza.Pack();

            return pizza;
		}
    }
}
