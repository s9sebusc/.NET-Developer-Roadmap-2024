using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public class ChokolateDecorator : DrinkDecorator
   {
      public IDrink drink;

      public ChokolateDecorator(IDrink drink)
         : base(drink)
        {
         this.drink = drink;
        }

      public override string GetDescription()
      {
         return this.drink.GetDescription() + " [Choko]";
      }

      public override double? GetPrice()
      {
         return this.drink.GetPrice() + GetSizePrice(this.drink.GetSize());
      }

      private static double? GetSizePrice(Size? size)
      {
         return size switch
         {
            Size.Small => 0.20,
            Size.Normal => 0.25,
            Size.Large => (double?)0.30,
            _ => throw new ArgumentOutOfRangeException(nameof(size)),
         };
      }
   }
}
