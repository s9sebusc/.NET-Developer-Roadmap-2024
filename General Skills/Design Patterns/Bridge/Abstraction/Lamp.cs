using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	internal class TV : HomeDevice
	{
		public TV(IControl control)
			: base(control)
		{
		}

		public override void TurnOn()
		{
			this.Control.TurnOn("TV");
		}

		public override void TurnOff()
		{
			this.Control.TurnOff("TV");
		}
	}
}
