using Microsoft.EntityFrameworkCore;
using P127Onion.Application.Interfaces;
using P127Onion.Domain.Entities.Base;
using P127Onion.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P127Onion.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: BaseEntity
    {
        private readonly ProniaDbContext context;

        public GenericRepository(ProniaDbContext context)
        {
            this.context = context;
        }
        public async Task<List<T>> GetAllAsync()
        {
            List<T> values = await context.Set<T>().ToListAsync();
            return values;
        }
        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            T value =await context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);          
            return value;
        }

       
    }
}
