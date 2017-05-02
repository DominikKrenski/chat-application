using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    class ServiceDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
