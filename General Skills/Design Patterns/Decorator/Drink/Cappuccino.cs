using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public class Cappuccino : IDrink
   {
      private Size? size;

        public Cappuccino(Size? size)
        {
         this.SetSize(size);
        }

        public string GetDescription()
      {
         return nameof(Cappuccino);
      }

      public double? GetPrice()
      {
         return 1.99;
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
