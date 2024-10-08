using DotnetBoilerplate.Core.CQRS;

namespace DotnetBoilerplate.Application.Features.Commands.CreateUser
{
    public class CreateUserCommand : ICommand
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}