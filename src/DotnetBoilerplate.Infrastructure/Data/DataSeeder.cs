using DotnetBoilerplate.Domain.Entities;

namespace DotnetBoilerplate.Infrastructure.Data
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext _context;
        
        public DataSeeder(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void SeedData()
        {
            if (!this._context.Users.Any())
            {
                this._context.Users.AddRange(
                    new User("someemail@example.com", "John", "Doe", "X4yd!456dtouv")
                );
            }

            this._context.SaveChanges();
        }
    }
}