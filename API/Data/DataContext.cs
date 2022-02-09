using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // Default Construct from the DataContext Class
        public DataContext(DbContextOptions options) : base(options)
        {
        }


        // Dbset represents th etables inside the database and type will be the entity declared
        public DbSet<AppUser> Users { get; set; }
    }
}