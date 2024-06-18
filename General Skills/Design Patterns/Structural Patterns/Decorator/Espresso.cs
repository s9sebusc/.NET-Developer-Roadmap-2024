using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public class Espresso : IDrink
   {
      private Size? size = Size.Unknown;

      public Espresso(Size? size)
      {
         this.SetSize(size);
      }

      public string GetDescription()
      {
         return nameof(Espresso);
      }

      public double? GetPrice()
      {
         return 1.49;
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
