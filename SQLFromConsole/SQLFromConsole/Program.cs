using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       //using directive

namespace SQLFromConsole
{
    class Program
    {
        
        static string connectionString = @"Server = ASUS;Database = Database100; Trusted_Connection = True;";   //trusted conn--windows authentication
        static SqlConnection sqlConnection = new SqlConnection(connectionString);       


        static void Main(string[] args)
        {
            
            using (sqlConnection) 
            {
                try
                {
                    sqlConnection.Open();       

                    // Insert User
                    Console.WriteLine("Enter a UserName and Password");
                    string username = Console.ReadLine();
                    string password = Console.ReadLine();

                    SqlCommand cmdInsert = new SqlCommand($"INSERT INTO UsersDetailsTable(Name, Password) VALUES('{username}', '{password}')", sqlConnection);
                    int rowsInserted = cmdInsert.ExecuteNonQuery();
                    if (rowsInserted > 0)
                    {
                        Console.WriteLine("Insertion Successful");
                        Console.WriteLine($"{rowsInserted} rows inserted Successfully");
                    }

                    // select
                    SqlCommand cmdSelect = new SqlCommand("SELECT COUNT(*) FROM UsersDetailsTable WHERE Name = @username AND Password = @password", sqlConnection);
                    cmdSelect.Parameters.AddWithValue("@username", "Christos");
                    cmdSelect.Parameters.AddWithValue("@password", "12345");

                    int result = (int)cmdSelect.ExecuteScalar();    
                    if (result > 0)
                        Console.WriteLine("Found User Christos");
                    else
                        Console.WriteLine("Not found User Christos");

                    // login
                    Console.WriteLine("Enter username and password to Login:");
                    string usernameInserted = Console.ReadLine();
                    string passwordInserted = Console.ReadLine();

                    SqlCommand cmdLogin = new SqlCommand($"SELECT ID, Name, Password FROM UsersDetailsTable WHERE Name = '{usernameInserted}' AND Password = '{passwordInserted}'", sqlConnection);
                    SqlDataReader reader = cmdLogin.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("Users Login Successfully");

                        User user = new User();
                        user.ID = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Password = reader.GetString(2);

                        Console.WriteLine(user);
                        //Console.WriteLine("ID\tName\tPassword");
                        //Console.WriteLine($"{reader.GetInt32(0)}\t{reader.GetString(1)}\t{reader.GetString(2)}");   
                    }
                    //readers must close
                    reader.Close();

                    // select multiple users
                    List<User> users = new List<User>();
                    SqlCommand cmdUsers = new SqlCommand($"SELECT ID, Name, Password FROM UsersDetailsTable", sqlConnection);
                    SqlDataReader readerUsers = cmdUsers.ExecuteReader();
                    Console.WriteLine("Users: ");
                    while (readerUsers.Read())
                    {
                        
                        User user = new User()
                        {
                            ID = readerUsers.GetInt32(0),
                            Name = readerUsers.GetString(1),
                            Password = readerUsers.GetString(2)
                        };
                        users.Add(user);
                    }

                    foreach (User user in users)
                    {
                        Console.WriteLine(user);
                    }
                    //readers must close
                    readerUsers.Close();

                    // update
                    Console.WriteLine("Enter a User for Update:");
                    string nameForUpdate = Console.ReadLine();
                    Console.WriteLine("Enter a new Password for User:");
                    string newPassword = Console.ReadLine();
                    SqlCommand cmdUpdate = new SqlCommand($"UPDATE UsersDetailsTable SET Password = '{newPassword}' WHERE Name = '{nameForUpdate}'", sqlConnection);
                    int rowsUpdated = cmdUpdate.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                    {
                        Console.WriteLine("Update Successfull");
                        Console.WriteLine($"{rowsUpdated} rows updated successfully");
                    }

                    // delete
                    Console.WriteLine("Enter a user to DELETE");
                    string nameForDelete = Console.ReadLine();
                    SqlCommand cmdDelete = new SqlCommand($"DELETE FROM UsersDetailsTable WHERE Name = '{nameForDelete}'", sqlConnection);
                    int rowsDeleted = cmdDelete.ExecuteNonQuery();
                    if (rowsDeleted > 0)
                    {
                        Console.WriteLine("Delete Successfull");
                        Console.WriteLine($"{rowsDeleted} rows deleted successfully");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
                finally
                {
                    // close the connection
                    sqlConnection.Close();
                    //sqlConnection.Dispose(); 
                }




               
            }
        }
    }
}
