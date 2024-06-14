using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection_Test.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DependencyInjection_Test
{
	internal class InfrastructureServices : IInfrastructureServices
	{
		public InfrastructureServices()
		{
			ServiceCollection services = new ServiceCollection();
			services.AddSingleton<IMessageService, MessageService>(); // Singleton Instanz
			services.AddTransient<ICalculationService, CalculationService>(); // Neue Instanz bei jedem Aufruf
			services.AddScoped<IMessageBoxService, MessageBoxService>(); // Gleiche Instanz bei jedem Aufruf

			// Build...() ist wichtig, da nur danach wirklich ein DI Container erstellt wird
			ServiceProvider = services.BuildServiceProvider();
		}

		public IServiceProvider ServiceProvider { get; }
	}
}
