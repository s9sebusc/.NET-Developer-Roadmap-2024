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
	internal interface IInfrastructureServices
	{
		IServiceProvider ServiceProvider { get; }
	}
}
