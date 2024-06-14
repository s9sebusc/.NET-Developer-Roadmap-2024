using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjection_Unity
{
   class Program
   {
      static void Main(string[] args)
      {
         UnityContainerConfiguration unityConfig = new UnityContainerConfiguration();
         unityConfig.Configure();

         ILogger logger = unityConfig.GetService<ILogger>();
         IConsole console = unityConfig.GetService<IConsole>();
         IDummyService dummyService1 = unityConfig.GetService<IDummyService>("ctor with one parameter");
         IDummyService dummyService2= unityConfig.GetService<IDummyService>("ctor with two parameter");
      }
   }
}
