using DotnetBoilerplate.Application.Dtos.Request;
using DotnetBoilerplate.Application.Dtos.Response;
using DotnetBoilerplate.Application.Features.Commands.CreateUser;
using DotnetBoilerplate.Application.Features.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBoilerplate.Api.Controllers
{
    [Route("/api/v1/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IEnumerable<GetAllUsersDto>> GetAllUsers(CancellationToken cancellationToken)
        {
            return await this._mediator.Send(new GetAllUsersQuery(), cancellationToken);
        }

        [HttpPost("CreateUser")]
        public async Task CreateUser([FromBody] CreateUserRequest user, CancellationToken cancellationToken)
        {
            await this._mediator.Send(new CreateUserCommand
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
            }, cancellationToken);
        }
    }
}