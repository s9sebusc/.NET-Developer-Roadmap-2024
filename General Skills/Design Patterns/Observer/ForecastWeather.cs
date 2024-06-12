using System;

namespace ObserverPattern
{
   /// <summary>
   /// The observer for forecasted weather data.
   /// </summary>
   public class ForecastWeather : IObserver, IWeatherDisplay
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

         this.Display();
      }

      public void Display()
      {
         Console.WriteLine("[Forecast weather]");
         Console.WriteLine("Temperature: " + this.temperature);
         Console.WriteLine("Humidity: " + this.humidity);
         Console.WriteLine("Air Pressure: " + this.airPressure);
      }
   }
}
