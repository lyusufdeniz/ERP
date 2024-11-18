using AutoMapper;
using ERPBackend.Application.Features.Customers.CreateCustomer;
using ERPBackend.Application.Features.Customers.UpdateCustomer;
using ERPBackend.Application.Features.Depots.CreateDepot;
using ERPBackend.Application.Features.Depots.UpdateDepot;
using ERPBackend.Application.Features.Orders.CreateOrder;
using ERPBackend.Application.Features.Orders.UpdateOrder;
using ERPBackend.Application.Features.Products.CreateProduct;
using ERPBackend.Application.Features.Products.UpdateProduct;
using ERPBackend.Application.Features.RecipeDetails.CreateRecipeDetail;
using ERPBackend.Application.Features.RecipeDetails.UpdateRecipeDetail;
using ERPBackend.Domain.Entities;
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
            CreateMap<CreateRecipeDetailCommand, RecipeDetail>();
            CreateMap<UpdateRecipeDetailCommand, RecipeDetail>();

            CreateMap<CreateOrderCommand, Order>()
          .ForMember(member => member.Details,
          options =>
          options.MapFrom(p => p.Details.Select(s => new OrderDetail
          {
              Price = s.Price,
              ProductId = s.ProductId,
              Quantity = s.Quantity
          }).ToList()));

            CreateMap<UpdateOrderCommand, Order>()
                .ForMember(member =>
                member.Details,
                options => options.Ignore());


        }
    }
}
