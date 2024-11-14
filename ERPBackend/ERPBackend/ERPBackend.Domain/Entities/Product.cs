using ERPBackend.Domain.Abstractions;
using ERPBackend.Domain.Enums;

namespace ERPBackend.Domain.Entities
{
    public sealed class Product:Entity
    {
        public string Name { get; set; } = string.Empty;
        public ProductTypeEnum Type { get; set; } = ProductTypeEnum.Product;
    }
}
