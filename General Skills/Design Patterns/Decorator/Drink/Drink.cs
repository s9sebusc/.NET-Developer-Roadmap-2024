using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenk
{
   public interface IDrink
   {
      string GetDescription();

      double? GetPrice();

      Size? GetSize();
   }
}
