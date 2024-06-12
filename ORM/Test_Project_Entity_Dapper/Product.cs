using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Connection_App
{
   public class Product
   {
      [Key] // Primary key
      public Guid Id { get; set; }

      public string Description { get; set; }

      public double Price { get; set; }
   }
}
