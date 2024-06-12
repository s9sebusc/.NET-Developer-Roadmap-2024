using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MSSQL_Connection_App
{
   class Program
   {
      const string dbConnectionString =
         @"Data Source=DI05N0003C\SQLEXPRESS_TEST;Initial Catalog=MyFirstDB;Integrated Security=True";

      static void Main(string[] args)
      {
         // DB Connection
         SqlConnection sqlConnection = new SqlConnection(dbConnectionString);
         sqlConnection.Open();

         //InsertNewValues(sqlConnection);
         //CreateNewTable(sqlConnection);
         //AddNewEntities();
         //IList<Product> products = ReadEntitiesFromDb();
         //RemoveFirstEntityFromDb();

        DapperFrameworkUsing(sqlConnection);

         //Console.WriteLine(sqlConnection.State);
         //Console.ReadKey();
      }


      private static void DapperFrameworkUsing(SqlConnection sqlConnection)
      {
         List<dynamic> allProducts = sqlConnection.Query("SELECT * FROM Products").ToList();
      }

      private static void RemoveFirstEntityFromDb()
      {
         using (MyDbContext dbContext = new MyDbContext())
         {
            IList<Product> products = dbContext.Products.ToList();
            dbContext.Products.Remove(products[0]);
            dbContext.Products.AddOrUpdate();
            dbContext.SaveChanges();
         }
      }


      private static IList<Product> ReadEntitiesFromDb()
      {
         using (MyDbContext dbContext = new MyDbContext())
         {
           return dbContext.Products.ToList();
         }
      }

      private static void AddNewEntities()
      {
         Product phone = new Product();
         phone.Id = Guid.NewGuid();
         phone.Description = "Google Pixel 7 Pro";
         phone.Price = 700;

         Product tv = new Product();
         tv.Id = Guid.NewGuid();
         tv.Description = "Samsung TV";
         tv.Price = 1999;

         using (MyDbContext dbContext = new MyDbContext())
         {
            dbContext.Products.Add(phone);
            dbContext.Products.Add(tv);
            dbContext.SaveChanges(); // Do not forget to save!
         }
      }

      private static void InsertNewValues(SqlConnection sqlConnection)
      {
         const string CreateTableCommand = @"CREATE TABLE Persons(
            ID          INT NOT NULL,
            NAME        VARCHAR(20) NOT NULL,
            AGE         INT NOT NULL,
            PRIMARY KEY(ID))";


         CreateAndExecuteSQLCommand(sqlConnection, CreateTableCommand);
      }

      private static void CreateNewTable(SqlConnection sqlConnection)
      {
         const string InsertCommand = "INSERT INTO [Vectors] (X_Coorindate, Y_Coordinate) VALUES (4,5)";
         CreateAndExecuteSQLCommand(sqlConnection, InsertCommand);
      }

      private static void CreateAndExecuteSQLCommand(SqlConnection sqlConnection, string cmdText)
      {

         SqlCommand command = new SqlCommand(cmdText, sqlConnection);
         command.BeginExecuteNonQuery();
      }
   }
}
