using System.Threading.Tasks;
using JWTAPI.Core.Models;
using JWTAPI.Core.Services.Communication;

namespace JWTAPI.Core.Services
{
    public interface IUserService
    {
         Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
         Task<User> FindByEmailAsync(string email);
    }
}