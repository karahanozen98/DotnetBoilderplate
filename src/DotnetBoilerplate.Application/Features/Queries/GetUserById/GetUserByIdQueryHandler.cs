using DotnetBoilerplate.Core.CQRS;
using DotnetBoilerplate.Core.Exceptions;
using DotnetBoilerplate.Domain.Entities;
using DotnetBoilerplate.Infrastructure.Repository;

namespace DotnetBoilerplate.Application.Features.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, GetUserByIdResponseDto>
    {
        private readonly IGenericRepository<User> _userRepository;

        public GetUserByIdQueryHandler(IGenericRepository<User> userRepository)
        {
            this._userRepository = userRepository;
        }
        public async Task<GetUserByIdResponseDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await this._userRepository.GetByIdAsync(request.Id);

            if (user == null)
            {
                throw new NotFoundException($"User not found with id {request.Id}");
            }

            return new GetUserByIdResponseDto(user);
        }
    }
}