using Microsoft.AspNetCore.Mvc;

namespace DotnetBoilerplate.Api.Controllers
{
    [Route("/api/v1/[Controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetAllProducts(CancellationToken cancellationToken)
        {
            return await Task.FromResult<string>("Ok");
        }
    }
}