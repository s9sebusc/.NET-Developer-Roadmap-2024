using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern
{
	public class NewsAgency : INewsSubject
	{
		private readonly List<IObserver> observers;

		public NewsAgency()
		{
			observers = new List<IObserver>();
		}

		public void RegisterObserver(IObserver observer)
		{
			observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			observers.Remove(observer);
		}

		public void NotifyObserver(string news)
		{
			foreach (IObserver observer in observers)
			{
				observer.Update(news);
			}
		}

		public void UpdateNews(string news)
		{
			this.NotifyObserver(news);
		}
	}
}