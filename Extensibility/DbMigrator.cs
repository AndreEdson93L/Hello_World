using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        //dependency injection
        //in the constructors we are specifying the dependencies of the DbMigrator class 
        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            //Details of migrating the database

            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }
    }
}
