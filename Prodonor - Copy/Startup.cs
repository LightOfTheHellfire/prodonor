using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using Prodonor.Application.Model;
using Prodonor.Application.Services;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;
using Prodonor.Domain.Services;
using Prodonor.Infrastructure;
using Prodonor.Infrastructure.DbContextInitializers;
using Prodonor.Infrastructure.Model;
using Prodonor.Infrastructure.Repositories;

namespace Prodonor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddDbContext<ProdonorDbContext>(options =>
            {
                DbContextInitializerFactory.ConfigureDbOptions(options, Configuration);
            }, ServiceLifetime.Transient);
            services.AddTransient<IInitialDataDbInitializer, InitialDataInitializer>();
            services.AddTransient<IEfDbUpdater, DbAutoapplyMigrationsInitializer>();


            services.AddTransient<ApplicationUserService>();
            services.AddTransient<IApplicationService<CarrierDto>, CarrierAppService>();
            services.AddTransient<IApplicationService<CarrierLocationDto>, CarrierLocationAppService>();
            services.AddTransient<IApplicationService<CompanyDto>, CompanyAppService>();
            services.AddTransient<IApplicationService<CompanyRolesDto>, CompanyRolesAppService>();
            services.AddTransient<IApplicationService<DeliveryDto>, DeliveryAppService>();
            services.AddTransient<IApplicationService<LocationDto>, LocationAppService>();
            services.AddTransient<IApplicationService<OrderDto>, OrderAppService>();
            services.AddTransient<IApplicationService<ProductDto>, ProductAppService>();
            services.AddTransient<IApplicationService<ProductCategoryDto>, ProductCategoryAppService>();
            services.AddTransient<IApplicationService<RoleDto>, RoleAppService>();
            services.AddTransient<IApplicationService<StoreDto>, StoreAppService>();
            services.AddTransient<IApplicationService<StoreRolesDto>, StoreRolesAppService>();
            services.AddTransient<IApplicationService<UserCompanyRolesDto>, UserCompanyRolesAppService>();
            services.AddTransient<IApplicationService<UserStoreRolesDto>, UserStoreRolesAppService>();
            services.AddTransient<IApplicationService<OrderToProductDto>, OrderToProductAppService>();


            services.AddTransient<UserService>();
            services.AddTransient<IDomainService<Carrier>, CarrierService>();
            services.AddTransient<IDomainService<CarrierLocation>, CarrierLocationService>();
            services.AddTransient<IDomainService<CompanyRoles>, CompanyRolesService>();
            services.AddTransient<IDomainService<Company>, CompanyService>();
            services.AddTransient<IDomainService<Delivery>, DeliveryService>();
            services.AddTransient<IDomainService<Location>, LocationService>();
            services.AddTransient<IDomainService<Order>, OrderService>();
            services.AddTransient<IDomainService<ProductCategory>, ProductCategoryService>();
            services.AddTransient<IDomainService<Product>, ProductService>();
            services.AddTransient<IDomainService<Role>, RoleService>();
            services.AddTransient<IDomainService<StoreRoles>, StoreRolesService>();
            services.AddTransient<IDomainService<Store>, StoreService>();
            services.AddTransient<IDomainService<UserCompanyRoles>, UserCompanyRolesService>();
            services.AddTransient<IDomainService<UserStoreRoles>, UserStoreRolesService>();
            services.AddTransient<IDomainService<OrderToProduct>, OrderToProductService>();


            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRepository<CarrierLocation>, BaseRepository<CarrierLocation, CarrierLocationDao>>();
            services.AddTransient<IRepository<Carrier>, BaseRepository<Carrier, CarrierDao>>();
            services.AddTransient<IRepository<CompanyRoles>, BaseRepository<CompanyRoles, CompanyRolesDao>>();
            services.AddTransient<IRepository<Company>, BaseRepository<Company, CompanyDao>>();
            services.AddTransient<IRepository<Delivery>, BaseRepository<Delivery, DeliveryDao>>();
            services.AddTransient<IRepository<Location>, BaseRepository<Location, LocationDao>>();
            services.AddTransient<IRepository<Order>, BaseRepository<Order, OrderDao>>();
            services.AddTransient<IRepository<ProductCategory>, BaseRepository<ProductCategory, ProductCategoryDao>>();
            services.AddTransient<IRepository<Product>, BaseRepository<Product, ProductDao>>();
            services.AddTransient<IRepository<Role>, BaseRepository<Role, RoleDao>>();
            services.AddTransient<IRepository<StoreRoles>, BaseRepository<StoreRoles, StoreRolesDao>>();
            services.AddTransient<IRepository<Store>, BaseRepository<Store, StoreDao>>();
            services.AddTransient<IRepository<UserCompanyRoles>, BaseRepository<UserCompanyRoles, UserCompanyRolesDao>>();
            services.AddTransient<IRepository<UserStoreRoles>, BaseRepository<UserStoreRoles, UserStoreRolesDao>>();
            services.AddTransient<IRepository<OrderToProduct>, BaseRepository<OrderToProduct, OrderToProductDao>>();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(configuration =>
            {
                configuration.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            var container = services.BuildServiceProvider();
            services.AddAutoMapper(expression =>
            {
                expression.ConstructServicesUsing(type =>
                {
                    var scopeFactory = container.GetRequiredService<IServiceScopeFactory>();
                    using (var scope = scopeFactory.CreateScope())
                    {
                        var contextAccessor = scope.ServiceProvider.GetRequiredService<IHttpContextAccessor>();
                        return contextAccessor.HttpContext.RequestServices.GetRequiredService<ProdonorDbContext>();
                    }
                });
                expression.AddCollectionMappers();
                expression.AllowNullCollections = true;
                expression.AllowNullDestinationValues = true;
            });

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = context =>
                        {
                            var userService = context.HttpContext.RequestServices.GetRequiredService<ApplicationUserService>();
                            var userId = int.Parse(context.Principal.Identity.Name);
                            var user = userService.GetById(userId);
                            if (user == null)
                            {
                                // return unauthorized if user no longer exists
                                context.Fail("Unauthorized");
                            }
                            return Task.CompletedTask;
                        }
                    };
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IEfDbUpdater dbMigrator, IInitialDataDbInitializer dataDbInitializer)
        {
            if (Configuration.GetSection("EntityFramework").GetValue("AutoApplyMigrations", false))
            {
                dbMigrator?.Seed();
            }

            dataDbInitializer?.Seed();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
