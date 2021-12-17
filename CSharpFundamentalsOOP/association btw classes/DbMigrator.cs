namespace CSharpFundamentalsOOP
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("We are migrating the Db to another server..");
        }
    }
}
//MAIN, COMPOSITION (Has-a)

//var dbMigrator = new DbMigrator(new Logger());
//var logger = new Logger();
//var installer = new Installer(logger);

//dbMigrator.Migrate();
//installer.Install();
