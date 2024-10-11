using DotnetBoilerplate.Core.CQRS;

namespace DotnetBoilerplate.Application.Features.Queries.GetUserById
{
    public class GetUserByIdQuery : IQuery<GetUserByIdResponseDto>
    {
        public Guid Id { get; set; }

        public GetUserByIdQuery(Guid id)
        {
            this.Id = id;
        }
    }
}