using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Infrastructure.Interface
{
    public interface IUserRepository
    {
        Task CreateAsync(Person user);
        Task<IEnumerable<Person>> GetAll();
    }
}
