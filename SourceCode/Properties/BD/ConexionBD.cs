using Npgsql;
using System.Data;
using  System;
namespace SourceCode.Properties.BD
{
    public class ConexionBD
    { public static string host = "127.0.0.1",
            database = "HugoDB",
            userId = "postgres",
            password = "UCA";
        
        


       private static String sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";
        // $"sslmode=Require;Trust Server Certificate=true";
        public static DataTable ExecuteQuery(String query)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
                    
            Connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query,Connection);
            da.Fill(ds);
                    
            Connection.Close();

            return ds.Tables[0];

        }

        public static void ExecuteNonQuery(String act)
        {
                    
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
                    
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act,connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}