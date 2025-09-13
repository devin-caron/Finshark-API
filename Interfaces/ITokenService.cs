using Finshark_api.Models;

namespace Finshark_api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
