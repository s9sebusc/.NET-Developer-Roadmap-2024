using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern
{
   public class WeatherData : IWeatherData
   {
      private readonly IList<IObserver> observers;

      /// <summary>Initializes a new instance of the <see cref="WeatherData"/> class.</summary>
      public WeatherData()
      {
         this.observers = new List<IObserver>();
      }

      /// <summary>Registers a new observer.</summary>
      /// <param name="newObserver">The new observer.</param>
      public void RegisterObserver(IObserver newObserver)
      {
         this.observers.Add(newObserver);
      }

      /// <summary>Removes an observer.</summary>
      /// <param name="observerToRemove">The observer to remove.</param>
      public void RemoveObserver(IObserver observerToRemove)
      {
         observers.Remove(observerToRemove);
      }

      /// <summary>Notifies all registered observers about weather data update.</summary>
      public void NotifyObserver()
      {
         foreach (IObserver observer in this.observers)
         {
            observer.Update(GetTemperature(), GetHumidity(), GetAirPressure());
         }
      }

      /// <summary>Gets a simulated temperature change.</summary>
      /// <returns>The new temperature.</returns>
      private static int GetTemperature()
      {
         Thread.Sleep(100);
         Random random = new Random();
         int temperature = random.Next(0, 30);

         return temperature;
      }

      /// <summary>Gets a simulated humidity change.</summary>
      /// <returns>The new temperature.</returns>
      private static int GetHumidity()
      {
         Thread.Sleep(100);
         Random random = new Random();
         int humidity = random.Next(0, 100);

         return humidity;
      }

      /// <summary>Gets a simulated air pressure change.</summary>
      /// <returns>The new air pressure.</returns>
      private static int GetAirPressure()
      {
         Thread.Sleep(100);
         Random random = new Random();
         int airPressure = random.Next(0, 1000);

         return airPressure;
      }
   }
}
