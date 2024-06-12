using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public class SojaDecorator : DrinkDecorator
   {
      public IDrink drink;

        public SojaDecorator(IDrink drink)
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
         return this.drink.GetDescription() + " [Soja]";
      }

      private static double? GetSizePrice(Size? size)
      {
         return size switch
         {
            Size.Small => 0.15,
            Size.Normal => 0.16,
            Size.Large => 0.18,
            _ => throw new ArgumentOutOfRangeException(nameof(size)),
         };
      }
   }
}
