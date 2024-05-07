using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Infrastructure.Interface
{
    public interface IPersonRepository
    {
        Task CreateAsync(Person user);
        Task<IEnumerable<Person>> GetAll();
        Task<Person> GetById(Guid id);
        Task DeleteAsync(Person person);
        Task UpdateAsync(Person person);
    }
}
