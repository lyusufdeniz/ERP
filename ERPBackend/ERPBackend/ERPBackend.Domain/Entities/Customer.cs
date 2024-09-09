using ERPBackend.Domain.Abstractions;

namespace ERPBackend.Domain.Entities.Customer
{
    public  class Customer:Entity
    {
        public string Name { get; set; } = string.Empty;
        public string? TaxDepartment { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Town { get; set; } = string.Empty;
        public string FullAddress { get; set; } = string.Empty;
        public bool State { get; set; } = true;



    }
}
