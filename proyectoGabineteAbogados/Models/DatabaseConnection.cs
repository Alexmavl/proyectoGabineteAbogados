using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace proyectoGabineteAbogados.Models
{
    public class DatabaseConnection
    {
         private string connectionString;

        public DatabaseConnection()
        {
            connectionString = "Server=MAVL\\SQLEXPRESS;Database=gabineteAbogados;Trusted_Connection=True;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}