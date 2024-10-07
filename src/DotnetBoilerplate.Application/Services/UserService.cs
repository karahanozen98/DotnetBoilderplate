using DotnetBoilerplate.Application.Dtos;
using DotnetBoilerplate.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DotnetBoilerplate.Application.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<GetAllUsersDto>> GetUsers(CancellationToken token)
        {
            var users = await this._context.Users.ToListAsync(token);
            return users.Select(user => new GetAllUsersDto(user));
        }
    }
}