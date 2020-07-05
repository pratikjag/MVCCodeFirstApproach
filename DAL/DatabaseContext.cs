using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext():base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> categories { get; set; }

    }
}
