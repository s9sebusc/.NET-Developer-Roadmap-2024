using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Connection_App
{
   // Adapter for SQL Server DB
   public class MyDbContext : DbContext
   {
      public  DbSet<Product> Products { get; set; } // Create a table in database

      public MyDbContext() : base(@"Data Source=DI05N0003C\SQLEXPRESS_TEST;Initial Catalog=MyFirstDB;Integrated Security=True")
      {
      }
   }
}
