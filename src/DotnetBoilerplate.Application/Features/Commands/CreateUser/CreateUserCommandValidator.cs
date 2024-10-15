using FluentValidation;

namespace DotnetBoilerplate.Application.Features.Commands.CreateUser
{
    public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(command => command.FirstName).NotEmpty().MinimumLength(2).MaximumLength(20);
            RuleFor(command => command.LastName).NotEmpty().MinimumLength(2).MaximumLength(20);
            RuleFor(command => command.Email).NotEmpty().EmailAddress();
            RuleFor(command => command.Password).NotEmpty().MinimumLength(8).MaximumLength(20);
        }
    }
}