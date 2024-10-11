using DotnetBoilerplate.Core.CQRS;
using DotnetBoilerplate.Domain.Entities;
using DotnetBoilerplate.Infrastructure.Repository;

namespace DotnetBoilerplate.Application.Features.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, IEnumerable<GetAllUsersResponseDto>>
    {
        private readonly IGenericRepository<User> _userRepository;

        public GetAllUsersQueryHandler(IGenericRepository<User> userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<IEnumerable<GetAllUsersResponseDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(user => new GetAllUsersResponseDto(user));
        }
    }
}