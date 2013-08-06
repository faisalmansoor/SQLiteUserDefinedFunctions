using System;
using AtellisShared.SQLite.Functions;

namespace TestStaticConstructor
{
    class Program
    {
        static Program()
        {
            var functionRef = new NullEqual(); 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("IsNet45OrNewer = " + IsNet45OrNewer());
            Console.ReadKey();

        }

        public static bool IsNet45OrNewer()
        {
            // Class "ReflectionContext" exists from .NET 4.5 onwards.
            return Type.GetType("System.Reflection.ReflectionContext", false) != null;
        }
    }
}
