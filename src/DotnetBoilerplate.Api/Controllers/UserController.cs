using DotnetBoilerplate.Application.Dtos;
using DotnetBoilerplate.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBoilerplate.Api.Controllers
{
    [Route("/api/v1/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            this._userService = userService;

        }

        [HttpGet("GetAllUsers")]
        public async Task<IEnumerable<GetAllUsersDto>> GetAllUsers(CancellationToken cancellationToken)
        {
            return await this._userService.GetUsers(cancellationToken);
        }
    }
}