using System.Data.SQLite;

namespace TestConsoleApp
{
    [SQLiteFunction(Name = "CustomSQLiteFunction")]
    public class CustomSQLiteFunction : SQLiteFunction
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            new CustomSQLiteFunction();
        }
    }
}
