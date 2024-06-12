using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MSSQLForCSProgs
{
   public partial class Form1 : Form
   {
      private SqlConnection sqlConnectionFirstDB;
      private SqlConnection sqlConnectionNorthwindDB;

      public Form1()
      {
         InitializeComponent();
      }

        private void Form1_Load(object sender, EventArgs e)
        {
           //// DB CONNECTION
           // Configuration manager loads the connection string from the manually created connection string in app.config
           string connectionFirstDB = ConfigurationManager.ConnectionStrings["MyFirstDB"].ConnectionString;
           string connectionNorthwindDB = ConfigurationManager.ConnectionStrings["NorthwindDB"].ConnectionString;

           this.sqlConnectionFirstDB = new SqlConnection(connectionFirstDB);
           this.sqlConnectionFirstDB.Open();

           this.sqlConnectionNorthwindDB = new SqlConnection(connectionNorthwindDB);
           this.sqlConnectionNorthwindDB.Open();

         //

      }

      private void button1_Click(object sender, EventArgs e)
      {
         // My test DB
         SqlCommand insertCommand = new SqlCommand(
            $"INSERT INTO [Students] (Name, LastName, Birthday, PlaceOfBirth, Phone, EMail)" +
                        $"VALUES (@Name, @LastName, @Birthday, @PlaceOfBirth, @Phone, @EMail)",
                     this.sqlConnectionFirstDB);

         insertCommand.Parameters.AddWithValue("Name", textBox1.Text);
         insertCommand.Parameters.AddWithValue("LastName", textBox2.Text);
         insertCommand.Parameters.AddWithValue("Birthday", DateTime.Parse(textBox3.Text));
         insertCommand.Parameters.AddWithValue("PlaceOfBirth", textBox4.Text);
         insertCommand.Parameters.AddWithValue("Phone", textBox5.Text);
         insertCommand.Parameters.AddWithValue("EMail", textBox6.Text);

         MessageBox.Show("Successfully inserted: " + insertCommand.ExecuteNonQuery());
      }

      private void button2_Click(object sender, EventArgs e)
      {
         string selectCommand = textBox7.Text;
         DataSet dataSet = SelectData(selectCommand);

         dataGridView1.DataSource = dataSet.Tables[0]; // Show the query result values in application table
      }

      private DataSet SelectData(string selectCommand)
      {
         SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, this.sqlConnectionNorthwindDB);
         DataSet dataSet = new DataSet();
         dataAdapter.Fill(dataSet);

         return dataSet;
      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }
   }
}
