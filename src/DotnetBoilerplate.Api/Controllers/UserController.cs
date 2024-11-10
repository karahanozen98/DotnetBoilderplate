using DotnetBoilerplate.Application.Features.Commands.CreateUser;
using DotnetBoilerplate.Application.Features.Commands.UpdateUser;
using DotnetBoilerplate.Application.Features.Queries.GetAllUsers;
using DotnetBoilerplate.Application.Features.Queries.GetUserById;
using DotnetBoilerplate.Core.Api;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBoilerplate.Api.Controllers
{
    [Route("/api/v1/[Controller]")]
    [ApiController]
    public class UserController : ApiController
    {
        private readonly ISender _sender;

        public UserController(ISender sender)
        {
            this._sender = sender;
        }

        [HttpGet()]
        public async Task<ActionResult<ApiResponse<IEnumerable<GetAllUsersResponseDto>>>> GetAllUsers(CancellationToken cancellationToken)
        {
            var res = await this._sender.Send(new GetAllUsersQuery(), cancellationToken);
            return this.Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<GetUserByIdResponseDto>>> GetUserById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var res = await this._sender.Send(new GetUserByIdQuery(id), cancellationToken);
            return this.Ok(res);
        }

        [HttpPost()]
        public async Task<ActionResult<ApiResponse>> CreateUser([FromBody] CreateUserRequestDto user, CancellationToken cancellationToken)
        {
            await this._sender.Send(new CreateUserCommand
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
            }, cancellationToken);

            return this.Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse>> UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserRequestDto user, CancellationToken cancellationToken)
        {
            await this._sender.Send(new UpdateUserCommand
            {
                Id = id,
                FirstName = user.FirstName,
                LastName = user.LastName,
            }, cancellationToken);

            return this.Ok();
        }
    }
}