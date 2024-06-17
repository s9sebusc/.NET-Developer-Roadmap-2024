using System;

namespace ObserverPattern
{
   public class Program
   {
      public static void Main(string[] args)
      {
         NewsAgency newsAgency = new NewsAgency();

         NewsSubscriber subscriber1 = new NewsSubscriber("First Subscriber");
         NewsSubscriber subscriber2 = new NewsSubscriber("Second Subscriber");
         NewsSubscriber subscriber3 = new NewsSubscriber("Third Subscriber");

         newsAgency.RegisterObserver(subscriber1);
         newsAgency.RegisterObserver(subscriber2);
         newsAgency.RegisterObserver(subscriber3);

         newsAgency.UpdateNews("COVID-19 cases surge in several countries");
         newsAgency.UpdateNews("New technology breakthrough announced");

         Console.ReadKey();
      }
   }
}
