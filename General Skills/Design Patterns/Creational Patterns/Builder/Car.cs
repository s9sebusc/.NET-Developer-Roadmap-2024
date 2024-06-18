using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Car
	{
		public string Name { get; set; }

		public int Year { get; set; }

		public Color Color { get; set; }

		public int HorsePower { get; set; }

		public bool HasSunroof { get; set; }

		public bool HasABS { get; set; }
	}
}