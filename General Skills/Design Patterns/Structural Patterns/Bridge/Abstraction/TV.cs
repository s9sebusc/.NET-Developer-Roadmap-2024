using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	internal class Lamp : HomeDevice
	{
		public Lamp(IControl control)
			: base(control)
		{
		}

		public override void TurnOn()
		{
			this.Control.TurnOn("Lamp");
		}

		public override void TurnOff()
		{
			this.Control.TurnOff("Lamp");
		}
	}
}
