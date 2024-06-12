using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   class Program
   {
      static void Main(string[] args)
      {
			LoggerSingleton logger1 = LoggerSingleton.GetInstance();
			LoggerSingleton logger2 = LoggerSingleton.GetInstance();

            bool isTheSameInstance = ReferenceEquals(logger1, logger2);

            Console.ReadKey();


      }
   }
}
