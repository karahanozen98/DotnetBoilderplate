using DotnetBoilerplate.Core.CQRS;
using DotnetBoilerplate.Core.Exceptions;
using DotnetBoilerplate.Domain.Entities;
using DotnetBoilerplate.Infrastructure.Repository;

namespace DotnetBoilerplate.Application.Features.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand>
    {
        private readonly IGenericRepository<User> _userRepository;

        public UpdateUserCommandHandler(IGenericRepository<User> userRepository)
        {
            this._userRepository = userRepository;
        }
        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await this._userRepository.GetByIdAsync(request.Id);

            if (user == null)
            {
                throw new NotFoundException($"User not found with id {request.Id}");
            }

            user.SetFullname(request.FirstName, request.LastName);
            this._userRepository.Update(user);
            await _userRepository.SaveChangesAsync();
        }
    }
}