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
      /// <summary>Updates the specified weather data.</summary>
      /// <param name="temp">The temperature.</param>
      /// <param name="hud">The humidity.</param>
      /// <param name="airPr">The air pressure.</param>
      void Update(int temp, int hud, int airPr);
   }
}
