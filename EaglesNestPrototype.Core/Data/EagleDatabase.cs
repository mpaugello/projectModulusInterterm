using EaglesNestPrototype.Core.Model;
using SQLite;
using Xamarin.Forms;

namespace EaglesNestPrototype.Core.Data
{
    public class EagleDatabase
    {
        static object locker = new object();

        SQLiteConnection database;

        public EagleDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Student>();
        }

        public Student GetStudent(int id)
        {
            lock (locker)
            {
                return database.Table<Student>().FirstOrDefault(x => x.StudentId == id);
            }
        }

    }
}
