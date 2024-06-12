using System;

namespace ObserverPattern
{
   /// <summary>
   /// The observer for current weather data.
   /// </summary>
   public class CurrentWeather : IObserver, IWeatherDisplay
   {
      private int temperature;
      private int humidity;
      private int airPressure;

      /// <summary>Updates the specified weather data.</summary>
      /// <param name="temp">The temperature.</param>
      /// <param name="hum">The humidity.</param>
      /// <param name="airPr">The air pressure.</param>
      public void Update(int temp, int hum, int airPr)
      {
         this.temperature = temp;
         this.humidity = hum;
         this.airPressure = airPr;

         Display();
      }

      public void Display()
      {
         Console.WriteLine("[Current weather]");
         Console.WriteLine("Temperature: " + this.temperature);
         Console.WriteLine("Humidity: " + this.humidity);
         Console.WriteLine("Air Pressure: " + this.airPressure);
      }
   }
}
