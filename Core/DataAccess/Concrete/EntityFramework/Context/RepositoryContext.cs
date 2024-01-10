using Core.Entities.Concrete.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework.Context
{
    public class RepositoryContext : DbContext
    {
        DbSet<User> Users { get; set; } = null!;

        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
