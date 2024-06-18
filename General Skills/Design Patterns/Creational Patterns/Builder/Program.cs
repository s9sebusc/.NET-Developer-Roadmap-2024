using System.Drawing;
using Builder;

Car vw = new CarBuilder()
	.SetName("VW")
	.SetColor(Color.Blue)
	.SetYear(2000)
	.Build();

Car audi = new CarBuilder()
	.SetName("Audi")
	.SetColor(Color.Red)
	.SetYear(2023)
	.SetHasSunroof(true)
	.SetHorsePower(190)
	.Build();

Console.WriteLine(vw.ToString());
Console.WriteLine(audi.ToString());

