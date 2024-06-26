﻿using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Context;
using Meetings.Management.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Meetings.Management.Infrastructure.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _dbContext;

        public PersonRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Person person)
        {
            await _dbContext.Person.AddAsync(person);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _dbContext.Person.ToListAsync();
        }

        public async Task<Person> GetById(Guid id)
        {
            var query = from u in _dbContext.Person
                        where u.Id.Equals(id)
                        select u;

            return await query.FirstAsync();
        }

        public async Task DeleteAsync(Person person)
        {
            _dbContext.Person.Remove(person);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Person person)
        {
            _dbContext.Entry(person).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }



    }
}
