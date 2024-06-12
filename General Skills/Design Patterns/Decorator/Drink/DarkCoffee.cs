using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public class DarkCoffee : IDrink
   {
      private Size? size;

      public DarkCoffee(Size? size)
      {
         this.SetSize(size);
      }

      public string GetDescription()
      {
         return nameof(DarkCoffee);
      }

      public double? GetPrice()
      {
         return 0.99;
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
