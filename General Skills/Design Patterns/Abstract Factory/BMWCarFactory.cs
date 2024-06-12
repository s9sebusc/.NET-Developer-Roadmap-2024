using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class BMWCarFactory : ICarFactory
	{
		public BMWCarFactory()
		{ 
			Console.WriteLine("--- BMW car factory ---");
		}

		public IMirror CreateMirror()
		{
			IMirror bmwMirror = new BMWMirror();
			return bmwMirror;
		}

		public IMotor CreateMotor()
		{
			IMotor bmwMotor = new BMWMotor();
			return bmwMotor;
		}

		public ITires CreateTires()
		{
			ITires bmwTires = new BMWTires();
			return bmwTires;
		}
	}
}
