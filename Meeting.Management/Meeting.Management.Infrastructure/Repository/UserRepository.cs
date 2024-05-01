using Meeting.Management.Domain.Commands.Request;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Context;
using Meeting.Management.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Meeting.Management.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(User user)
        {
            await _dbContext.User.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _dbContext.User.ToListAsync();
        }
    }
}
