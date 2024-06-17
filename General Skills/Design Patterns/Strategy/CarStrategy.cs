using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	internal class BusStrategy : IAirportTransportationStrategy
	{
		public void DriveToTheAirport()
		{
			Console.WriteLine("Driving to the airport by bus...");
		}
	}
}
