﻿using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Depots.UpdateDepot
{
    public sealed record UpdateDepotCommand(
        Guid Id,
        string Name,
        string City,
        string Town,
        string FullAddress) :IRequest<Result<string>>
    {
    }
}
