using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Unity
{
   public class Console : IConsole
   {
      public void Write(string consoleMessage)
      {
         System.Console.WriteLine(consoleMessage);
      }
   }
}
