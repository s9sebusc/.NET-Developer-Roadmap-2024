using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace DependencyInjection_Unity
{
   public class UnityContainerConfiguration
   {
      private UnityContainer unityContainer;

      public UnityContainerConfiguration()
      {
         this.unityContainer = new UnityContainer();
      }

      public void Configure()
      {
         this.unityContainer = new UnityContainer();

         // Demo:
         RegisterTypes();
         RegisterInstances();
         RegisterSingleton();
         InjectConstructor();
      }

      private void RegisterTypes()
      {
         unityContainer.RegisterType<ILogger, Logger>();
         unityContainer.RegisterType<IConsole, Console>();
      }

      private void RegisterInstances()
      {
         Console console = new Console();
         unityContainer.RegisterInstance(console);
      }

      private void RegisterSingleton()
      {
         unityContainer.RegisterSingleton<ILogger, Logger>();
         unityContainer.RegisterSingleton<IConsole, Console>();
      }

      // Register specific constructor
      private void InjectConstructor()
      {
         unityContainer.RegisterType<IDummyService, DummyService>("ctor with two parameter", new InjectionConstructor(1, 2));
         unityContainer.RegisterType<IDummyService, DummyService>("ctor with one parameter", new InjectionConstructor("bla"));
      }

      public T GetService<T>()
      {
         return this.unityContainer.Resolve<T>();
      }

      public T GetService<T>(string name)
      {
         return this.unityContainer.Resolve<T>(name);
      }
   }
}
