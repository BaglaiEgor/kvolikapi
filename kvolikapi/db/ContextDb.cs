using kvolikapi.Model;
using Microsoft.EntityFrameworkCore;

namespace kvolikapi.db
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
