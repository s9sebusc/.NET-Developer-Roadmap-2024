using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	public class HardDrive
	{
		public byte[] Read()
		{
			Console.WriteLine("Starting CPU...");

			return new byte[10];
		}
	}
}
