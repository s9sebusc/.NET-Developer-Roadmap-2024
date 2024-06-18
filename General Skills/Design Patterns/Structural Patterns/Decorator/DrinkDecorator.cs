using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public abstract class DrinkDecorator : IDrink
   {
      private readonly IDrink drink;

      public DrinkDecorator(IDrink drink)
        {
         this.drink = drink;
      }

      public virtual string GetDescription()
      {
         return this.drink.GetDescription();
      }

      public virtual double? GetPrice()
      {
         return this.drink.GetPrice();
      }

      public Size? GetSize()
      {
         return this.drink.GetSize();
      }
   }
}
