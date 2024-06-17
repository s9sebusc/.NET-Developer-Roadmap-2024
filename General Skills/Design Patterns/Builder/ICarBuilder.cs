using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public interface ICarBuilder
	{
		ICarBuilder SetName(string name);
		ICarBuilder SetYear(int year);
		ICarBuilder SetColor(Color color);
		ICarBuilder SetHorsePower(int horsePower);
		ICarBuilder SetHasSunroof(bool hasSunroof);
		ICarBuilder SetHasAbs(bool hasAbs);

		Car Build();
	}
}

		