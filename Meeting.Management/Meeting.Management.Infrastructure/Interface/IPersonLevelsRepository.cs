using MediatR;
using Meetings.Management.Domain.Entities;

namespace Meetings.Management.Infrastructure.Interface
{
    public interface IPersonLevelsRepository
    {
        Task CreateAsync(Level level);
        Task<IEnumerable<Level>> GetAll();
        Task<Level> GetById(Guid id);
        Task DeleteAsync(Level level);
        Task UpdateAsync(Level level);
    }
}
