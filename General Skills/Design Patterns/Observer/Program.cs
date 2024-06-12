using System;

namespace ObserverPattern
{
   public class Program
   {
      public static void Main(string[] args)
      {
         IWeatherData weatherData = new WeatherData();

         // Register new observer
         CurrentWeather currentWeatherDisplay = new CurrentWeather();
         ForecastWeather forecastWeatherDisplay = new ForecastWeather();
         weatherData.RegisterObserver(currentWeatherDisplay);
         weatherData.RegisterObserver(forecastWeatherDisplay);

         Console.WriteLine("Show weather before update:");
         Console.WriteLine("----------------------------------------------");
         currentWeatherDisplay.Display();
         forecastWeatherDisplay.Display();
         Console.WriteLine("----------------------------------------------");

         Console.WriteLine("Show weather after update:");
         Console.WriteLine("----------------------------------------------");
         weatherData.NotifyObserver(); // Update observer
         Console.WriteLine("----------------------------------------------");

         // Remove one observer => only one observer left
         weatherData.RemoveObserver(forecastWeatherDisplay);

         // Show data after update
         Console.WriteLine("Show weather after removing forecast weather observer");
         Console.WriteLine("----------------------------------------------");   
         weatherData.NotifyObserver(); // Update observer
         Console.WriteLine("----------------------------------------------");

         Console.ReadKey();


      }
   }
}
