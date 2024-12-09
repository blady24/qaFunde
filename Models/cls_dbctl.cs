/*
name                : cls_dbctl.cs
author              : eliseOS
creation date       : 104320241117
last update date    : 105020241117
last update author  : eliseOS
purpose             : db_controller
*/

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace qa_funde.Models
{
    public class cls_dbctl
    {
        private string connectionString = "Server=localhost;Database=agenda;User Id=root;Password=;";


        public virtual void ExecuteNonQuery(string storedProcedure, params MySqlParameter[] parameters)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }
        public virtual DataTable ExecuteQuery(string storedProcedure, params MySqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }
    }
}
