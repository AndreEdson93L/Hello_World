using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator1 = new DbMigrator(new ConsoleLogger());
            var dbMigrator2 = new DbMigrator(new FileLogger(@"C:\Users\Computer\Desktop\log.txt"));

            dbMigrator1.Migrate();
            dbMigrator2.Migrate();

            /*
             OCP Open Close Principle in OOP

             Theory
             Software entities should be open for extensions
             and close for modifications.

             Practice
             We didn't change the DbMigrator
             we have extended the class using the extension point*
             
             *extension point -> public DbMigrator(ILogger logger*){ _logger = logger }
             */
            Console.ReadKey();
        }
    }
}
