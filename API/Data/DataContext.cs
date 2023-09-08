using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DataContext()
        {
        }
      /* public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext(options =>
                options.UseSqlServer("Data Source=localhost;Initial Catalog=MyDatabase;Integrated Security=True"));
        }*/
        public DbSet<AppUser> Users { get; set; }
    }
}