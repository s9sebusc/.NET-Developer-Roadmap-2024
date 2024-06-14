using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection_Test.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection_Test
{
	internal class TestClass
	{
		private readonly IInfrastructureServices _infrastructureServices;

		public TestClass(IInfrastructureServices infrastructureServices)
		{
			_infrastructureServices = infrastructureServices;
		}

		// Beispiel für Aufruf der Services aus DI Container
		public void InitServices()
		{
			IMessageService messageService = _infrastructureServices.ServiceProvider.GetService<IMessageService>();
			ICalculationService calculationService = _infrastructureServices.ServiceProvider.GetService<ICalculationService>();
		}
	}
}
