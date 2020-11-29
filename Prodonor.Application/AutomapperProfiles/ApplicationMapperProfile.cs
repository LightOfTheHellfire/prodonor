using System;
using System.Collections.Generic;
using AutoMapper;
using Prodonor.Application.Model;
using Prodonor.Domain.Model;

namespace eSubmitter.App.Application.AutomapperProfiles
{
    public class ApplicationMapperProfile : Profile
    {
        public ApplicationMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Carrier, CarrierDto>();
            CreateMap<CarrierDto, Carrier>();
            CreateMap<CarrierLocation, CarrierLocationDto>();
            CreateMap<CarrierLocationDto, CarrierLocation>();
            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyDto, Company>();
            CreateMap<CompanyRoles, CompanyRolesDto>();
            CreateMap<CompanyRolesDto, CompanyRoles>();
            CreateMap<Delivery, DeliveryDto>();
            CreateMap<DeliveryDto, Delivery>();
            CreateMap<Location, LocationDto>();
            CreateMap<LocationDto, Location>();
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
            CreateMap<ProductCategory, ProductCategoryDto>();
            CreateMap<ProductCategoryDto, ProductCategory>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();
            CreateMap<Store, StoreDto>();
            CreateMap<StoreDto, Store>();
            CreateMap<StoreRoles, StoreRolesDto>();
            CreateMap<StoreRolesDto, StoreRoles>();
            CreateMap<UserCompanyRoles, UserCompanyRolesDto>();
            CreateMap<UserCompanyRolesDto, UserCompanyRoles>();
            CreateMap<UserStoreRoles, UserStoreRolesDto>();
            CreateMap<UserStoreRolesDto, UserStoreRoles>();
            CreateMap<OrderToProduct, OrderToProductDto>();
            CreateMap<OrderToProductDto, OrderToProduct>();
        }
    } 
}
