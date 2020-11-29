using Microsoft.EntityFrameworkCore;
using Prodonor.Infrastructure.Model;

namespace Prodonor.Infrastructure
{
    public class ProdonorDbContext : DbContext
    {
        //        public DbSet<AddressInfoDao> AddressInfoes { get; set; }
        public DbSet<UserDao> Users { get; set; }
        public DbSet<CarrierDao> Carriers { get; set; }
        public DbSet<CarrierLocationDao> CarrierLocations { get; set; }
        public DbSet<CompanyDao> Companies { get; set; }
        public DbSet<CompanyRolesDao> CompanyRoles { get; set; }
        public DbSet<UserCompanyRolesDao> UserCompanyRoles { get; set; }
        public DbSet<DeliveryDao> Deliveries { get; set; }
        public DbSet<LocationDao> Locations { get; set; }
        public DbSet<OrderDao> Orders { get; set; }
        public DbSet<ProductCategoryDao> ProductCategories { get; set; }
        public DbSet<ProductDao> Products { get; set; }
        public DbSet<RoleDao> Roles { get; set; }
        public DbSet<StoreDao> Stores { get; set; }
        public DbSet<StoreRolesDao> StoreRoles { get; set; }
        public DbSet<UserStoreRolesDao> UserStoreRoles { get; set; }

        public ProdonorDbContext(DbContextOptions<ProdonorDbContext> options)
            : base((DbContextOptions) options)
        {
        }

	    protected override void OnModelCreating(ModelBuilder modelBuilder)
	    {
		    base.OnModelCreating(modelBuilder);

	        modelBuilder.Entity<StoreRolesDao>()
	            .HasOne(e => e.Role)
	            .WithMany(e => e.StoreRoles)
	            .OnDelete(DeleteBehavior.Restrict);

	        modelBuilder.Entity<StoreRolesDao>()
	            .HasOne(e => e.Store)
	            .WithMany(e => e.StoreRoles);

	        modelBuilder.Entity<UserStoreRolesDao>()
	            .HasOne(e => e.User)
	            .WithMany(e => e.UserStoreRoles);

	        modelBuilder.Entity<UserStoreRolesDao>()
	            .HasOne(e => e.StoreRoles)
	            .WithMany(e => e.UserStoreRoles);

	        modelBuilder.Entity<CompanyRolesDao>()
	            .HasOne(e => e.Role)
	            .WithMany(e => e.CompanyRoles)
	            .OnDelete(DeleteBehavior.Restrict);

	        modelBuilder.Entity<CompanyRolesDao>()
	            .HasOne(e => e.Company)
	            .WithMany(e => e.CompanyRoles);

	        modelBuilder.Entity<UserCompanyRolesDao>()
	            .HasOne(e => e.User)
	            .WithMany(e => e.UserCompanyRoles);

	        modelBuilder.Entity<UserCompanyRolesDao>()
	            .HasOne(e => e.CompanyRoles)
	            .WithMany(e => e.UserCompanyRoles);

	        modelBuilder.Entity<DeliveryDao>()
	            .HasOne(e => e.Order)
	            .WithMany(e => e.Deliveries);

	        modelBuilder.Entity<ProductDao>()
	            .HasOne(e => e.Category)
	            .WithMany(e => e.Products);

	        modelBuilder.Entity<OrderToProductDao>()
	            .HasOne(e => e.Order)
	            .WithMany(e => e.OrderToProducts);

	        modelBuilder.Entity<OrderToProductDao>()
	            .HasOne(e => e.Product)
	            .WithMany(e => e.OrderToProducts);

//	        modelBuilder.Entity<OrderDao>()
//	            .HasOne(e => e.Carrier)
//	            .WithMany(e => e.Orders);

	        modelBuilder.Entity<OrderDao>()
	            .Property(b => b.CreationTime)
	            .HasDefaultValueSql("getdate()");

	        modelBuilder.Entity<ProductCategoryDao>().HasData(
	            new ProductCategoryDao
                {
	                Id = 1,
	                Name = "Optical Mouse"
	            },
	            new ProductCategoryDao
                {
	                Id = 2,
	                Name = "Laser Mouse"
	            });

            modelBuilder.Entity<RoleDao>().HasData(
	            new RoleDao
	            {
                    Id = 1,
	                Name = "Owner"
	            },
	            new RoleDao
	            {
	                Id = 2,
                    Name = "Manager"
	            },
	            new RoleDao
	            {
	                Id = 3,
                    Name = "Employee"
	            });
	    }
    }
}