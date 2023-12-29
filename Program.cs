using Microsoft.Data.Sqlite;
using System.Collections;
using System.IO
// load remote db with path without exposing the path
// https://stackoverflow.com/questions/38767976/how-to-load-sqlite-database-from-a-remote-server-in-c-sharp




var dbPath = Environment.GetEnvironmentVariable("ConanGame");
Console.WriteLine($"dbPath: {dbPath.Value}");
namespace SQLiteSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqliteConnection("" +
                new SqliteConnectionStringBuilder
                {
                    DataSource = "sample.db"
                }))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT 1";

                var result = command.ExecuteScalar();
                Console.WriteLine(result);
            }
        }
    }
}

