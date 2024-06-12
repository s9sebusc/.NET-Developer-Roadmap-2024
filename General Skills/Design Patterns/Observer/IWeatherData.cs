using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
   public interface IWeatherData
   {
      void RegisterObserver(IObserver newObserver);

      void RemoveObserver(IObserver observerToRemove);

      void NotifyObserver();
   }
}
