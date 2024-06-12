using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class AudiCarFactory : ICarFactory
	{
		public AudiCarFactory()
		{ 
			Console.WriteLine("--- AUDI car factory ---");
		}

		public IMirror CreateMirror()
		{
			IMirror audiMirror = new AudiMirror();
			return audiMirror;
		}

		public IMotor CreateMotor()
		{
			IMotor audiMotor = new AudiMotor();
			return audiMotor;
		}

		public ITires CreateTires()
		{
			ITires audiTires = new AudiTires();
			return audiTires;
		}
	}
}
