using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Builder
{
	public class CarBuilder : ICarBuilder
	{
		private readonly Car car;

		public CarBuilder()
		{
			this.car = new Car();
		}

		public ICarBuilder SetName(string name)
		{
			this.car.Name = name;
			return this;
		}

		public ICarBuilder SetYear(int year)
		{
			this.car.Year = year;
			return this;
		}

		public ICarBuilder SetColor(Color color)
		{
			this.car.Color = color;
			return this;
		}

		public ICarBuilder SetHorsePower(int horsePower)
		{
			this.car.HorsePower = horsePower;
			return this;
		}

		public ICarBuilder SetHasSunroof(bool hasSunroof)
		{
			this.car.HasSunroof = hasSunroof;
			return this;
		}

		public ICarBuilder SetHasAbs(bool hasAbs)
		{
			this.car.HasABS = hasAbs;
			return this;
		}

		public Car Build()
		{
			return this.car;
		}
	}
}
