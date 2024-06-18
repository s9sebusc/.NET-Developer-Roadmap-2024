using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
   /// <summary>
   /// Interface for an observer object
   /// </summary>
   public interface IObserver
   {
	   void Update(string news);
   }
}
