using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	internal class Fan : HomeDevice
	{
		public Fan(IControl control)
			: base(control)
		{
		}

		public override void TurnOn()
		{
			this.Control.TurnOn("Fan");
		}

		public override void TurnOff()
		{
			this.Control.TurnOff("Fan");
		}
	}
}
