using MediatR;

namespace DotnetBoilerplate.Core.CQRS
{
    public interface ICommandHandler<TRequest> : IRequestHandler<TRequest> where TRequest : ICommand { }

    public interface ICommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : ICommand<TResponse> { }
}