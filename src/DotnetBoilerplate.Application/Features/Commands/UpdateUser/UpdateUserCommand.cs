
using DotnetBoilerplate.Core.CQRS;

namespace DotnetBoilerplate.Application.Features.Commands.UpdateUser
{
    public class UpdateUserCommand : ICommand
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}