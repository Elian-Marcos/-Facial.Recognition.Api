using Meeting.Management.Domain.Commands.Request;
using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Infrastructure.Interface
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<IEnumerable<User>> GetAll();
    }
}
