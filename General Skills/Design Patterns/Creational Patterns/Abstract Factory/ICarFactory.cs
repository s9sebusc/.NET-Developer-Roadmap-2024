using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	/// <summary>
	/// Interface für die Familien von Teilen, die für den Bau eines Autos nötig sind
	/// </summary>
	public interface ICarFactory
	{
		public IMirror CreateMirror();
		public ITires CreateTires();
		public IMotor CreateMotor();
	}
}
