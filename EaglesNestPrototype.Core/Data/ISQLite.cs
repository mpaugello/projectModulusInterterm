using SQLite;

namespace EaglesNestPrototype.Core.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
