using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace FirstAPI.Data
{
    public class UserApiContext : DbContext
    {
        public UserApiContext (DbContextOptions<UserApiContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "John.Doe@dotmail.com" },
                new User { Id = 2, FirstName = "Jane", LastName = "Iyre", Email = "Jane.Iyre@dashmail.com" }
                );
        }

        public DbSet<FirstAPI.Models.User> Users { get; set; } = default!; 
    }
}
