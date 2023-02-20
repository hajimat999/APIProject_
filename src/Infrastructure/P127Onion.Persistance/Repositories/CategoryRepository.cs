using P127Onion.Application.Interfaces.Repositories;
using P127Onion.Domain.Entities;
using P127Onion.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127Onion.Persistance.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProniaDbContext context) : base(context)
        {

        }
        
       
   

    }
}
