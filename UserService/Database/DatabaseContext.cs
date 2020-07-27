using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Database
{
    public class DatabaseContext : DbContext
    {

        public DbSet<User> User { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=.;Database=UserMicorservices;Trusted_Connection=True;");
        }
    }
}
