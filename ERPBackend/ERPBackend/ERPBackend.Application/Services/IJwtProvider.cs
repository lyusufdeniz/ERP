using ERPBackend.Application.Features.Auth.Login;
using ERPBackend.Domain.Entities;

namespace ERPBackend.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
