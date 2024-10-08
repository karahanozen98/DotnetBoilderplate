using MediatR;

namespace DotnetBoilerplate.Core.CQRS
{
    public interface IQuery : IRequest { }

    public interface IQuery<TResponse> : IRequest<TResponse> { }
}