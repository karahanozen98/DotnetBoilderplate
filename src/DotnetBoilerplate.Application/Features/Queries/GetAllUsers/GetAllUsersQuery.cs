using DotnetBoilerplate.Application.Dtos.Response;
using DotnetBoilerplate.Core.CQRS;

namespace DotnetBoilerplate.Application.Features.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IQuery<IEnumerable<GetAllUsersDto>> { }
}