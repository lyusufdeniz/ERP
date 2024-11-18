namespace ERPBackend.Domain.Dtos;
public sealed record OrderDetailDto(
    Guid ProductId,
    decimal Quantity,
    decimal Price
    );

