using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection_Test.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection_Test
{
	internal class Program
	{

		static void Main(string[] args)
		{
			IInfrastructureServices services = new InfrastructureServices();

			// Message Service
			IMessageService messageService = services.ServiceProvider.GetService<IMessageService>();
			messageService.WriteMessage("This is a test message");

			// Calculation Service
			ICalculationService calculationService = services.ServiceProvider.GetService<ICalculationService>();
			int calculatedResult = calculationService.Add(1, 2);
			Console.WriteLine("Result calculated by DI Calculation Service: " + calculatedResult);

			// Constructor injection
			TestClass testClass = new TestClass(services);

			// Life time examples:
			// Singleton
			int messageService1 = services.ServiceProvider.GetService<IMessageService>().GetHashCode();
			int messageService2 = services.ServiceProvider.GetService<IMessageService>().GetHashCode();
			Console.WriteLine("Singleton service 1. call: " + messageService1);
			Console.WriteLine("Singleton service 2. call: " + messageService2);

			// Transient
			int calculationService1 = services.ServiceProvider.GetService<ICalculationService>().GetHashCode();
			int calculationService2 = services.ServiceProvider.GetService<ICalculationService>().GetHashCode();
			Console.WriteLine("Transient service 1. call: " + calculationService1);
			Console.WriteLine("Transient service 2. call: " + calculationService2);

			// Scope
			IServiceScope scope_1 = services.ServiceProvider.CreateScope();
			IServiceScope scope_2 = services.ServiceProvider.CreateScope();
			int messageBoxService1 = scope_1.ServiceProvider.GetService<IMessageBoxService>().GetHashCode();
			int messageBoxService2 = scope_1.ServiceProvider.GetService<IMessageBoxService>().GetHashCode();
			int messageBoxService3 = scope_2.ServiceProvider.GetService<IMessageBoxService>().GetHashCode();
			Console.WriteLine("Scope service 1. call from scope Nr. 1: " + messageBoxService1);
			Console.WriteLine("Scope service 2. call from scope Nr. 1: " + messageBoxService2);
			Console.WriteLine("Scope service 1. call from scope Nr. 2: " + messageBoxService3);

			//services = new InfrastructureServices();
			//int messageService3 = services.ServiceProvider.GetService<IMessageService>().GetHashCode();
			//int calculationService3 = services.ServiceProvider.GetService<ICalculationService>().GetHashCode();
			//int messageBoxService3= services.ServiceProvider.GetService<IMessageBoxService>().GetHashCode();
			//Console.WriteLine("Singleton service call after new: " + messageService3);
			//Console.WriteLine("Transient service call after new: " + calculationService3);
			//Console.WriteLine("Singleton service call after new: " + messageBoxService3);


			Console.ReadKey();

		}
	}
}
