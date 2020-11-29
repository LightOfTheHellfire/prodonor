namespace Prodonor.Infrastructure.DbContextInitializers
{
    public interface IDbInitializer
    {
        void Seed();
    }

    public interface IEfDbUpdater : IDbInitializer { }

    public interface IDictionariesDataDbInitializer : IDbInitializer { }

    public interface IInitialDataDbInitializer : IDbInitializer { }
}