using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjection_Unity
{
   public class DummyService : IDummyService
   {
      public DummyService(int first, int second)
      {
      }

      public DummyService(string dummyText)
      {
		  
      }
   }
}
