using P127Onion.Domain.Entities;
using P127Onion.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P127Onion.Application.Interfaces
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        
    }
}
