using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public class CoffeeWithoutCoffein : IDrink
   {
      private Size? size;

      public CoffeeWithoutCoffein(Size? size)
      {
         this.SetSize(size);
      }

      public string GetDescription()
      {
         return nameof(CoffeeWithoutCoffein);
      }

      public double? GetPrice()
      {
         return 2.49;
      }

      public Size? GetSize()
      {
         return this.size;
      }

      private void SetSize(Size? size)
      {
         this.size = size;
      }
   }
}
