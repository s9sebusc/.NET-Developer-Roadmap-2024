using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Core;
using Serilog.Events;

namespace Test_Project_SeriLog
{
	public class DummyLoggerEnricher : ILogEventEnricher
	{
		private readonly string _environment;

		public DummyLoggerEnricher(string environment)
		{
			_environment = environment;
		}

		public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
		{
			LogEventProperty environmentProperty = propertyFactory.CreateProperty("Environment", _environment);
			logEvent.AddPropertyIfAbsent(environmentProperty);
		}
	}
}
