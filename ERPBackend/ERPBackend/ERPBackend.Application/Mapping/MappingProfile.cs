using AutoMapper;
using ERPBackend.Application.Features.Customers.CreateCustomer;
using ERPBackend.Application.Features.Customers.UpdateCustomer;
using ERPBackend.Application.Features.Depots.CreateDepot;
using ERPBackend.Application.Features.Depots.UpdateDepot;
using ERPBackend.Application.Features.Products.CreateProduct;
using ERPBackend.Application.Features.Products.UpdateProduct;
using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Entities.Customer;
using ERPBackend.Domain.Enums;

namespace ERPBackend.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>();
            CreateMap<UpdateCustomerCommand, Customer>();

            CreateMap<CreateDepotCommand,Depot>();
            CreateMap<UpdateDepotCommand, Depot>();

            CreateMap<CreateProductCommand, Product>().ForMember(member=>member.Type,options=>options.MapFrom(value=>ProductTypeEnum.FromValue(value.TypeValue)));
            CreateMap<UpdateProductCommand, Product>().ForMember(member => member.Type, options => options.MapFrom(value => ProductTypeEnum.FromValue(value.TypeValue)));


        }
    }
}
