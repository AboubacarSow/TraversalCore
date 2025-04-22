using Entities.Models;

namespace Services.Contracts
{
    public interface IUserService
    {
        Task Login(AppUser user);
        Task Register(AppUser user);
        Task Logout();
    }
}
