using AutoMapper;
using ERPBackend.Application.Features.Customers.CreateCustomer;
using ERPBackend.Application.Features.Customers.UpdateCustomer;
using ERPBackend.Application.Features.Depots.CreateDepot;
using ERPBackend.Application.Features.Depots.UpdateDepot;
using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Entities.Customer;

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

        }
    }
}
