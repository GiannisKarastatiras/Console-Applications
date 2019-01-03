using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;

namespace SQLFromConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            //App.config stores configuration data
            //System.Data.SqlClient provides classes for accessing SQL Server DB
            //connectionString defines Server, DB and parameters to connect
            //Configuration Manager provides access to config data in App.config

            string provider = ConfigurationManager.AppSettings["provider"];    

            string connectionString = ConfigurationManager.AppSettings["connectionString"]; 

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection dbconnection = factory.CreateConnection())
            {
                if (dbconnection == null)
                {
                    Console.WriteLine("Connection Error");
                    return;
                }

                try
                {
                    dbconnection.ConnectionString = connectionString;
                    dbconnection.Open();

                    DbCommand command = factory.CreateCommand();
                    command.Connection = dbconnection;
                    command.CommandText = "SELECT ID, Name, Password FROM UsersDetailsTable";

                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Console.WriteLine($"{dataReader["ID"]} {dataReader["Name"]} {dataReader["Password"]}");
                        }
                        dataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
                finally
                {
                    dbconnection.Close();
                }
            }
        }
    }
}
