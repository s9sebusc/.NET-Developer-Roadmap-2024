using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	internal class TravelManager
	{
		private IAirportTransportationStrategy? _airportTransportationStrategy;

		public void SetStrategy(IAirportTransportationStrategy airportTransportationStrategy)
		{
			_airportTransportationStrategy = airportTransportationStrategy;
		}

		public void Travel()
		{
			_airportTransportationStrategy?.DriveToTheAirport();
		}
	}
}
