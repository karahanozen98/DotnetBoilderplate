using MediatR;

namespace DotnetBoilerplate.Core.CQRS
{
    public interface ICommand : IRequest { }

    public interface ICommand<TResponse> : IRequest<TResponse> { }
}