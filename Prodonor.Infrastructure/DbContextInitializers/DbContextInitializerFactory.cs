using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Prodonor.Infrastructure.DbContextInitializers
{
    public class DbContextInitializerFactory : IDesignTimeDbContextFactory<ProdonorDbContext>
    {
        public ProdonorDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<ProdonorDbContext>();
            ConfigureDbOptions(optionsBuilder, config);

            return new ProdonorDbContext(optionsBuilder.Options);
        }

        public static void ConfigureDbOptions(DbContextOptionsBuilder options, IConfiguration config)
        {
            string connection = config.GetConnectionString("DataAccessMySqlProvider");
            var dbConnectionProvider = config.GetSection("EntityFramework").GetValue("DbProvider", "SqlServer");
            switch (dbConnectionProvider)
            {
                case "SqlServer":
                    options.UseSqlServer(connection, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds));
                    break;
                //case "MySql":
                //    options.UseMySql(Configuration.GetConnectionString("DataAccessMySqlProvider"), b => b.MigrationsAssembly("eSubmitter.WebApp"))

                default:
                    throw new Exception("Unsupported db connection provider");
            }
        }
    }
}