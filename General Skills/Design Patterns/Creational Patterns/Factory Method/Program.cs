// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Hello, World!");

MunichPizzaFactory munichPizzaFactory = new MunichPizzaFactory();
Pizzeria munichPizzeria = new Pizzeria(munichPizzaFactory); // Factory kümmert sich um die Erstellung von Objekten, der Client (Pizzeria) kann nur was bestellen
IPizza munichHawaiiPizza = munichPizzeria.PurchasePizza("Hawaii"); 
IPizza munichThunaPizza = munichPizzeria.PurchasePizza("Tuna");
IPizza munichSalamiPizza = munichPizzeria.PurchasePizza("Salami");

BerlinPizzaFactory berlinPizzaFactory = new BerlinPizzaFactory();
Pizzeria berlinPizzeria = new Pizzeria(berlinPizzaFactory); // Factory kümmert sich um die Erstellung von Objekten, der Client (Pizzeria) kann nur was bestellen
IPizza berlinHawaiiPizza = berlinPizzeria.PurchasePizza("Hawaii");
IPizza berlinThunaPizza = berlinPizzeria.PurchasePizza("Tuna");
IPizza berlinSalamiPizza = berlinPizzeria.PurchasePizza("Salami");

Console.ReadLine();
