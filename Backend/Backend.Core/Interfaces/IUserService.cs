using Backend.Core.Models;
using Backend.Infrastructure.Models;
 using System.Net;
 using Backend.Core.Models.User;

namespace Backend.Core.Interfaces
{
    public interface IUserService
    {
        User? Get(LoginUser loginUser);
        HttpStatusCode Create(RegisterUser registerUser);
    }
}
