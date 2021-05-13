using Microsoft.Data.SqlClient;
using PeripheralShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Data
{
    internal class PurchaseDAO
    {
        private string connectionString = @"Server=tcp:abuni466.database.windows.net,1433;Initial Catalog=PeripheralShop;Persist Security Info=False;User ID=abuni;Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //performs all operations on the database. get all, create, delete, get one, search etc.
        public void Insert(String UserId, String Desc)
        {


            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "INSERT INTO dbo.Orders VALUES ('" + UserId + "' , '" + Desc +"' )";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();

            }

          

        }

    }
}
