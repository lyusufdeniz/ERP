using Ardalis.SmartEnum;

namespace ERPBackend.Domain.Enums
{
    public sealed class ProductTypeEnum : SmartEnum<ProductTypeEnum>
    {
        public static readonly ProductTypeEnum Product = new("Mamül", 1);
        public static readonly ProductTypeEnum SemiProduct = new(" YarıMamül", 2);
        public ProductTypeEnum(string name, int value) : base(name, value)
        {

        }
    }
}
