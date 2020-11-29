using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Prodonor.Infrastructure.DbContextInitializers
{
    /// <summary>
    /// Contains logic for automatically apply the migrations to database
    /// </summary>
    public class DbAutoapplyMigrationsInitializer : IEfDbUpdater
    {
        private readonly ProdonorDbContext _dbContext;

        public DbAutoapplyMigrationsInitializer(ProdonorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.GetPendingMigrations().Any())
            {
                _dbContext.Database.Migrate();
            }
        }
    }
}