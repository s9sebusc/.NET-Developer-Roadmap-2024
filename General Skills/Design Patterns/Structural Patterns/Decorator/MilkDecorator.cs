using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public class MilkDecorator : DrinkDecorator
   {
      public IDrink drink;

        public MilkDecorator(IDrink drink)
         : base(drink)
      {
         this.drink = drink;
        }

        public override double? GetPrice()
      {
         return this.drink.GetPrice() + GetSizePrice(this.drink.GetSize());
      }


      public override string GetDescription()
      {
         return this.drink.GetDescription() + " [Milk]";
      }

      private static double? GetSizePrice(Size? size)
      {
         return size switch
         {
            Size.Small => 0.10,
            Size.Normal => 0.12,
            Size.Large => 0.15,
            _ => throw new ArgumentOutOfRangeException(nameof(size)),
         };
      }
   }
}
