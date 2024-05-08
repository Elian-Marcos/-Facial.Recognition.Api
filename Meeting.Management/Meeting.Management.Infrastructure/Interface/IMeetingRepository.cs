using Meetings.Management.Domain.Entities;

namespace Meetings.Management.Infrastructure.Interface
{
    public interface IMeetingRepository
    {
        Task CreateAsync(Meeting meeeting);
        Task<IEnumerable<Meeting>> GetAll();
        Task<Meeting> GetById(Guid id);
        Task DeleteAsync(Meeting meeeting);
        Task UpdateAsync(Meeting meeeting);
    }
}
