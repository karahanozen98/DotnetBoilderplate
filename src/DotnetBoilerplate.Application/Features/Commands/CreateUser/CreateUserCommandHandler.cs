using DotnetBoilerplate.Core.CQRS;
using DotnetBoilerplate.Domain.Entities;
using DotnetBoilerplate.Infrastructure.Repository;

namespace DotnetBoilerplate.Application.Features.Commands.CreateUser
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IGenericRepository<User> _userRepository;

        public CreateUserCommandHandler(IGenericRepository<User> userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await this._userRepository.AddAsync(new User(
                email: request.Email,
                firstName: request.FirstName,
                lastName: request.LastName,
                password: request.Password
            ));

            await this._userRepository.SaveChangesAsync();
        }
    }
}