using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class AutoHouse
	{
		public void PurchaseCar(string carType)
		{
			ICarFactory carFactory;

			switch (carType)
			{
				case "Audi":
					carFactory = new AudiCarFactory();
					break;
				case "BMW":
					carFactory = new BMWCarFactory();
					break;
				default:
					throw new InvalidOperationException("Invalid car type " + carType);
				
			}

			carFactory.CreateMotor();
			carFactory.CreateMirror();
			carFactory.CreateTires();
		}
	}
}
