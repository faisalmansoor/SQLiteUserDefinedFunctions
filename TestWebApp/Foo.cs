using System;
using System.Data.SQLite;

namespace TestWebApp
{
    public class Foo : SQLiteFunction
    {
        static Foo()
        {
        }

        public override object Invoke(object[] args)
        {
            Console.WriteLine("Invoked");
            return base.Invoke(args);
        }
    }
}