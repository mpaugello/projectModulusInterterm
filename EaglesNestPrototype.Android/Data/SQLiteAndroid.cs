using EaglesNestPrototype.Core.Data;
using System.IO;

namespace EaglesNestPrototype.Android
{
    public class SQLiteAndroid : ISQLite
    {
        public SQLiteAndroid()
        {

        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "EagleSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);

            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);

            // Return the database connection
            return conn;
        }
    }
}