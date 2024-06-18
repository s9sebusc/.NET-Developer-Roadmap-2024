using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public class MilkFoamDecorator : DrinkDecorator
   {
      public IDrink drink;

        public MilkFoamDecorator(IDrink drink)
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
         return this.drink.GetDescription() + " [Milk Foam]";
      }

      private static double? GetSizePrice(Size? size)
      {
         return size switch
         {
            Size.Small => 0.01,
            Size.Normal => 0.02,
            Size.Large => 0.03,
            _ => throw new ArgumentOutOfRangeException(nameof(size)),
         };
      }
   }
}
