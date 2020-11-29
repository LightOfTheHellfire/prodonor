using AutoMapper;
using Prodonor.Domain.Model;
using Prodonor.Infrastructure.Model;

namespace Prodonor.Infrastructure.AutoMapperProfiles
{
    public class InfrastructureMapperProfile:Profile
    {
        public InfrastructureMapperProfile()
        {
            CreateMap<User, UserDao>();
            CreateMap<UserDao, User>();
            CreateMap<Carrier, CarrierDao>();
            CreateMap<CarrierDao, Carrier>();
            CreateMap<CarrierLocation, CarrierLocationDao>();
            CreateMap<CarrierLocationDao, CarrierLocation>();
            CreateMap<Company, CompanyDao>();
            CreateMap<CompanyDao, Company>();
            CreateMap<CompanyRoles, CompanyRolesDao>();
            CreateMap<CompanyRolesDao, CompanyRoles>();
            CreateMap<Delivery, DeliveryDao>();
            CreateMap<DeliveryDao, Delivery>();
            CreateMap<Location, LocationDao>();
            CreateMap<LocationDao, Location>();
            CreateMap<Order, OrderDao>();
            CreateMap<OrderDao, Order>();
            CreateMap<ProductCategory, ProductCategoryDao>();
            CreateMap<ProductCategoryDao, ProductCategory>();
            CreateMap<Product, ProductDao>();
            CreateMap<ProductDao, Product>();
            CreateMap<Role, RoleDao>();
            CreateMap<RoleDao, Role>();
            CreateMap<Store, StoreDao>();
            CreateMap<StoreDao, Store>();
            CreateMap<StoreRoles, StoreRolesDao>();
            CreateMap<StoreRolesDao, StoreRoles>();
            CreateMap<UserCompanyRoles, UserCompanyRolesDao>();
            CreateMap<UserCompanyRolesDao, UserCompanyRoles>();
            CreateMap<UserStoreRoles, UserStoreRolesDao>();
            CreateMap<UserStoreRolesDao, UserStoreRoles>();
            CreateMap<OrderToProduct, OrderToProductDao>();
            CreateMap<OrderToProductDao, OrderToProduct>();
        }

    }
}
