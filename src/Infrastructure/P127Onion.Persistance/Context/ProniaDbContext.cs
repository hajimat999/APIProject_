using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127Onion.Persistance.Context
{
    public class ProniaDbContext: DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) :base(options)
        {

        }
    }
}
