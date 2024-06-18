// See https://aka.ms/new-console-template for more information
using Getraenk;

Console.WriteLine("Create a drink (espresso etc.) and decorate it with extra (milk etc.)");
Console.WriteLine(Environment.NewLine);

// New Drink #1
Espresso espresso = new Espresso(Size.Large);
Console.WriteLine("Drink #1");
Console.WriteLine("Description: " + espresso.GetDescription());
Console.WriteLine("Price: " + espresso.GetPrice());
Console.WriteLine(Environment.NewLine);

// New Drink #2
IDrink cappuccinoWithDoubleMilk = new Cappuccino(Size.Small);
cappuccinoWithDoubleMilk = new MilkDecorator(cappuccinoWithDoubleMilk);
cappuccinoWithDoubleMilk = new MilkDecorator(cappuccinoWithDoubleMilk);

Console.WriteLine("Drink #2");
Console.WriteLine("Description: " + cappuccinoWithDoubleMilk.GetDescription());
Console.WriteLine("Price: " + cappuccinoWithDoubleMilk.GetPrice());
Console.WriteLine(Environment.NewLine);

// New Drink #2
IDrink coffeeWithDoubleChokoAndSojaAndMilk = new DarkCoffee(Size.Normal);
coffeeWithDoubleChokoAndSojaAndMilk = new ChokolateDecorator(coffeeWithDoubleChokoAndSojaAndMilk);
coffeeWithDoubleChokoAndSojaAndMilk = new SojaDecorator(coffeeWithDoubleChokoAndSojaAndMilk);
coffeeWithDoubleChokoAndSojaAndMilk = new MilkFoamDecorator(coffeeWithDoubleChokoAndSojaAndMilk);

Console.WriteLine("Drink #3");
Console.WriteLine("Description: " + coffeeWithDoubleChokoAndSojaAndMilk.GetDescription());
Console.WriteLine("Price: " + coffeeWithDoubleChokoAndSojaAndMilk.GetPrice());
Console.WriteLine(Environment.NewLine);

Console.ReadLine();  
