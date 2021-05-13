using Microsoft.Data.SqlClient;
using PeripheralShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeripheralShop.Data
{
    internal class PartsDAO
    {
        private string connectionString = @"Server=tcp:abuni466.database.windows.net,1433;Initial Catalog=PeripheralShop;Persist Security Info=False;User ID=abuni;Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //performs all operations on the database. get all, create, delete, get one, search etc.
        public List<Part> Fetchall() {
            List<Part> returnList = new List<Part>();

            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Parts;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create new Part Model
                        
                          
                        
                        Part part = new Part(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5));
                        returnList.Add(part);
                        
                    }
                }
            }

            return returnList;

        }

        public List<Item> FetchSome(List<int> ids)
        {
            List<Item> returnList = new List<Item>();

            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery1 = "SELECT * FROM dbo.Parts;";
                SqlCommand command1 = new SqlCommand(sqlQuery1, connection);

                

                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                

                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        // create new Part Model

                        if (ids.Contains(reader1.GetInt32(0)))
                        {
                            Part part = new Part(reader1.GetInt32(0), reader1.GetString(1), reader1.GetString(2), reader1.GetString(3), reader1.GetString(4), reader1.GetInt32(5));
                            returnList.Add(part);

                        }


                    }
                }
                connection.Close();


                string sqlQuery2 = "SELECT * FROM dbo.Computer;";
                SqlCommand command2 = new SqlCommand(sqlQuery2, connection);

                connection.Open();
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        // create new Part Model

                        if (ids.Contains(reader2.GetInt32(0)))
                        {
                            Computer comp = new Computer(reader2.GetInt32(0), reader2.GetString(1), reader2.GetString(2),  reader2.GetString(4), reader2.GetInt32(5));
                            returnList.Add(comp);

                        }


                    }
                }
            }

            return returnList;

        }

    }
}
