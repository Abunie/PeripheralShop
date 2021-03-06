using Microsoft.Data.SqlClient;
using PeripheralShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Data
{
    internal class DisplayDAO
    {
        private string connectionString = @"Server=tcp:abuni466.database.windows.net,1433;Initial Catalog=PeripheralShop;Persist Security Info=False;User ID=abuni;Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //performs all operations on the database. get all, create, delete, get one, search etc.
        public List<Part> Fetchall()
        {
            List<Part> returnList = new List<Part>();

            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Parts WHERE Type = 'Display';";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create new Part Model

                        Part display = new Part(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5));
                        returnList.Add(display);

                    }
                }
            }

            return returnList;

        }

    }
}
