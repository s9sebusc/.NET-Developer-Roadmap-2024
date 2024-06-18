using System;

namespace ObserverPattern
{
	public class NewsSubscriber : IObserver
   {
		private readonly string name;

		public NewsSubscriber(string name)
		{
			this.name = name;
		}

		public void Update(string news)
		{
			Console.WriteLine($"{name} received breaking news: {news}");
		}
	}
}
