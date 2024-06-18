using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	internal interface IEmployee
	{
		public string Name { get; set; }
		public string Position { get; set; }

		public void Display(int indent = 0);
	}
}
