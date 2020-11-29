namespace Prodonor.Infrastructure.DbContextInitializers
{
    /// <summary>
    /// Contains logic for feeding the initial db data for production DB
    /// </summary>
    public class InitialDataInitializer : IInitialDataDbInitializer
    {
        private ProdonorDbContext _dbContext;

        public InitialDataInitializer(ProdonorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
        }
    }
}