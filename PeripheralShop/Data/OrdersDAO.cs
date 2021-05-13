using Microsoft.Data.SqlClient;
using PeripheralShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Data
{
    public class OrdersDAO
    {
        private string connectionString = @"Server=tcp:abuni466.database.windows.net,1433;Initial Catalog=PeripheralShop;Persist Security Info=False;User ID=abuni;Password=Comput466@2021;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //performs all operations on the database. get all, create, delete, get one, search etc.
        public Orders UserOrders(String UserID)
        {
            List<String> returnList = new List<String>();

            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Orders WHERE UserID ='" + UserID +"';";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create new Part Model
                        String order = new String(reader.GetString(1));
                        returnList.Add(order);

                    }
                }
            }

            return new Orders(returnList);

        }
    }
}
