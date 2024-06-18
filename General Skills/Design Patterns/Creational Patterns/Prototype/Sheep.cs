using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	internal class Sheep : ICloneable // das Interface ist in .NET 8 bereits integriert
	{
		private string anInternalVariable;

		public string? Name { get; set; }
		public int Age { get; set; }

		public Sheep()
		{
			this.anInternalVariable = "This value isn't visible from outside";	
		}

		public object Clone()
		{
			return (Sheep)this.MemberwiseClone();
		}
	}
}
